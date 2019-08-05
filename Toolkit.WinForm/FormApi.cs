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
    public partial class FormApi : Form
    {


        public ProjectInfo ProjectData { get; set; }


        public ApiInterfaceInfo ApiData { get; set; }


        public Form openerForm;

        public FormApi(ProjectInfo project, Form opener, ApiInterfaceInfo apiInterface = null)
        {
            InitializeComponent();
            this.ProjectData = project;
            this.openerForm = opener;

            if (apiInterface != null)
            {
                this.ApiData = apiInterface;
            }

            this.BindData();

            this.BindRequestBody();

            this.BindResponseBody();

        }

        public void BindData()
        {

            if (this.ApiData != null && this.ApiData.IsResultPaging)
            {
                this.chkPaging.Checked = true;
            }
            else
            {
                this.chkPaging.Checked = false;
            }


            if (this.ApiData == null)
            {
                this.ApiData = new ApiInterfaceInfo();

                this.ApiData.RequestBodys = new List<RequestBodyInfo>();
                this.ApiData.ResponseBodys = new List<ResponseBodyInfo>();

                this.ApiData.RequestBodys.Add(new RequestBodyInfo());
                this.ApiData.ResponseBodys.Add(new ResponseBodyInfo());
                this.chkBool.Checked = false;
                this.chkInt.Checked = false;
                this.chkList.Checked = false;
                this.tbActionMethod.SelectedIndex = 0;
            }
            else
            {
                this.tbName.Text = this.ApiData.ApiName;
                this.chkLogin.Checked = this.ApiData.IsAuthorize;
                this.tbApiCode.Text = this.ApiData.ApiCode;
                this.tbActionName.Text = this.ApiData.ActionName;
                if (string.IsNullOrEmpty(this.ApiData.ActionMethod))
                {
                    this.tbActionMethod.SelectedIndex = 0;
                }
                else
                {
                    this.tbActionMethod.SelectedItem = this.ApiData.ActionMethod;
                }
                this.tbRoute.Text = this.ApiData.ActionRoute;

                this.chkBool.Checked = this.ApiData.IsResultBool;
                this.chkInt.Checked = this.ApiData.IsResultInt;
                this.chkList.Checked = this.ApiData.IsList;
                this.chkPaging.Checked = this.ApiData.IsResultPaging;
            }
        }


        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region member

        private void BindRequestBody()
        {
            if (this.ApiData.RequestBodys != null && this.ApiData.RequestBodys.Count > 0)
            {
                this.dgvRequsetBody.DataSource = null;
                this.dgvRequsetBody.DataSource = this.ApiData.RequestBodys;
                if (this.dgvRequsetBody.Columns.Contains("SID"))
                    this.dgvRequsetBody.Columns["SID"].Visible = false;
                if (this.dgvRequsetBody.Columns.Contains("RelationSID"))
                    this.dgvRequsetBody.Columns["RelationSID"].Visible = false;
            }
        }

        private void BindResponseBody()
        {
            if (this.ApiData.ResponseBodys != null && this.ApiData.ResponseBodys.Count > 0)
            {
                this.dgvResponseBody.DataSource = null;
                this.dgvResponseBody.DataSource = this.ApiData.ResponseBodys;
                if (this.dgvResponseBody.Columns.Contains("SID"))
                    this.dgvResponseBody.Columns["SID"].Visible = false;
                if (this.dgvResponseBody.Columns.Contains("RelationSID"))
                    this.dgvResponseBody.Columns["RelationSID"].Visible = false;
            }
        }

        #endregion

        private void BtnAddRequestBody_Click(object sender, EventArgs e)
        {
            if (this.ApiData.RequestBodys == null) this.ApiData.RequestBodys = new List<RequestBodyInfo>();

            this.ApiData.RequestBodys.Add(new RequestBodyInfo());

            this.BindRequestBody();
        }

        private void BtnPasteRequest_Click(object sender, EventArgs e)
        {
            string pasteText = Clipboard.GetText();
            if (string.IsNullOrEmpty(pasteText))
            {
                return;
            }

            string[] lines = pasteText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            // if (MessageBox.Show(pasteText, "确认粘贴内容", MessageBoxButtons.OKCancel) == DialogResult.OK)
            // {
            foreach (var line in lines)
            {
                var arr = line.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                if (arr.Count() != 6)
                {
                    continue;
                }

                this.ApiData.RequestBodys.Add(new RequestBodyInfo()
                {
                    FieldName = arr[0],
                    FieldCode = arr[1],
                    DataType = arr[2],
                    DataLength = Convert.ToInt32(arr[3]),
                    IsAllowEmpty = arr[4].ToLower() == "true",
                    IsVaild = arr[5].ToLower() == "true"
                });

            }

            this.BindRequestBody();
            //  }

        }

        private void btnPasteResponse_Click(object sender, EventArgs e)
        {
            string pasteText = Clipboard.GetText();
            if (string.IsNullOrEmpty(pasteText))
            {
                return;
            }

            string[] lines = pasteText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var arr = line.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                if (arr.Count() != 3)
                {
                    continue;
                }

                this.ApiData.ResponseBodys.Add(new ResponseBodyInfo()
                {
                    FieldName = arr[0],
                    FieldCode = arr[1],
                    DataType = arr[2]
                });

            }

            this.BindResponseBody();
        }

        private void BtnDeleteRequestBody_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvRequsetBody.SelectedRows;
            if (selectedRows.Count <= 0 || this.ApiData.RequestBodys.Count == 0)
            {
                return;
            }
            RequestBodyInfo req = this.ApiData.RequestBodys.ElementAt(selectedRows[0].Index);
            DataProvider.Instance().DeleteRequestBody(req);

            this.ApiData.RequestBodys.RemoveAt(selectedRows[0].Index);
            this.BindRequestBody();
        }

        private void BtnAddResponseBody_Click(object sender, EventArgs e)
        {
            if (this.ApiData.ResponseBodys == null) this.ApiData.ResponseBodys = new List<ResponseBodyInfo>();

            this.ApiData.ResponseBodys.Add(new ResponseBodyInfo());
            this.BindResponseBody();
        }


        private void BtnRemoveResponseBody_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvResponseBody.SelectedRows;
            if (selectedRows.Count <= 0)
            {
                return;
            }

            ResponseBodyInfo req = this.ApiData.ResponseBodys.ElementAt(selectedRows[0].Index);
            DataProvider.Instance().DeleteResponseBody(req);

            this.ApiData.ResponseBodys.RemoveAt(selectedRows[0].Index);
            this.BindResponseBody();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            this.ApiData.ApiName = tbName.Text.Trim();
            this.ApiData.IsAuthorize = chkLogin.Checked;
            this.ApiData.ApiCode = tbApiCode.Text.Trim();
            this.ApiData.ActionName = tbActionName.Text.Trim();
            this.ApiData.ActionMethod = tbActionMethod.Text.Trim();
            this.ApiData.ActionRoute = tbRoute.Text.Trim();

            this.ApiData.IsResultBool = chkBool.Checked;
            this.ApiData.IsResultInt = chkInt.Checked;
            this.ApiData.IsResultPaging = chkPaging.Checked;
            this.ApiData.IsList = chkList.Checked;

            //处理null值
            this.ApiData.LastDateTime = DateTime.Now;
            if (this.ApiData.ApiName == null) this.ApiData.ApiName = string.Empty;
            if (this.ApiData.ApiCode == null) this.ApiData.ApiCode = string.Empty;
            if (this.ApiData.ActionName == null) this.ApiData.ActionName = string.Empty;
            if (this.ApiData.ActionMethod == null) this.ApiData.ActionMethod = string.Empty;
            if (this.ApiData.ActionRoute == null) this.ApiData.ActionRoute = string.Empty;

            if (string.IsNullOrWhiteSpace(this.ApiData.SID))
            {
                this.ApiData.ProjectSID = this.ProjectData.SID;

                //更新数据库
                DataProvider.Instance().InsertApi(this.ApiData);
            }
            else
            {
                this.ApiData.LastDateTime = DateTime.Now;
                DataProvider.Instance().SaveApi(this.ApiData);
            }
            this.ApiData.RequestBodys = (List<RequestBodyInfo>)this.dgvRequsetBody.DataSource;
            this.ApiData.ResponseBodys = (List<ResponseBodyInfo>)this.dgvResponseBody.DataSource;
            if (this.ApiData.RequestBodys != null)
            {
                foreach (var item in this.ApiData.RequestBodys)
                {
                    if (string.IsNullOrEmpty(item.FieldCode) || string.IsNullOrEmpty(item.DataType)) continue;

                    if (item.FieldName == null) item.FieldName = string.Empty;
                    if (item.FieldCode == null) item.FieldCode = string.Empty;
                    if (item.DataType == null) item.DataType = string.Empty;
                    if (string.IsNullOrWhiteSpace(item.SID))
                    {
                        item.RelationSID = this.ApiData.SID;
                        DataProvider.Instance().InsertRequestBody(item);
                    }
                    else
                    {
                        DataProvider.Instance().SaveRequestBody(item);
                    }
                }
            }
            if (this.ApiData.ResponseBodys != null)
            {
                foreach (var item in this.ApiData.ResponseBodys)
                {
                    if (string.IsNullOrEmpty(item.FieldCode) || string.IsNullOrEmpty(item.DataType)) continue;

                    if (item.FieldName == null) item.FieldName = string.Empty;
                    if (item.FieldCode == null) item.FieldCode = string.Empty;
                    if (item.DataType == null) item.DataType = string.Empty;
                    if (string.IsNullOrWhiteSpace(item.SID))
                    {
                        item.RelationSID = this.ApiData.SID;
                        DataProvider.Instance().InsertResponseBody(item);
                    }
                    else
                    {
                        DataProvider.Instance().SaveResponseBody(item);
                    }
                }
            }

            if (this.ProjectData.SID == string.Empty)
            {
                this.ProjectData.ApiInterfaces.Add(this.ApiData);
            }

            if (openerForm is FormProjectInfo)
            {
                (openerForm as FormProjectInfo).LoadData(this.ProjectData.SID);
            }
            btnSave.Enabled = true;
        }

        private void Checked_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                var control = (sender as CheckBox);
                if (control.Checked)
                {
                    foreach (var item in tabPage2.Controls)
                    {
                        if (item is CheckBox)
                        {
                            var chk = (item as CheckBox);
                            if (chk.AccessibleName == control.AccessibleName)
                            {
                                if (chk != sender) chk.Checked = false;
                            }
                        }
                    }
                }
            }
        }

        private void TbActionName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbRoute.Text))
            {
                this.tbRoute.Text = this.tbActionName.Text.ToLower();
            }
        }
    }
}
