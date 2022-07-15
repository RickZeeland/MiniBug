// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.

using System;
using System.IO;
using System.Windows.Forms;

namespace MiniBug
{
    /// <summary>
    /// Create a new project, or edit existing project settings.
    /// </summary>
    public partial class ProjectForm : Form
    {
        /// <summary>
        /// Gets the current operation.
        /// </summary>
        public MiniBug.OperationType Operation { get; private set; } = OperationType.None;

        /// <summary>
        /// Gets the name of the project.
        /// </summary>
        public string ProjectName { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the name of the project file.
        /// </summary>
        public string ProjectFilename { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the location of the project file, default application directory.
        /// </summary>
        public string ProjectLocation { get; private set; } = Application.StartupPath;

        /// <summary>
        /// Create a new project, or edit existing project settings.
        /// </summary>
        public ProjectForm(OperationType operation, string projectName = "", string projectFilename = "", string projectLocation = "")
        {
            InitializeComponent();
            this.Font = ApplicationSettings.AppFont;
            Operation = operation;

            if (Operation == OperationType.Edit)
            {
                // Edit existing project settings
                ProjectName = projectName;
                ProjectFilename = projectFilename;
                ProjectLocation = projectLocation;
            }
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            // Suspend the layout logic for the form, while the application is initializing
            this.SuspendLayout();
            txtLocation.Text = ProjectLocation;

            // Make initializations based on the type of operation
            if (Operation == OperationType.New)
            {
                this.Text = "New Project";
                lblFormTitle.Text = "Create a new project";
                btOk.Enabled = false;
            }
            else if (Operation == OperationType.Edit)
            {
                this.Text = "Edit Project";
                lblFormTitle.Text = "Edit the current project";

                // Populate the controls
                txtName.Text = ProjectName;
                txtFilename.Text = ProjectFilename;
            }

            // Resume the layout logic
            this.ResumeLayout();

            SetAccessibilityInformation();
        }

        /// <summary>
        /// Add accessibility data to form controls.
        /// </summary>
        private void SetAccessibilityInformation()
        {
            txtFilename.AccessibleDescription = "The name of the file containing the project";
            txtLocation.AccessibleDescription = "Folder where the project file will be saved";
            btBrowse.AccessibleDescription = "Browse for the folder where the project file will be saved";
        }

        /// <summary>
        /// Browse the location where the project will be saved, default is the application directory.
        /// </summary>
        private void btBrowse_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.SelectedPath = ProjectLocation;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = folderBrowserDialog1.SelectedPath;

                if (txtName.Text != string.Empty)
                {
                    btOk.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Close the form.
        /// </summary>
        private void btOk_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtName.Text)) && (!string.IsNullOrWhiteSpace(txtLocation.Text)))
            {
                ProjectName = txtName.Text;
                ProjectFilename = txtFilename.Text;
                ProjectLocation = txtLocation.Text;

                if (File.Exists(ProjectFilename))
                {
                    MessageBox.Show($"{ProjectFilename} already exists!\nPlease choose another name.", Program.myName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Program.IsLocked(ProjectFilename))
                    {
                        var result = MessageBox.Show($"Project is in use by another user!\n{ProjectFilename}\nContinue anyway?", Program.myName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if (result == DialogResult.Cancel)
                        {
                            this.DialogResult = DialogResult.Cancel;
                            this.Close();
                        }
                    }

                    Program.CreateLockFile(ProjectFilename);        // Create .lock file
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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
        /// Handle the TextChanged event for the project name textbox control.
        /// </summary>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtFilename.Text = $"minibug-{txtName.Text}.json";

                if (txtLocation.Text != string.Empty)
                {
                    btOk.Enabled = true;
                }                
            }
            else
            {
                txtFilename.Text = string.Empty;
                btOk.Enabled = false;
            }
        }
    }
}
