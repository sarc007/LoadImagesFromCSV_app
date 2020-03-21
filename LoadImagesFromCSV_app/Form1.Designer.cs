namespace LoadImagesFromCSV_app
{
    partial class Form1
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
            this.src_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.dest_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtbox_SourceFolderSelection = new System.Windows.Forms.TextBox();
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.txtbox_DestinationSelectedFolder = new System.Windows.Forms.TextBox();
            this.btnSelectDestinationFolder = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btn_start_extracting_img_from_csv = new System.Windows.Forms.Button();
            this.listBox_csv = new System.Windows.Forms.ListBox();
            this.progressBarControl2 = new DevExpress.XtraEditors.ProgressBarControl();
            this.listBox_img = new System.Windows.Forms.ListBox();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(800, 549);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(792, 541);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtbox_SourceFolderSelection);
            this.splitContainer3.Panel1.Controls.Add(this.btnSelectSourceFolder);
            this.splitContainer3.Panel1.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtbox_DestinationSelectedFolder);
            this.splitContainer3.Panel2.Controls.Add(this.btnSelectDestinationFolder);
            this.splitContainer3.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Size = new System.Drawing.Size(792, 68);
            this.splitContainer3.SplitterDistance = 361;
            this.splitContainer3.TabIndex = 0;
            // 
            // txtbox_SourceFolderSelection
            // 
            this.txtbox_SourceFolderSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_SourceFolderSelection.Location = new System.Drawing.Point(2, 2);
            this.txtbox_SourceFolderSelection.Name = "txtbox_SourceFolderSelection";
            this.txtbox_SourceFolderSelection.Size = new System.Drawing.Size(357, 20);
            this.txtbox_SourceFolderSelection.TabIndex = 4;
            this.txtbox_SourceFolderSelection.Text = "c:\\test001";
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(2, 43);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(357, 23);
            this.btnSelectSourceFolder.TabIndex = 3;
            this.btnSelectSourceFolder.Text = "Select Source Folder";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.btnSelectSourceFolder_Click);
            // 
            // txtbox_DestinationSelectedFolder
            // 
            this.txtbox_DestinationSelectedFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_DestinationSelectedFolder.Enabled = false;
            this.txtbox_DestinationSelectedFolder.Location = new System.Drawing.Point(2, 2);
            this.txtbox_DestinationSelectedFolder.Name = "txtbox_DestinationSelectedFolder";
            this.txtbox_DestinationSelectedFolder.Size = new System.Drawing.Size(423, 20);
            this.txtbox_DestinationSelectedFolder.TabIndex = 2;
            this.txtbox_DestinationSelectedFolder.Text = "c:\\img_saved";
            // 
            // btnSelectDestinationFolder
            // 
            this.btnSelectDestinationFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSelectDestinationFolder.Enabled = false;
            this.btnSelectDestinationFolder.Location = new System.Drawing.Point(2, 43);
            this.btnSelectDestinationFolder.Name = "btnSelectDestinationFolder";
            this.btnSelectDestinationFolder.Size = new System.Drawing.Size(423, 23);
            this.btnSelectDestinationFolder.TabIndex = 1;
            this.btnSelectDestinationFolder.Text = "Select Destination Folder";
            this.btnSelectDestinationFolder.UseVisualStyleBackColor = true;
            this.btnSelectDestinationFolder.Click += new System.EventHandler(this.btnSelectDestinationFolder_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.progressBarControl2);
            this.splitContainer2.Panel2.Controls.Add(this.listBox_img);
            this.splitContainer2.Size = new System.Drawing.Size(792, 469);
            this.splitContainer2.SplitterDistance = 228;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btn_start_extracting_img_from_csv);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.listBox_csv);
            this.splitContainer4.Size = new System.Drawing.Size(792, 228);
            this.splitContainer4.SplitterDistance = 30;
            this.splitContainer4.TabIndex = 0;
            // 
            // btn_start_extracting_img_from_csv
            // 
            this.btn_start_extracting_img_from_csv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start_extracting_img_from_csv.Enabled = false;
            this.btn_start_extracting_img_from_csv.Location = new System.Drawing.Point(0, 0);
            this.btn_start_extracting_img_from_csv.Name = "btn_start_extracting_img_from_csv";
            this.btn_start_extracting_img_from_csv.Size = new System.Drawing.Size(792, 30);
            this.btn_start_extracting_img_from_csv.TabIndex = 0;
            this.btn_start_extracting_img_from_csv.Text = "Start Extracting Images From CSV";
            this.btn_start_extracting_img_from_csv.UseVisualStyleBackColor = true;
            this.btn_start_extracting_img_from_csv.Click += new System.EventHandler(this.btn_start_extracting_img_from_csv_Click);
            // 
            // listBox_csv
            // 
            this.listBox_csv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_csv.FormattingEnabled = true;
            this.listBox_csv.Location = new System.Drawing.Point(0, 0);
            this.listBox_csv.Name = "listBox_csv";
            this.listBox_csv.ScrollAlwaysVisible = true;
            this.listBox_csv.Size = new System.Drawing.Size(792, 194);
            this.listBox_csv.TabIndex = 0;
            // 
            // progressBarControl2
            // 
            this.progressBarControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarControl2.Location = new System.Drawing.Point(0, 173);
            this.progressBarControl2.Name = "progressBarControl2";
            this.progressBarControl2.Properties.ShowTitle = true;
            this.progressBarControl2.Properties.Step = 1;
            this.progressBarControl2.ShowProgressInTaskBar = true;
            this.progressBarControl2.Size = new System.Drawing.Size(792, 34);
            this.progressBarControl2.TabIndex = 1;
            // 
            // listBox_img
            // 
            this.listBox_img.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_img.FormattingEnabled = true;
            this.listBox_img.Location = new System.Drawing.Point(0, 0);
            this.listBox_img.Name = "listBox_img";
            this.listBox_img.ScrollAlwaysVisible = true;
            this.listBox_img.Size = new System.Drawing.Size(792, 173);
            this.listBox_img.TabIndex = 0;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 521);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.progressBarControl1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.progressBarControl1.Properties.FlowAnimationEnabled = true;
            this.progressBarControl1.Properties.ProgressPadding = new System.Windows.Forms.Padding(3);
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.progressBarControl1.Size = new System.Drawing.Size(800, 28);
            this.progressBarControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "MWS-Atlas Save Images From CSV Files";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog src_folder;
        private System.Windows.Forms.FolderBrowserDialog dest_folder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnSelectDestinationFolder;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btn_start_extracting_img_from_csv;
        private System.Windows.Forms.ListBox listBox_csv;
        private System.Windows.Forms.ListBox listBox_img;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.TextBox txtbox_SourceFolderSelection;
        private System.Windows.Forms.TextBox txtbox_DestinationSelectedFolder;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl2;
    }
}

