namespace Toolkit.WinForm
{
    partial class FormProjectList
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
            this.lbProject = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bgwDeleteProject = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbProject
            // 
            this.lbProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProject.FormattingEnabled = true;
            this.lbProject.ItemHeight = 12;
            this.lbProject.Location = new System.Drawing.Point(12, 21);
            this.lbProject.Name = "lbProject";
            this.lbProject.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbProject.Size = new System.Drawing.Size(448, 424);
            this.lbProject.TabIndex = 1;
            this.lbProject.DoubleClick += new System.EventHandler(this.LbProject_DoubleClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(13, 467);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "添加";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(385, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 458);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(448, 3);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // bgwDeleteProject
            // 
            this.bgwDeleteProject.WorkerReportsProgress = true;
            this.bgwDeleteProject.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwDeleteProject_DoWork);
            this.bgwDeleteProject.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwDeleteProject_ProgressChanged);
            this.bgwDeleteProject.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwDeleteProject_RunWorkerCompleted);
            // 
            // FormProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 500);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProjectList";
            this.ShowIcon = false;
            this.Text = "项目列表";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbProject;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bgwDeleteProject;
    }
}