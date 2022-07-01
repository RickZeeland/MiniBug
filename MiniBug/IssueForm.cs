// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MiniBug
{
    public partial class IssueForm : Form
    {
        /// <summary>
        /// The current operation.
        /// </summary>
        public OperationType Operation { get; private set; } = OperationType.None;

        /// <summary>
        /// The current issue (being created or edited).
        /// </summary>
        public Issue CurrentIssue { get; private set; } = null;

        /// <summary>
        /// List of status options.
        /// </summary>
        private List<ComboBoxItem> StatusOptionsList = new List<ComboBoxItem>();

        /// <summary>
        /// List of priority options.
        /// </summary>
        private List<ComboBoxItem> PriorityList = new List<ComboBoxItem>();

        public IssueForm(OperationType operation, MiniBug.Issue issue = null)
        {
            InitializeComponent();
            this.Font = ApplicationSettings.GridFont;

            Operation = operation;
            
            if (Operation == OperationType.New)
            {
                // Create a new instance of the Issue class
                CurrentIssue = new Issue();
            }
            else if ((Operation == OperationType.Edit) && (issue != null))
            {
                // Edit an existing issue
                CurrentIssue = issue;
            }

            // Populate the status list
            foreach (IssueStatus stat in Enum.GetValues(typeof(IssueStatus)))
            {
                if (stat != IssueStatus.None)
                {
                    StatusOptionsList.Add(new ComboBoxItem(Convert.ToInt32(stat), stat.ToDescription()));
                }
            }

            // Populate the priority list
            foreach (IssuePriority p in Enum.GetValues(typeof(IssuePriority)))
            {
                if (p != IssuePriority.None)
                {
                    PriorityList.Add(new ComboBoxItem(Convert.ToInt32(p), p.ToString()));
                }
            }
        }

        private void IssueForm_Load(object sender, EventArgs e)
        {
            // Suspend the layout logic for the form, while the application is initializing
            this.SuspendLayout();
            this.Font = ApplicationSettings.GridFont;

            this.Icon = MiniBug.Properties.Resources.Minibug;
            this.AcceptButton = btOk;
            this.CancelButton = btCancel;
            this.MinimumSize = new Size(685, 351);

            txtDescription.AcceptsReturn = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;

            // Initialize and populate the Status combobox
            cboStatus.AutoCompleteMode = AutoCompleteMode.None;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.DataSource = StatusOptionsList;
            cboStatus.ValueMember = "Value";
            cboStatus.DisplayMember = "Text";

            // Initialize and populate the Priority combobox
            cboPriority.AutoCompleteMode = AutoCompleteMode.None;
            cboPriority.DropDownStyle = ComboBoxStyle.DropDownList;            
            cboPriority.DataSource = PriorityList;
            cboPriority.ValueMember = "Value";
            cboPriority.DisplayMember = "Text";

            // Make initializations based on the type of operation
            if (Operation == OperationType.New)
            {
                this.Text = "Add New Issue";
                lblDateCreatedTitle.Visible = false;
                lblDateCreated.Visible = false;
                lblDateModifiedTitle.Visible = false;
                lblDateModified.Visible = false;

                cboStatus.SelectedIndex = 0;
                cboPriority.SelectedIndex = 0;

                lblID.Text = Program.SoftwareProject.IssueIdCounter.ToString();
            }
            else if (Operation == OperationType.Edit)
            {
                this.Text = "Edit Issue";

                // Populate the controls
                lblDateCreated.Text = CurrentIssue.DateCreated.ToString();
                lblDateModified.Text = CurrentIssue.DateModified.ToString();
                txtSummary.Text = CurrentIssue.Summary;
                txtVersion.Text = CurrentIssue.Version;
                txtTargetVersion.Text = CurrentIssue.TargetVersion;
                txtDescription.Text = CurrentIssue.Description;
                this.textBoxImage.Text = CurrentIssue.ImageFilename;

                if (string.IsNullOrEmpty(CurrentIssue.ImageFilename))
                {
                    this.splitContainer1.SplitterDistance = this.splitContainer1.Height;        // Maximize description height
                }
                else if (File.Exists(CurrentIssue.ImageFilename))
                {
                    // If there is an attached image, display it
                    this.splitContainer1.SplitterDistance = this.splitContainer1.Height / 2;
                    this.pictureBox1.Image = Image.FromFile(CurrentIssue.ImageFilename);
                    this.pictureBox1.Visible = true;
                }
                else
                {
                    this.textBoxImage.ForeColor = Color.Red;            // Not found, display file name in red
                }

                cboStatus.SelectedValue = Convert.ToInt32(CurrentIssue.Status);
                cboPriority.SelectedValue = Convert.ToInt32(CurrentIssue.Priority);

                lblID.Text = CurrentIssue.ID.ToString();
            }

            //txtDescription.Font = ApplicationSettings.FormDescriptionFieldFont;
            lblID.Font = new Font(ApplicationSettings.GridFont, FontStyle.Bold);            // Bold

            // Resume the layout logic
            this.ResumeLayout();

            SetAccessibilityInformation();
        }

        /// <summary>
        /// Add accessibility data to form controls.
        /// </summary>
        private void SetAccessibilityInformation()
        {
            lblID.AccessibleName = "Issue ID";
            lblID.AccessibleDescription = "Unique numerical code assigned to the issue";
            lblDateCreated.AccessibleName = "Date Created";
            lblDateCreated.AccessibleDescription = "Date/time when the issue was created";
            lblDateModified.AccessibleName = "Date Modified";
            lblDateModified.AccessibleDescription = "Date/time when the issue was last modified";
            txtSummary.AccessibleDescription = "Brief summary of the issue";
            cboStatus.AccessibleDescription = "Current status of the issue";
            cboPriority.AccessibleDescription = "Priority of an issue";
            txtVersion.AccessibleDescription = "Version where the issue was detected";
            txtTargetVersion.AccessibleDescription = "Version where the issue must be resolved";
            txtDescription.AccessibleDescription = "Extended description of the issue";
        }

        /// <summary>
        /// Close the form.
        /// </summary>
        private void btOk_Click(object sender, EventArgs e)
        {
            if (txtSummary.Text != string.Empty)
            {
                CurrentIssue.Summary = txtSummary.Text;
                CurrentIssue.Status = ((IssueStatus)((MiniBug.ComboBoxItem)cboStatus.SelectedItem).Value);
                CurrentIssue.Priority = ((IssuePriority)((MiniBug.ComboBoxItem)cboPriority.SelectedItem).Value);
                CurrentIssue.Version = txtVersion.Text;
                CurrentIssue.TargetVersion = txtTargetVersion.Text;
                CurrentIssue.Description = txtDescription.Text;

                if (Operation == OperationType.New)
                {
                    CurrentIssue.DateCreated = DateTime.Now;
                }

                CurrentIssue.DateModified = DateTime.Now;
                CurrentIssue.ImageFilename = this.textBoxImage.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Cancel this operation and close the form.
        /// </summary>
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Attach an image file to this issue.
        /// </summary>
        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Image file";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.FileName = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.splitContainer1.SplitterDistance = this.splitContainer1.Height / 2;
                string imageFilename = openFileDialog1.FileName;
                this.textBoxImage.Text = imageFilename;
                this.pictureBox1.Image = Image.FromFile(imageFilename);
                this.pictureBox1.Visible = true;
            }
        }

        /// <summary>
        /// Zoom picture on click.
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.SizeMode == PictureBoxSizeMode.Normal)
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
