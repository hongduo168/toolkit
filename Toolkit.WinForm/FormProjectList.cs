using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolkit.WinForm.ApiDesign;
using Toolkit.WinForm.ApiDesign.Model;

namespace Toolkit.WinForm
{
    public partial class FormProjectList : Form
    {
        private List<ProjectInfo> ProjectData;
        public FormProjectList()
        {
            InitializeComponent();

            InitializeData();
        }

        private Dictionary<string, Form> openedForms = new Dictionary<string, Form>();


        private MDIMain MDIMain => this.ParentForm as MDIMain;

        internal void InitializeData()
        {
            ProjectData = DataProvider.Instance().GetProject();

            this.lbProject.DataSource = null;
            this.lbProject.Items.Clear();
            if (ProjectData != null && ProjectData.Count > 0)
            {
                this.lbProject.DataSource = ProjectData.Select(t => string.Format("{0}({1})", t.ProjectName, t.Namespace)).ToArray();
            }
        }

        private void LbProject_DoubleClick(object sender, EventArgs e)
        {
            if (this.lbProject.SelectedIndex < 0) return;
            var item = ProjectData.ElementAt(this.lbProject.SelectedIndex);

            if (openedForms.ContainsKey(item.SID))
            {
                return;
            }
            var form = new FormProjectInfo(item.SID, this);
            form.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            form.MdiParent = this.ParentForm;

            openedForms[item.SID] = form;
            openedForms[item.SID].Show();
        }


        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var formSID = "createForm";
            if (!openedForms.ContainsKey(formSID))
            {
                var form = new FormProjectInfo(string.Empty, this);
                form.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                form.MdiParent = this.ParentForm;

                openedForms[formSID] = form;
                openedForms[formSID].Show();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.lbProject.SelectedIndex < 0) return;


            var dr = MessageBox.Show("确认删除项目？", "提示", MessageBoxButtons.OKCancel);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.btnDelete.Enabled = false;
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                bgwDeleteProject.RunWorkerAsync(this.lbProject.SelectedIndex);
            }

        }

        #region delete background work

        private void BgwDeleteProject_DoWork(object sender, DoWorkEventArgs e)
        {
            var item = this.ProjectData[(int)e.Argument];
            item = DataProvider.Instance().GetProject(item.SID);
            if (item != null)
            {
                if (item.ApiInterfaces != null)
                {
                    int __loop = 0;
                    foreach (var yid in item.ApiInterfaces)
                    {
                        __loop++;

                        DataProvider.Instance().DeleteApi(yid);
                        this.bgwDeleteProject.ReportProgress((int)Math.Floor(__loop / 100.00));
                    }
                }

                this.bgwDeleteProject.ReportProgress(99);
            }
            DataProvider.Instance().DeleteProject(item.SID);
            this.ProjectData.RemoveAt((int)e.Argument);

            this.bgwDeleteProject.ReportProgress(100);
        }

        private void BgwDeleteProject_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BgwDeleteProject_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btnDelete.Enabled = true;
            progressBar1.Visible = false;

            InitializeData();
        }


        #endregion

        #region form closed
        private void Form_FormClosed(Object sender, FormClosedEventArgs e)
        {
            if (sender is FormProjectInfo)
            {
                var form = (sender as FormProjectInfo);
                var item = openedForms.FirstOrDefault(x => x.Value == form);
                openedForms.Remove(item.Key);
            }
        }
        #endregion
    }
}
