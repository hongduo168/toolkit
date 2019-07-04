using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolkit.WinForm.ApiDesign;
using Toolkit.WinForm.ApiDesign.Model;

namespace Toolkit.WinForm
{
    public partial class FormProjectInfo : Form
    {

        private Dictionary<string, Form> openedForms = new Dictionary<string, Form>();

        private Form openerForm;
        public FormProjectInfo(string sid, Form opener)
        {
            InitializeComponent();
            this.openerForm = opener;
            LoadData(sid);
        }

        private MDIMain MDIMain => this.ParentForm as MDIMain;

        System.Threading.Thread thread;

        public ProjectInfo Project { get; set; }

        internal void LoadData(string sid)
        {
            if (!string.IsNullOrEmpty(sid))
                this.Project = DataProvider.Instance().GetProject(sid);

            if (this.Project == null)
            {
                this.Project = new ProjectInfo();
                this.Text = string.Format("新增项目");
            }
            else
            {
                this.Text = string.Format("项目[{0}]", this.Project.ProjectName);
            }
            this.BindData();
        }


        private void BindData()
        {
            this.tbName.Text = this.Project.ProjectName;
            this.tbNamespace.Text = this.Project.Namespace;
            this.tbVersion.Text = this.Project.Version;


            //加载接口
            this.lbApi.DataSource = null;
            this.lbApi.DataSource = this.Project.ApiInterfaces;
            this.lbApi.DisplayMember = "ApiName";
            this.lbApi.ValueMember = "SID";
        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Project.Namespace = this.tbNamespace.Text;
            this.Project.ProjectName = this.tbName.Text;
            this.Project.Version = this.tbVersion.Text;
            DataProvider.Instance().SaveProject(this.Project);

            if (openerForm is FormProjectList)
            {
                (openerForm as FormProjectList).InitializeData();
            }
        }


        private List<int> foundId = new List<int>();
        private int foundIndex = 0;
        private void BtnFind_Click(object sender, EventArgs e)
        {
            this.BtnClearFind_Click(sender, e);
            if (!foundId.Any())
            {
                for (var i = 0; i < this.Project.ApiInterfaces.Count; i++)
                {
                    var apis = this.Project.ApiInterfaces[i];
                    var keyword = this.tbKeywords.Text.Trim();
                    if (apis.ApiName.Contains(keyword) || apis.ActionName.Contains(keyword) || apis.ActionRoute.Contains(keyword))
                    {
                        foundId.Add(i);
                    }
                }
            }

            this.lbApi.ClearSelected();
            if (foundId.Count > 0)
            {

                if (foundIndex >= foundId.Count())
                {
                    foundIndex = 0;
                }

                this.lbApi.SetSelected(foundId[foundIndex], true);

                foundIndex++;
            }
        }

        private void BtnClearFind_Click(object sender, EventArgs e)
        {
            this.lbApi.ClearSelected();
            foundIndex = 0;
            foundId = new List<int>();
        }


        private delegate void CreateCSharpCodeCallback(List<ApiInterfaceInfo> apiInterfaces);
        private void BtnCreateSelected_Click(object sender, EventArgs e)
        {
            if (this.lbApi.SelectedIndex < 0)
            {
                MessageBox.Show("请选择需要生成的接口");
                return;
            }

            thread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                List<ApiInterfaceInfo> list = new List<ApiInterfaceInfo>();

                foreach (ApiInterfaceInfo item in this.lbApi.SelectedItems)
                {
                    list.Add(item);
                }

                CreateCSharpCodeCallback cb = new CreateCSharpCodeCallback(BuildCSharpCode);
                this.Invoke(cb, list);
                thread.Abort();

            }));

            thread.IsBackground = true;
            thread.Start();
        }

        private void BtnCreateAll_Click(object sender, EventArgs e)
        {
            thread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                CreateCSharpCodeCallback cb = new CreateCSharpCodeCallback(BuildCSharpCode);
                this.Invoke(cb, this.Project.ApiInterfaces);
                thread.Abort();
            }));

            thread.IsBackground = true;
            thread.Start();
        }


        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var formSID = nameof(FormApi);

            if (!openedForms.ContainsKey(formSID))
            {
                var form = new FormApi(this.Project, this);
                form.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                form.MdiParent = this.ParentForm;

                openedForms[formSID] = form;
                openedForms[formSID].Show();
            }

        }

        private void LbApi_DoubleClick(object sender, EventArgs e)
        {
            if (this.lbApi.SelectedIndex < 0) return;
            var apiData = (ApiInterfaceInfo)this.lbApi.Items[this.lbApi.SelectedIndex];

            if (!openedForms.ContainsKey(apiData.SID))
            {
                var form = new FormApi(this.Project, this, apiData);
                form.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                form.MdiParent = this.MdiParent;

                openedForms[apiData.SID] = form;
                openedForms[apiData.SID].Show();
            }
        }


        #region generate code

        private void BuildCSharpCode(List<ApiInterfaceInfo> apiInterfaces)
        {
            this.HandleButtonBeforeCreate();


            if (this.MDIMain != null)
            {
                this.MDIMain.toolStripProgressBar1.Minimum = 0;
                this.MDIMain.toolStripProgressBar1.Maximum = apiInterfaces.Count();
            }
            var index = 1;
            //var o = new ParallelOptions();
            //o.MaxDegreeOfParallelism = Environment.ProcessorCount;
            //System.Threading.Tasks.Parallel.ForEach(apiInterfaces, o, (apiData) =>
            //{

            //});

            foreach (var item in apiInterfaces)
            {

                if (this.MDIMain != null)
                {
                    this.MDIMain.toolStripProgressBar1.Value = index;
                    this.MDIMain.toolStripStatusLabel1.Text = string.Format("{0}/{1},生成[{2}]", index++, apiInterfaces.Count(), item.ApiName);
                }
                this.GenerateController(item);
            }

            this.HandleButtonAfterCreate();
        }


        /// <summary>
        /// generate csharp code
        /// </summary>
        /// <param name="apiData"></param>
        private void GenerateController(ApiInterfaceInfo apiData)
        {
            try
            {
                apiData.Project = this.Project;
                //创建RequestBody
                var razor = new TemplateBuilder<object>(
                    AppDomain.CurrentDomain.BaseDirectory + "/templates/request_body.txt",
                    apiData,
                    string.Format("{0}.ViewModel.{1}", this.Project.Namespace, apiData.ApiCode),
                    Path.Combine(apiData.ApiCode + apiData.ActionName, apiData.ActionName + "RequestModel.cs"));
                razor.Render();


                ////创建responseBody
                razor = new TemplateBuilder<object>(
                    AppDomain.CurrentDomain.BaseDirectory + "/templates/response_body.txt",
                    apiData,
                    string.Format("{0}.ViewModel.{1}", this.Project.Namespace, apiData.ApiCode),
                    Path.Combine(apiData.ApiCode + apiData.ActionName, apiData.ActionName + "ResponseModel.cs"));
                razor.Render();

                //创建service
                razor = new TemplateBuilder<object>(
                   AppDomain.CurrentDomain.BaseDirectory + "/templates/controller.txt",
                   apiData,
                   string.Format("{0}.Controllers.v{1}", this.Project.Namespace, this.Project.Version),
                   Path.Combine(apiData.ApiCode + apiData.ActionName, apiData.ActionName + ".cs"));
                razor.Render();


                //创建构造函数
                razor = new TemplateBuilder<object>(
                   AppDomain.CurrentDomain.BaseDirectory + "/templates/constructor.txt",
                   apiData,
                   string.Format("{0}.Controllers.v{1}", this.Project.Namespace, this.Project.Version),
                   (apiData.ApiCode + "Controller.cs"));
                razor.Render(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.ToString());
                //Application.Exit();
            }


        }

        /// <summary>
        /// generate js code
        /// </summary>
        /// <param name="apiData"></param>
        private void GenerateJSService(ProjectInfo project)
        {
            try
            {

                //创建JS Service
                var razor = new TemplateBuilder<object>(
                    AppDomain.CurrentDomain.BaseDirectory + "/templates/js-service.txt",
                    project,
                    string.Empty,
                    (project.Namespace.ToLower().Replace(".", "_") + "_service.js"));
                razor.Render();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.ToString());
                //Application.Exit();
            }
        }


        private void HandleButtonBeforeCreate()
        {
            this.btnCreateSelected.Enabled = this.btnCreateSelected.Visible = false;
            this.btnCreateJSService.Enabled = this.btnCreateJSService.Visible = false;
            this.btnCreateAll.Enabled = this.btnCreateAll.Visible = false;
            if (this.ParentForm is MDIMain)
            {
                (this.ParentForm as MDIMain).toolStripProgressBar1.Visible = true;
                (this.ParentForm as MDIMain).toolStripStatusLabel1.Visible = true;
            }
        }

        private void HandleButtonAfterCreate()
        {
            this.btnCreateAll.Enabled = this.btnCreateAll.Visible = true;
            this.btnCreateJSService.Enabled = this.btnCreateJSService.Visible = true;
            this.btnCreateSelected.Enabled = this.btnCreateSelected.Visible = true;
            if (this.MDIMain != null)
            {
                this.MDIMain.toolStripProgressBar1.Visible = false;
                this.MDIMain.toolStripStatusLabel1.Visible = false;
            }
        }
        #endregion

        #region form closed
        private void Form_FormClosed(Object sender, FormClosedEventArgs e)
        {
            if (sender is FormApi)
            {
                var form = (sender as FormApi);
                var item = openedForms.FirstOrDefault(x => x.Value == form);
                openedForms.Remove(item.Key);
            }
        }
        #endregion

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.lbApi.SelectedIndex < 0)
            {
                MessageBox.Show("请选择需要删除的接口");
                return;
            }
            var dialogResult = MessageBox.Show("确认删除", "是否删除接口？", MessageBoxButtons.OKCancel);
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var row = this.Project.ApiInterfaces.ElementAt(this.lbApi.SelectedIndex);
                DataProvider.Instance().DeleteApi(row);

                this.Project.ApiInterfaces.RemoveAt(this.lbApi.SelectedIndex);
                this.BindData();
                //this.LoadData("");
            }


        }

        private delegate void CreateJSServiceCallback(ProjectInfo project);
        private void BtnCreateJSService_Click(object sender, EventArgs e)
        {
            thread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                CreateJSServiceCallback cb = new CreateJSServiceCallback(GenerateJSService);
                this.Invoke(cb, this.Project);
                thread.Abort();
            }));

            thread.IsBackground = true;
            thread.Start();

            #region 进度条

            if (this.MDIMain != null)
            {
                this.MDIMain.toolStripProgressBar1.Value = 0;
                this.HandleButtonBeforeCreate();
                for (int i = 0; i < this.MDIMain.toolStripProgressBar1.Maximum; i++)
                {
                    this.MDIMain.toolStripProgressBar1.Value++;
                    this.MDIMain.toolStripStatusLabel1.Text = string.Empty;
                    Thread.Sleep((2000 / this.MDIMain.toolStripProgressBar1.Maximum));
                }
                this.HandleButtonAfterCreate();
            }

            #endregion

        }
    }
}
