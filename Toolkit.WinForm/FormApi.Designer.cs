namespace Toolkit.WinForm
{
    partial class FormApi
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
            this.tbActionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRoute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRequsetBody = new System.Windows.Forms.DataGridView();
            this.btnPasteRequest = new System.Windows.Forms.Button();
            this.btnDeleteRequestBody = new System.Windows.Forms.Button();
            this.btnAddRequestBody = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkInt = new System.Windows.Forms.CheckBox();
            this.chkBool = new System.Windows.Forms.CheckBox();
            this.chkPaging = new System.Windows.Forms.CheckBox();
            this.chkList = new System.Windows.Forms.CheckBox();
            this.dgvResponseBody = new System.Windows.Forms.DataGridView();
            this.btnPasteResponse = new System.Windows.Forms.Button();
            this.btnRemoveResponseBody = new System.Windows.Forms.Button();
            this.btnAddResponseBody = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbApiCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbActionMethod = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequsetBody)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponseBody)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "接口名称：";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(86, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(167, 21);
            this.tbName.TabIndex = 1;
            // 
            // tbActionName
            // 
            this.tbActionName.Location = new System.Drawing.Point(86, 44);
            this.tbActionName.Name = "tbActionName";
            this.tbActionName.Size = new System.Drawing.Size(167, 21);
            this.tbActionName.TabIndex = 3;
            this.tbActionName.Leave += new System.EventHandler(this.TbActionName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "方法名称：";
            // 
            // tbRoute
            // 
            this.tbRoute.Location = new System.Drawing.Point(339, 44);
            this.tbRoute.Multiline = true;
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.Size = new System.Drawing.Size(167, 21);
            this.tbRoute.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "方法路由：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 355);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRequsetBody);
            this.tabPage1.Controls.Add(this.btnPasteRequest);
            this.tabPage1.Controls.Add(this.btnDeleteRequestBody);
            this.tabPage1.Controls.Add(this.btnAddRequestBody);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "接收参数";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvRequsetBody
            // 
            this.dgvRequsetBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequsetBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequsetBody.Location = new System.Drawing.Point(8, 35);
            this.dgvRequsetBody.Name = "dgvRequsetBody";
            this.dgvRequsetBody.RowTemplate.Height = 23;
            this.dgvRequsetBody.Size = new System.Drawing.Size(754, 288);
            this.dgvRequsetBody.TabIndex = 18;
            // 
            // btnPasteRequest
            // 
            this.btnPasteRequest.Location = new System.Drawing.Point(61, 6);
            this.btnPasteRequest.Name = "btnPasteRequest";
            this.btnPasteRequest.Size = new System.Drawing.Size(47, 23);
            this.btnPasteRequest.TabIndex = 17;
            this.btnPasteRequest.Text = "粘贴";
            this.btnPasteRequest.UseVisualStyleBackColor = true;
            this.btnPasteRequest.Click += new System.EventHandler(this.BtnPasteRequest_Click);
            // 
            // btnDeleteRequestBody
            // 
            this.btnDeleteRequestBody.Location = new System.Drawing.Point(114, 6);
            this.btnDeleteRequestBody.Name = "btnDeleteRequestBody";
            this.btnDeleteRequestBody.Size = new System.Drawing.Size(47, 23);
            this.btnDeleteRequestBody.TabIndex = 16;
            this.btnDeleteRequestBody.Text = "删除";
            this.btnDeleteRequestBody.UseVisualStyleBackColor = true;
            this.btnDeleteRequestBody.Click += new System.EventHandler(this.BtnDeleteRequestBody_Click);
            // 
            // btnAddRequestBody
            // 
            this.btnAddRequestBody.Location = new System.Drawing.Point(8, 6);
            this.btnAddRequestBody.Name = "btnAddRequestBody";
            this.btnAddRequestBody.Size = new System.Drawing.Size(47, 23);
            this.btnAddRequestBody.TabIndex = 15;
            this.btnAddRequestBody.Text = "新增";
            this.btnAddRequestBody.UseVisualStyleBackColor = true;
            this.btnAddRequestBody.Click += new System.EventHandler(this.BtnAddRequestBody_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkInt);
            this.tabPage2.Controls.Add(this.chkBool);
            this.tabPage2.Controls.Add(this.chkPaging);
            this.tabPage2.Controls.Add(this.chkList);
            this.tabPage2.Controls.Add(this.dgvResponseBody);
            this.tabPage2.Controls.Add(this.btnPasteResponse);
            this.tabPage2.Controls.Add(this.btnRemoveResponseBody);
            this.tabPage2.Controls.Add(this.btnAddResponseBody);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "输出参数";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkInt
            // 
            this.chkInt.AccessibleName = "responseType";
            this.chkInt.AutoSize = true;
            this.chkInt.Location = new System.Drawing.Point(295, 10);
            this.chkInt.Name = "chkInt";
            this.chkInt.Size = new System.Drawing.Size(66, 16);
            this.chkInt.TabIndex = 20;
            this.chkInt.Text = "返回int";
            this.chkInt.UseVisualStyleBackColor = true;
            this.chkInt.CheckedChanged += new System.EventHandler(this.Checked_CheckedChanged);
            // 
            // chkBool
            // 
            this.chkBool.AccessibleName = "responseType";
            this.chkBool.AutoSize = true;
            this.chkBool.Location = new System.Drawing.Point(215, 10);
            this.chkBool.Name = "chkBool";
            this.chkBool.Size = new System.Drawing.Size(72, 16);
            this.chkBool.TabIndex = 19;
            this.chkBool.Text = "返回bool";
            this.chkBool.UseVisualStyleBackColor = true;
            this.chkBool.CheckedChanged += new System.EventHandler(this.Checked_CheckedChanged);
            // 
            // chkPaging
            // 
            this.chkPaging.AccessibleName = "responseType";
            this.chkPaging.AutoSize = true;
            this.chkPaging.Location = new System.Drawing.Point(367, 10);
            this.chkPaging.Name = "chkPaging";
            this.chkPaging.Size = new System.Drawing.Size(48, 16);
            this.chkPaging.TabIndex = 18;
            this.chkPaging.Text = "分页";
            this.chkPaging.UseVisualStyleBackColor = true;
            this.chkPaging.CheckedChanged += new System.EventHandler(this.Checked_CheckedChanged);
            // 
            // chkList
            // 
            this.chkList.AccessibleName = "responseType";
            this.chkList.AutoSize = true;
            this.chkList.Location = new System.Drawing.Point(421, 10);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(48, 16);
            this.chkList.TabIndex = 17;
            this.chkList.Text = "复数";
            this.chkList.UseVisualStyleBackColor = true;
            this.chkList.CheckedChanged += new System.EventHandler(this.Checked_CheckedChanged);
            // 
            // dgvResponseBody
            // 
            this.dgvResponseBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResponseBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponseBody.Location = new System.Drawing.Point(8, 35);
            this.dgvResponseBody.Name = "dgvResponseBody";
            this.dgvResponseBody.RowTemplate.Height = 23;
            this.dgvResponseBody.Size = new System.Drawing.Size(754, 317);
            this.dgvResponseBody.TabIndex = 16;
            // 
            // btnPasteResponse
            // 
            this.btnPasteResponse.Location = new System.Drawing.Point(61, 6);
            this.btnPasteResponse.Name = "btnPasteResponse";
            this.btnPasteResponse.Size = new System.Drawing.Size(47, 23);
            this.btnPasteResponse.TabIndex = 15;
            this.btnPasteResponse.Text = "粘贴";
            this.btnPasteResponse.UseVisualStyleBackColor = true;
            this.btnPasteResponse.Click += new System.EventHandler(this.btnPasteResponse_Click);
            // 
            // btnRemoveResponseBody
            // 
            this.btnRemoveResponseBody.Location = new System.Drawing.Point(114, 6);
            this.btnRemoveResponseBody.Name = "btnRemoveResponseBody";
            this.btnRemoveResponseBody.Size = new System.Drawing.Size(47, 23);
            this.btnRemoveResponseBody.TabIndex = 14;
            this.btnRemoveResponseBody.Text = "删除";
            this.btnRemoveResponseBody.UseVisualStyleBackColor = true;
            this.btnRemoveResponseBody.Click += new System.EventHandler(this.BtnRemoveResponseBody_Click);
            // 
            // btnAddResponseBody
            // 
            this.btnAddResponseBody.Location = new System.Drawing.Point(8, 6);
            this.btnAddResponseBody.Name = "btnAddResponseBody";
            this.btnAddResponseBody.Size = new System.Drawing.Size(47, 23);
            this.btnAddResponseBody.TabIndex = 13;
            this.btnAddResponseBody.Text = "新增";
            this.btnAddResponseBody.UseVisualStyleBackColor = true;
            this.btnAddResponseBody.Click += new System.EventHandler(this.BtnAddResponseBody_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(669, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tbApiCode
            // 
            this.tbApiCode.Location = new System.Drawing.Point(339, 12);
            this.tbApiCode.Name = "tbApiCode";
            this.tbApiCode.Size = new System.Drawing.Size(167, 21);
            this.tbApiCode.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "接口标识：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "访问方式：";
            // 
            // tbActionMethod
            // 
            this.tbActionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbActionMethod.FormattingEnabled = true;
            this.tbActionMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.tbActionMethod.Location = new System.Drawing.Point(612, 12);
            this.tbActionMethod.Name = "tbActionMethod";
            this.tbActionMethod.Size = new System.Drawing.Size(121, 20);
            this.tbActionMethod.TabIndex = 25;
            // 
            // FormApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.tbActionMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbApiCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbRoute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbActionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormApi";
            this.ShowIcon = false;
            this.Text = "接口参数";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequsetBody)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponseBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbActionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPasteRequest;
        private System.Windows.Forms.Button btnDeleteRequestBody;
        private System.Windows.Forms.Button btnAddRequestBody;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPasteResponse;
        private System.Windows.Forms.Button btnRemoveResponseBody;
        private System.Windows.Forms.Button btnAddResponseBody;
        private System.Windows.Forms.DataGridView dgvRequsetBody;
        private System.Windows.Forms.DataGridView dgvResponseBody;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkInt;
        private System.Windows.Forms.CheckBox chkBool;
        private System.Windows.Forms.CheckBox chkPaging;
        private System.Windows.Forms.CheckBox chkList;
        private System.Windows.Forms.TextBox tbApiCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tbActionMethod;
    }
}