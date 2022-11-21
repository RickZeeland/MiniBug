namespace MiniBug
{
    partial class IssueForm
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
            this.components = new System.ComponentModel.Container();
            this.labelId = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDateCreatedTitle = new System.Windows.Forms.Label();
            this.lblDateModifiedTitle = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.txtTargetVersion = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblDateModified = new System.Windows.Forms.Label();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.panelTemp = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(12, 13);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(56, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Issue ID:";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(74, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblDateCreatedTitle
            // 
            this.lblDateCreatedTitle.Location = new System.Drawing.Point(145, 13);
            this.lblDateCreatedTitle.Name = "lblDateCreatedTitle";
            this.lblDateCreatedTitle.Size = new System.Drawing.Size(87, 13);
            this.lblDateCreatedTitle.TabIndex = 2;
            this.lblDateCreatedTitle.Text = "Date Created:";
            // 
            // lblDateModifiedTitle
            // 
            this.lblDateModifiedTitle.Location = new System.Drawing.Point(422, 13);
            this.lblDateModifiedTitle.Name = "lblDateModifiedTitle";
            this.lblDateModifiedTitle.Size = new System.Drawing.Size(104, 13);
            this.lblDateModifiedTitle.TabIndex = 4;
            this.lblDateModifiedTitle.Text = "Date Modified:";
            // 
            // labelSummary
            // 
            this.labelSummary.Location = new System.Drawing.Point(12, 44);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(73, 18);
            this.labelSummary.TabIndex = 6;
            this.labelSummary.Text = "&Summary:";
            // 
            // txtSummary
            // 
            this.txtSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSummary.Location = new System.Drawing.Point(91, 40);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(797, 22);
            this.txtSummary.TabIndex = 7;
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(12, 79);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 17);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "St&atus:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(91, 76);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(233, 21);
            this.cboStatus.TabIndex = 9;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // labelPriority
            // 
            this.labelPriority.Location = new System.Drawing.Point(351, 80);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(107, 17);
            this.labelPriority.TabIndex = 10;
            this.labelPriority.Text = "&Priority:";
            // 
            // cboPriority
            // 
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(457, 76);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(233, 21);
            this.cboPriority.TabIndex = 11;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(12, 114);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(73, 18);
            this.labelVersion.TabIndex = 12;
            this.labelVersion.Text = "&Version:";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(91, 111);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(233, 22);
            this.txtVersion.TabIndex = 13;
            // 
            // labelTarget
            // 
            this.labelTarget.Location = new System.Drawing.Point(351, 115);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(107, 25);
            this.labelTarget.TabIndex = 14;
            this.labelTarget.Text = "&Target Version:";
            // 
            // txtTargetVersion
            // 
            this.txtTargetVersion.Location = new System.Drawing.Point(457, 111);
            this.txtTargetVersion.Name = "txtTargetVersion";
            this.txtTargetVersion.Size = new System.Drawing.Size(233, 22);
            this.txtTargetVersion.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(0, 0);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(873, 288);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtDescription_MouseDoubleClick);
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(709, 11);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 18;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(790, 11);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 19;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.BackColor = System.Drawing.Color.LightCyan;
            this.lblDateCreated.Location = new System.Drawing.Point(235, 13);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(120, 13);
            this.lblDateCreated.TabIndex = 3;
            this.lblDateCreated.Text = "label10";
            // 
            // lblDateModified
            // 
            this.lblDateModified.BackColor = System.Drawing.Color.LightCyan;
            this.lblDateModified.Location = new System.Drawing.Point(534, 13);
            this.lblDateModified.Name = "lblDateModified";
            this.lblDateModified.Size = new System.Drawing.Size(120, 13);
            this.lblDateModified.TabIndex = 5;
            this.lblDateModified.Text = "label11";
            // 
            // buttonBrowseImage
            // 
            this.buttonBrowseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBrowseImage.Location = new System.Drawing.Point(600, 11);
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.Size = new System.Drawing.Size(44, 23);
            this.buttonBrowseImage.TabIndex = 20;
            this.buttonBrowseImage.Text = "...";
            this.toolTip1.SetToolTip(this.buttonBrowseImage, "Browse for image files");
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Click to zoom in/out");
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtImage
            // 
            this.txtImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtImage.Location = new System.Drawing.Point(136, 13);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(458, 22);
            this.txtImage.TabIndex = 22;
            this.txtImage.Text = "Test_Image.jpg";
            this.toolTip1.SetToolTip(this.txtImage, "You can also drag and drop an image on this form");
            // 
            // labelImage
            // 
            this.labelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelImage.Location = new System.Drawing.Point(3, 16);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(127, 21);
            this.labelImage.TabIndex = 23;
            this.labelImage.Text = "Attached image file:";
            this.toolTip1.SetToolTip(this.labelImage, "You can also drag and drop an image on this form");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(8, 21);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtDescription);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(873, 351);
            this.splitContainer1.SplitterDistance = 288;
            this.splitContainer1.TabIndex = 24;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.White;
            this.buttonCopy.Image = global::MiniBug.Properties.Resources.Clipboard_64x64;
            this.buttonCopy.Location = new System.Drawing.Point(733, 75);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(58, 58);
            this.buttonCopy.TabIndex = 27;
            this.toolTip1.SetToolTip(this.buttonCopy, "Copy to clipboard");
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.BackColor = System.Drawing.Color.White;
            this.buttonPdf.Image = global::MiniBug.Properties.Resources.pdf_64x64;
            this.buttonPdf.Location = new System.Drawing.Point(814, 75);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(58, 58);
            this.buttonPdf.TabIndex = 29;
            this.toolTip1.SetToolTip(this.buttonPdf, "Create PDF file");
            this.buttonPdf.UseVisualStyleBackColor = false;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.Controls.Add(this.btCancel);
            this.panelBottom.Controls.Add(this.btOk);
            this.panelBottom.Controls.Add(this.labelImage);
            this.panelBottom.Controls.Add(this.buttonBrowseImage);
            this.panelBottom.Controls.Add(this.txtImage);
            this.panelBottom.Location = new System.Drawing.Point(7, 526);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(887, 50);
            this.panelBottom.TabIndex = 25;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDescription.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxDescription.Controls.Add(this.splitContainer1);
            this.groupBoxDescription.Location = new System.Drawing.Point(7, 142);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(893, 378);
            this.groupBoxDescription.TabIndex = 26;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "&Description:";
            // 
            // panelTemp
            // 
            this.panelTemp.BackColor = System.Drawing.Color.Yellow;
            this.panelTemp.Location = new System.Drawing.Point(-7, 145);
            this.panelTemp.Name = "panelTemp";
            this.panelTemp.Size = new System.Drawing.Size(214, 375);
            this.panelTemp.TabIndex = 28;
            this.panelTemp.Visible = false;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.Goldenrod;
            this.panelStatus.Location = new System.Drawing.Point(91, 92);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(233, 10);
            this.panelStatus.TabIndex = 30;
            // 
            // IssueForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(900, 581);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.lblDateModified);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.txtTargetVersion);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.cboPriority);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.lblDateModifiedTitle);
            this.Controls.Add(this.lblDateCreatedTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.panelTemp);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.panelStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "IssueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IssueForm_FormClosed);
            this.Load += new System.EventHandler(this.IssueForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.IssueForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.IssueForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.groupBoxDescription.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDateCreatedTitle;
        private System.Windows.Forms.Label lblDateModifiedTitle;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.TextBox txtTargetVersion;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblDateModified;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Panel panelTemp;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Panel panelStatus;
    }
}