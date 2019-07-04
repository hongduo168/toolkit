namespace Toolkit.WinForm
{
    partial class FormProjectInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNamespace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClearFind = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbKeywords = new System.Windows.Forms.TextBox();
            this.lbApi = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreateSelected = new System.Windows.Forms.Button();
            this.btnCreateAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateJSService = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称：";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(80, 16);
            this.tbName.Name = "tbName";
            this.tbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbName.Size = new System.Drawing.Size(167, 21);
            this.tbName.TabIndex = 1;
            // 
            // tbNamespace
            // 
            this.tbNamespace.Location = new System.Drawing.Point(331, 16);
            this.tbNamespace.Name = "tbNamespace";
            this.tbNamespace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNamespace.Size = new System.Drawing.Size(167, 21);
            this.tbNamespace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 20);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "命名空间：";
            // 
            // tbVersion
            // 
            this.tbVersion.Location = new System.Drawing.Point(80, 48);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVersion.Size = new System.Drawing.Size(165, 21);
            this.tbVersion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "版 本 号：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(14, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 481);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnCreate);
            this.tabPage1.Controls.Add(this.btnClearFind);
            this.tabPage1.Controls.Add(this.btnFind);
            this.tabPage1.Controls.Add(this.tbKeywords);
            this.tabPage1.Controls.Add(this.lbApi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(600, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "接口列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(452, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreate.Size = new System.Drawing.Size(68, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "新建接口";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnClearFind
            // 
            this.btnClearFind.Location = new System.Drawing.Point(324, 9);
            this.btnClearFind.Name = "btnClearFind";
            this.btnClearFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClearFind.Size = new System.Drawing.Size(80, 23);
            this.btnClearFind.TabIndex = 14;
            this.btnClearFind.Text = "清除查找";
            this.btnClearFind.UseVisualStyleBackColor = true;
            this.btnClearFind.Click += new System.EventHandler(this.BtnClearFind_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(212, 9);
            this.btnFind.Name = "btnFind";
            this.btnFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFind.Size = new System.Drawing.Size(106, 23);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "查找（下一个）";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // tbKeywords
            // 
            this.tbKeywords.Location = new System.Drawing.Point(6, 10);
            this.tbKeywords.Name = "tbKeywords";
            this.tbKeywords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbKeywords.Size = new System.Drawing.Size(200, 21);
            this.tbKeywords.TabIndex = 12;
            // 
            // lbApi
            // 
            this.lbApi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbApi.FormattingEnabled = true;
            this.lbApi.ItemHeight = 12;
            this.lbApi.Location = new System.Drawing.Point(6, 42);
            this.lbApi.Name = "lbApi";
            this.lbApi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbApi.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbApi.Size = new System.Drawing.Size(588, 400);
            this.lbApi.TabIndex = 3;
            this.lbApi.DoubleClick += new System.EventHandler(this.LbApi_DoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(641, 544);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCreateSelected
            // 
            this.btnCreateSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateSelected.Location = new System.Drawing.Point(641, 108);
            this.btnCreateSelected.Name = "btnCreateSelected";
            this.btnCreateSelected.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateSelected.Size = new System.Drawing.Size(95, 23);
            this.btnCreateSelected.TabIndex = 11;
            this.btnCreateSelected.Text = "生成选中接口";
            this.btnCreateSelected.UseVisualStyleBackColor = true;
            this.btnCreateSelected.Click += new System.EventHandler(this.BtnCreateSelected_Click);
            // 
            // btnCreateAll
            // 
            this.btnCreateAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAll.Location = new System.Drawing.Point(641, 146);
            this.btnCreateAll.Name = "btnCreateAll";
            this.btnCreateAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateAll.Size = new System.Drawing.Size(95, 23);
            this.btnCreateAll.TabIndex = 10;
            this.btnCreateAll.Text = "生成全部接口";
            this.btnCreateAll.UseVisualStyleBackColor = true;
            this.btnCreateAll.Click += new System.EventHandler(this.BtnCreateAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(526, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(68, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "删除接口";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnCreateJSService
            // 
            this.btnCreateJSService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateJSService.Location = new System.Drawing.Point(642, 187);
            this.btnCreateJSService.Name = "btnCreateJSService";
            this.btnCreateJSService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateJSService.Size = new System.Drawing.Size(95, 23);
            this.btnCreateJSService.TabIndex = 14;
            this.btnCreateJSService.Text = "生成JSService";
            this.btnCreateJSService.UseVisualStyleBackColor = true;
            this.btnCreateJSService.Click += new System.EventHandler(this.BtnCreateJSService_Click);
            // 
            // FormProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 579);
            this.Controls.Add(this.btnCreateJSService);
            this.Controls.Add(this.btnCreateSelected);
            this.Controls.Add(this.btnCreateAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNamespace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProjectInfo";
            this.ShowIcon = false;
            this.Text = "项目详情";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNamespace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnClearFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbKeywords;
        private System.Windows.Forms.ListBox lbApi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreateSelected;
        private System.Windows.Forms.Button btnCreateAll;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateJSService;
    }
}