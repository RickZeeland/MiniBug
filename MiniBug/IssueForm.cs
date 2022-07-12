// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.

using PdfFileWriter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Text;
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

        public PdfDocument Document;
        private PdfFont DefaultFont;
        private Int32 PageNo;

        public IssueForm(OperationType operation, MiniBug.Issue issue = null)
        {
            InitializeComponent();
            this.Font = ApplicationSettings.AppFont;

            Operation = operation;
            
            if (Operation == OperationType.New)
            {
                // Create a new instance of the Issue class
                CurrentIssue = new Issue();
                txtImage.Text = string.Empty;
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
            this.Font = ApplicationSettings.AppFont;

            this.Icon = MiniBug.Properties.Resources.Minibug;
            //this.AcceptButton = btOk;
            //this.CancelButton = btCancel;
            //this.MinimumSize = new Size(685, 351);

            Point startPosition = Properties.Settings.Default.IssueFormStartPosition;
            Size formSize = Properties.Settings.Default.IssueFormSize;

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

            if (Font.SizeInPoints > 12)
            {
                // Make sure the bottom panel is visible using a temporary panel for scaling
                this.groupBoxDescription.Height = this.panelTemp.Height;
                this.panelBottom.Top = this.panelTemp.Bottom + 5;
            }

            if (string.IsNullOrEmpty(CurrentIssue.ImageFilename))
            {
                this.splitContainer1.SplitterDistance = this.splitContainer1.Height;        // No image, maximize description height
            }

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
                this.txtImage.Text = CurrentIssue.ImageFilename;
                this.txtImage.ForeColor = Color.Black;

                if (!string.IsNullOrEmpty(CurrentIssue.ImageFilename))
                {
                    // If there is an attached image, display it
                    string fullFilename = CurrentIssue.ImageFilename;

                    if (!File.Exists(fullFilename))
                    {
                        fullFilename = Path.Combine(Application.StartupPath, fullFilename);
                    }

                    if (File.Exists(fullFilename))
                    {
                        this.splitContainer1.SplitterDistance = this.splitContainer1.Height / 2;
                        this.pictureBox1.Image = Image.FromFile(fullFilename);
                        this.pictureBox1.Visible = true;
                    }
                    else
                    {
                        this.txtImage.ForeColor = Color.Red;            // Not found, display file name in red
                    }
                }

                lblID.Text = CurrentIssue.ID.ToString();
                cboStatus.SelectedValue = Convert.ToInt32(CurrentIssue.Status);
                cboPriority.SelectedValue = Convert.ToInt32(CurrentIssue.Priority);
            }

            //txtDescription.Font = ApplicationSettings.FormDescriptionFieldFont;
            lblID.Font = new Font(ApplicationSettings.AppFont, FontStyle.Bold);            // Bold

            // Resume the layout logic
            this.ResumeLayout();

            if (startPosition.X > 0)
            {
                this.Location = startPosition;
                this.Size = formSize;
            }
            else
            {
                this.CenterToScreen();
            }

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
            // Remember the last form position
            Properties.Settings.Default.IssueFormStartPosition = this.Location;
            Properties.Settings.Default.IssueFormSize = this.Size;

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
                CurrentIssue.ImageFilename = this.txtImage.Text;

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
            openFileDialog1.Filter = "Image files (*.jpg,*.png,*.bmp,*.gif)|*.jpg;*.png;*.bmp;*.gif";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Application.StartupPath;         // Open in current directory

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.splitContainer1.SplitterDistance = this.splitContainer1.Height / 2;                    // Make room in the splitcontainer
                string imageFilename = openFileDialog1.FileName;
                imageFilename = imageFilename.Replace(Application.StartupPath + @"\", string.Empty);        // Truncate file name if possible
                this.txtImage.Text = imageFilename;

                if (File.Exists(imageFilename))
                {
                    this.pictureBox1.Image = Image.FromFile(imageFilename);
                    this.pictureBox1.Visible = true;
                    this.txtImage.ForeColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// Zoom picture in splitcontainer panel2 on click.
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Size = this.splitContainer1.Panel2.ClientSize;

            if (this.pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        /// <summary>
        /// Copy text and attached image to the Windows Clipboard.
        /// Use "Paste special" in Office applications to paste the image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            try
            {
                string pageText = string.Join(Environment.NewLine, PageLines());

                if (!string.IsNullOrEmpty(this.txtImage.Text))
                {
                    DataObject dataObj = new DataObject();
                    dataObj.SetData(DataFormats.UnicodeText, pageText);
                    dataObj.SetData(DataFormats.Bitmap, true, Image.FromFile(this.txtImage.Text));
                    Clipboard.SetDataObject(dataObj);
                }
                else
                {
                    Clipboard.SetText(pageText);
                }
            }
            catch
            {
            }
        }

        private List<string> PageLines()
        {
            var pageLines = new List<string>(10);
            pageLines.Add($"MiniBug v2 issue ID {this.lblID.Text}");
            pageLines.Add(string.Empty);
            pageLines.Add($"Date Created:   {this.lblDateCreated.Text}");
            pageLines.Add($"Date Modified:  {this.lblDateModified.Text}");
            pageLines.Add($"Summary:        {this.txtSummary.Text}");
            pageLines.Add($"Status:         {this.cboStatus.Text}");
            pageLines.Add($"Priority:       {this.cboPriority.Text}");
            pageLines.Add($"Version:        {this.txtVersion.Text}");
            pageLines.Add($"Target Version: {this.txtTargetVersion.Text}");
            pageLines.Add($"Description:");

            var descLines = this.txtDescription.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            pageLines.AddRange(descLines);

            if (!string.IsNullOrEmpty(this.txtImage.Text))
            {
                pageLines.Add(string.Empty);
                pageLines.Add($"Image:          {this.txtImage.Text}");
            }

            return pageLines;
        }

        private void buttonPdf_Click(object sender, EventArgs e)
        {
            CreatePdfDocument();
        }

        /// <summary>
        /// PDF coordinate system origin is at the bottom left corner of the page.
        /// </summary>
        public void CreatePdfDocument()
        {
            // Create empty document
            using (PdfDocument Document = new PdfDocument(PaperType.A4, false, UnitOfMeasure.mm, $"MiniBug issue {lblID.Text}.pdf"))
            {
                // Add new page
                PdfPage Page = new PdfPage(Document);
                PdfContents Contents = new PdfContents(Page);
                PageNo = 1;
                int pageHeight = 295;           // A4 page heigtht

                // create font
                DefaultFont = PdfFont.CreatePdfFont(Document, "Courier New", FontStyle.Regular, true);
                int xPos = 30;
                int yPos = 10;
                int fontSize = 10;
                int LineHeight = fontSize / 2;
                var lines = PageLines();

                foreach (var line in lines)
                {
                    //Contents.ClipText
                    Contents.DrawText(DefaultFont, fontSize, xPos, pageHeight - yPos, line);
                    yPos += LineHeight;
                }

                //// print some test lines
                //for (int LineNo = 1; ; LineNo++)
                //{
                //    string text = string.Format("Page {0}, Line {1}", PageNo, LineNo);
                //    Contents.DrawText(DefaultFont, fontSize, xPos, pageHeight - yPos, text);
                //    yPos += LineHeight;

                //    if (yPos > 150)
                //    {
                //        break;
                //    }
                //}

                if (!string.IsNullOrEmpty(this.txtImage.Text) && File.Exists(this.txtImage.Text))
                {
                    // load image and calculate best fit
                    PdfImage pdfImage = new PdfImage(Document);
                    pdfImage.LoadImage(this.txtImage.Text);
                    var pdfImageSize = pdfImage.ImageSize(150, 150);
                    Contents.DrawImage(pdfImage, xPos, 10, pdfImageSize.Width, pdfImageSize.Height);
                }

                // create pdf file
                Document.CreateFile();
            }

            //// start default PDF reader and display the file
            //Process Proc = new Process();
            //Proc.StartInfo = new ProcessStartInfo("HelloPdfDocument.pdf") { UseShellExecute = true };
            //Proc.Start();
        }
    }
}
