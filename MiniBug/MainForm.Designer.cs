namespace MiniBug
{
    partial class MainForm
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
            this.GridIssues = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridTasks = new System.Windows.Forms.DataGridView();
            this.modernPieChart1 = new ModernUI.Charting.ModernPieChart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.IconNewIssue = new System.Windows.Forms.ToolStripButton();
            this.IconEditIssue = new System.Windows.Forms.ToolStripButton();
            this.IconDeleteIssue = new System.Windows.Forms.ToolStripButton();
            this.IconCloneIssue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.IconNewTask = new System.Windows.Forms.ToolStripButton();
            this.IconEditTask = new System.Windows.Forms.ToolStripButton();
            this.IconDeleteTask = new System.Windows.Forms.ToolStripButton();
            this.IconCloneTask = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.IconPieChart = new System.Windows.Forms.ToolStripButton();
            this.IconShowClosed = new System.Windows.Forms.ToolStripButton();
            this.IconConfigureColumns = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.configureColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRecentProjectsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMiniBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonPieClose = new System.Windows.Forms.Button();
            this.panelPie = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridIssues)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTasks)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridIssues
            // 
            this.GridIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridIssues.Location = new System.Drawing.Point(3, 4);
            this.GridIssues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridIssues.Name = "GridIssues";
            this.GridIssues.Size = new System.Drawing.Size(1021, 501);
            this.GridIssues.TabIndex = 0;
            this.GridIssues.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridIssues_CellDoubleClick);
            this.GridIssues.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridIssues_CellFormatting);
            this.GridIssues.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridIssues_CellPainting);
            this.GridIssues.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GridIssues_ColumnDisplayIndexChanged);
            this.GridIssues.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridIssues_ColumnHeaderMouseClick);
            this.GridIssues.SelectionChanged += new System.EventHandler(this.GridIssues_SelectionChanged);
            this.GridIssues.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridIssues_KeyDown);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(2, 77);
            this.TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1035, 539);
            this.TabControl.TabIndex = 2;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            this.TabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TabControl_KeyDown);
            this.TabControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabControl_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GridIssues);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1027, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Issues";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GridTasks);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1027, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridTasks
            // 
            this.GridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTasks.Location = new System.Drawing.Point(7, 8);
            this.GridTasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridTasks.Name = "GridTasks";
            this.GridTasks.Size = new System.Drawing.Size(905, 449);
            this.GridTasks.TabIndex = 0;
            this.GridTasks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTasks_CellDoubleClick);
            this.GridTasks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridTasks_CellFormatting);
            this.GridTasks.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridTasks_CellPainting);
            this.GridTasks.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GridTasks_ColumnDisplayIndexChanged);
            this.GridTasks.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridTasks_ColumnHeaderMouseClick);
            this.GridTasks.SelectionChanged += new System.EventHandler(this.GridTasks_SelectionChanged);
            this.GridTasks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridTasks_KeyDown);
            // 
            // modernPieChart1
            // 
            this.modernPieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modernPieChart1.BackColor = System.Drawing.Color.Gray;
            this.modernPieChart1.DisplayDoughnut = false;
            this.modernPieChart1.DoughnutWidth = 100F;
            this.modernPieChart1.DrawBorder = true;
            this.modernPieChart1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernPieChart1.ForeColor = System.Drawing.Color.White;
            this.modernPieChart1.GraphTitle = "";
            this.modernPieChart1.ItemTextTemplate = "Val: #VALUE - Perc: #PERCENTAGE - Text: #ITEMTEXT";
            this.modernPieChart1.Location = new System.Drawing.Point(3, 3);
            this.modernPieChart1.Name = "modernPieChart1";
            this.modernPieChart1.PecentageDecimals = 2;
            this.modernPieChart1.Radius = 200F;
            this.modernPieChart1.Size = new System.Drawing.Size(380, 280);
            this.modernPieChart1.TabIndex = 3;
            this.modernPieChart1.Text = "modernPieChart1";
            this.modernPieChart1.TextDisplayMode = ModernUI.Charting.ModernPieChart.TextDisplayTypes.Always;
            this.modernPieChart1.Thickness = 10F;
            this.modernPieChart1.TitleTextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.modernPieChart1.UseItemTextTemplate = false;
            this.modernPieChart1.UseStyledForeColor = false;
            this.modernPieChart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.modernPieChart1_MouseDown);
            this.modernPieChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.modernPieChart1_MouseMove);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconNewIssue,
            this.IconEditIssue,
            this.IconDeleteIssue,
            this.IconCloneIssue,
            this.toolStripSeparator2,
            this.IconNewTask,
            this.IconEditTask,
            this.IconDeleteTask,
            this.IconCloneTask,
            this.toolStripSeparator5,
            this.IconPieChart,
            this.IconShowClosed,
            this.IconConfigureColumns,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1037, 52);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // IconNewIssue
            // 
            this.IconNewIssue.Image = global::MiniBug.Properties.Resources.NewBug_32x32;
            this.IconNewIssue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconNewIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconNewIssue.Name = "IconNewIssue";
            this.IconNewIssue.Size = new System.Drawing.Size(36, 49);
            this.IconNewIssue.Text = "New";
            this.IconNewIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconNewIssue.ToolTipText = "New Issue";
            this.IconNewIssue.Click += new System.EventHandler(this.IconNewIssue_Click);
            // 
            // IconEditIssue
            // 
            this.IconEditIssue.Image = global::MiniBug.Properties.Resources.EditBug_32x32;
            this.IconEditIssue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconEditIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconEditIssue.Name = "IconEditIssue";
            this.IconEditIssue.Size = new System.Drawing.Size(36, 49);
            this.IconEditIssue.Text = "Edit";
            this.IconEditIssue.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.IconEditIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconEditIssue.ToolTipText = "Edit Selected Issue";
            this.IconEditIssue.Click += new System.EventHandler(this.IconEditIssue_Click);
            // 
            // IconDeleteIssue
            // 
            this.IconDeleteIssue.Image = global::MiniBug.Properties.Resources.DeleteBug_32x32;
            this.IconDeleteIssue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconDeleteIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconDeleteIssue.Name = "IconDeleteIssue";
            this.IconDeleteIssue.Size = new System.Drawing.Size(44, 49);
            this.IconDeleteIssue.Text = "Delete";
            this.IconDeleteIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconDeleteIssue.ToolTipText = "Delete Selected Issues";
            this.IconDeleteIssue.Click += new System.EventHandler(this.IconDeleteIssue_Click);
            // 
            // IconCloneIssue
            // 
            this.IconCloneIssue.Image = global::MiniBug.Properties.Resources.CloneBug_32x32;
            this.IconCloneIssue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconCloneIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconCloneIssue.Name = "IconCloneIssue";
            this.IconCloneIssue.Size = new System.Drawing.Size(41, 49);
            this.IconCloneIssue.Text = "Clone";
            this.IconCloneIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconCloneIssue.ToolTipText = "Clone Selected Issue";
            this.IconCloneIssue.Click += new System.EventHandler(this.IconCloneIssue_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // IconNewTask
            // 
            this.IconNewTask.Image = global::MiniBug.Properties.Resources.NewTask_32x32;
            this.IconNewTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconNewTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconNewTask.Name = "IconNewTask";
            this.IconNewTask.Size = new System.Drawing.Size(37, 49);
            this.IconNewTask.Text = "New";
            this.IconNewTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconNewTask.ToolTipText = "New Task";
            this.IconNewTask.Click += new System.EventHandler(this.IconNewTask_Click);
            // 
            // IconEditTask
            // 
            this.IconEditTask.Image = global::MiniBug.Properties.Resources.EditTask_32x32;
            this.IconEditTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconEditTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconEditTask.Name = "IconEditTask";
            this.IconEditTask.Size = new System.Drawing.Size(36, 49);
            this.IconEditTask.Text = "Edit";
            this.IconEditTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconEditTask.ToolTipText = "Edit Selected Task";
            this.IconEditTask.Click += new System.EventHandler(this.IconEditTask_Click);
            // 
            // IconDeleteTask
            // 
            this.IconDeleteTask.Image = global::MiniBug.Properties.Resources.DeleteTask_32x32;
            this.IconDeleteTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconDeleteTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconDeleteTask.Name = "IconDeleteTask";
            this.IconDeleteTask.Size = new System.Drawing.Size(44, 49);
            this.IconDeleteTask.Text = "Delete";
            this.IconDeleteTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconDeleteTask.ToolTipText = "Delete Selected Tasks";
            this.IconDeleteTask.Click += new System.EventHandler(this.IconDeleteTask_Click);
            // 
            // IconCloneTask
            // 
            this.IconCloneTask.Image = global::MiniBug.Properties.Resources.CloneTask_32x32;
            this.IconCloneTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconCloneTask.Name = "IconCloneTask";
            this.IconCloneTask.Size = new System.Drawing.Size(41, 49);
            this.IconCloneTask.Text = "Clone";
            this.IconCloneTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconCloneTask.ToolTipText = "Clone Selected Task";
            this.IconCloneTask.Click += new System.EventHandler(this.IconCloneTask_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 52);
            // 
            // IconPieChart
            // 
            this.IconPieChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconPieChart.Image = global::MiniBug.Properties.Resources.Chart_32x32;
            this.IconPieChart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconPieChart.Name = "IconPieChart";
            this.IconPieChart.Size = new System.Drawing.Size(36, 49);
            this.IconPieChart.Text = "Pie chart";
            this.IconPieChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconPieChart.ToolTipText = "Show or hide Pie chart";
            this.IconPieChart.Click += new System.EventHandler(this.IconPieChart_Click);
            // 
            // IconShowClosed
            // 
            this.IconShowClosed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconShowClosed.Image = global::MiniBug.Properties.Resources.Filter_32x32;
            this.IconShowClosed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconShowClosed.Name = "IconShowClosed";
            this.IconShowClosed.Size = new System.Drawing.Size(36, 49);
            this.IconShowClosed.Text = "Filter";
            this.IconShowClosed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconShowClosed.ToolTipText = "Filter closed and resolved";
            this.IconShowClosed.Click += new System.EventHandler(this.IconShowClosed_Click);
            // 
            // IconConfigureColumns
            // 
            this.IconConfigureColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconConfigureColumns.Image = global::MiniBug.Properties.Resources.ConfigureView_32x32;
            this.IconConfigureColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconConfigureColumns.Name = "IconConfigureColumns";
            this.IconConfigureColumns.Size = new System.Drawing.Size(36, 49);
            this.IconConfigureColumns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconConfigureColumns.ToolTipText = "Configure column settings";
            this.IconConfigureColumns.Click += new System.EventHandler(this.IconConfigureColumns_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 52);
            this.txtSearch.Text = "search";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.issuesToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1037, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.editProjectToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator3,
            this.configureColumnsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator4,
            this.recentProjectsToolStripMenuItem,
            this.clearRecentProjectsListToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 19);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Image = global::MiniBug.Properties.Resources.NewProject_32x32;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newProjectToolStripMenuItem.Text = "&New Project...";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Image = global::MiniBug.Properties.Resources.OpenProject_32x32;
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openProjectToolStripMenuItem.Text = "&Open Project...";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // editProjectToolStripMenuItem
            // 
            this.editProjectToolStripMenuItem.Name = "editProjectToolStripMenuItem";
            this.editProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.editProjectToolStripMenuItem.Text = "&Project Settings...";
            this.editProjectToolStripMenuItem.Click += new System.EventHandler(this.editProjectToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exportToolStripMenuItem.Text = "&Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
            // 
            // configureColumnsToolStripMenuItem
            // 
            this.configureColumnsToolStripMenuItem.Image = global::MiniBug.Properties.Resources.ConfigureView_32x32;
            this.configureColumnsToolStripMenuItem.Name = "configureColumnsToolStripMenuItem";
            this.configureColumnsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.configureColumnsToolStripMenuItem.Text = "Confi&gure Columns";
            this.configureColumnsToolStripMenuItem.Click += new System.EventHandler(this.configureColumnsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::MiniBug.Properties.Resources.Settings_32x32;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.settingsToolStripMenuItem.Text = "&Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(182, 6);
            // 
            // recentProjectsToolStripMenuItem
            // 
            this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
            this.recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.recentProjectsToolStripMenuItem.Text = "&Recent Projects";
            // 
            // clearRecentProjectsListToolStripMenuItem
            // 
            this.clearRecentProjectsListToolStripMenuItem.Image = global::MiniBug.Properties.Resources.Delete_32x32;
            this.clearRecentProjectsListToolStripMenuItem.Name = "clearRecentProjectsListToolStripMenuItem";
            this.clearRecentProjectsListToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.clearRecentProjectsListToolStripMenuItem.Text = "&Clear Recent Projects";
            this.clearRecentProjectsListToolStripMenuItem.Click += new System.EventHandler(this.clearRecentProjectsListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // issuesToolStripMenuItem
            // 
            this.issuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newIssueToolStripMenuItem,
            this.editIssueToolStripMenuItem,
            this.deleteIssueToolStripMenuItem,
            this.cloneIssueToolStripMenuItem});
            this.issuesToolStripMenuItem.Name = "issuesToolStripMenuItem";
            this.issuesToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.issuesToolStripMenuItem.Text = "&Issues";
            // 
            // newIssueToolStripMenuItem
            // 
            this.newIssueToolStripMenuItem.Image = global::MiniBug.Properties.Resources.NewBug_32x32;
            this.newIssueToolStripMenuItem.Name = "newIssueToolStripMenuItem";
            this.newIssueToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newIssueToolStripMenuItem.Text = "&New Issue...";
            this.newIssueToolStripMenuItem.Click += new System.EventHandler(this.newIssueToolStripMenuItem_Click);
            // 
            // editIssueToolStripMenuItem
            // 
            this.editIssueToolStripMenuItem.Image = global::MiniBug.Properties.Resources.EditBug_32x32;
            this.editIssueToolStripMenuItem.Name = "editIssueToolStripMenuItem";
            this.editIssueToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.editIssueToolStripMenuItem.Text = "&Edit Issue...";
            this.editIssueToolStripMenuItem.Click += new System.EventHandler(this.editIssueToolStripMenuItem_Click);
            // 
            // deleteIssueToolStripMenuItem
            // 
            this.deleteIssueToolStripMenuItem.Image = global::MiniBug.Properties.Resources.DeleteBug_32x32;
            this.deleteIssueToolStripMenuItem.Name = "deleteIssueToolStripMenuItem";
            this.deleteIssueToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteIssueToolStripMenuItem.Text = "&Delete Issue";
            this.deleteIssueToolStripMenuItem.Click += new System.EventHandler(this.deleteIssueToolStripMenuItem_Click);
            // 
            // cloneIssueToolStripMenuItem
            // 
            this.cloneIssueToolStripMenuItem.Image = global::MiniBug.Properties.Resources.CloneBug_32x32;
            this.cloneIssueToolStripMenuItem.Name = "cloneIssueToolStripMenuItem";
            this.cloneIssueToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cloneIssueToolStripMenuItem.Text = "&Clone Issue";
            this.cloneIssueToolStripMenuItem.Click += new System.EventHandler(this.cloneIssueToolStripMenuItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem,
            this.editTaskToolStripMenuItem,
            this.deleteTaskToolStripMenuItem,
            this.cloneTaskToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(46, 19);
            this.tasksToolStripMenuItem.Text = "&Tasks";
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Image = global::MiniBug.Properties.Resources.NewTask_32x32;
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newTaskToolStripMenuItem.Text = "&New Task...";
            this.newTaskToolStripMenuItem.Click += new System.EventHandler(this.newTaskToolStripMenuItem_Click);
            // 
            // editTaskToolStripMenuItem
            // 
            this.editTaskToolStripMenuItem.Image = global::MiniBug.Properties.Resources.EditTask_32x32;
            this.editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            this.editTaskToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.editTaskToolStripMenuItem.Text = "&Edit Task...";
            this.editTaskToolStripMenuItem.Click += new System.EventHandler(this.editTaskToolStripMenuItem_Click);
            // 
            // deleteTaskToolStripMenuItem
            // 
            this.deleteTaskToolStripMenuItem.Image = global::MiniBug.Properties.Resources.DeleteTask_32x32;
            this.deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            this.deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deleteTaskToolStripMenuItem.Text = "&Delete Task";
            this.deleteTaskToolStripMenuItem.Click += new System.EventHandler(this.deleteTaskToolStripMenuItem_Click);
            // 
            // cloneTaskToolStripMenuItem
            // 
            this.cloneTaskToolStripMenuItem.Image = global::MiniBug.Properties.Resources.CloneTask_32x32;
            this.cloneTaskToolStripMenuItem.Name = "cloneTaskToolStripMenuItem";
            this.cloneTaskToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cloneTaskToolStripMenuItem.Text = "&Clone Task";
            this.cloneTaskToolStripMenuItem.Click += new System.EventHandler(this.cloneTaskToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMiniBugToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutMiniBugToolStripMenuItem
            // 
            this.aboutMiniBugToolStripMenuItem.Image = global::MiniBug.Properties.Resources.About_32x32;
            this.aboutMiniBugToolStripMenuItem.Name = "aboutMiniBugToolStripMenuItem";
            this.aboutMiniBugToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.aboutMiniBugToolStripMenuItem.Text = "&About MiniBug";
            this.aboutMiniBugToolStripMenuItem.Click += new System.EventHandler(this.aboutMiniBugToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonPieClose
            // 
            this.buttonPieClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPieClose.BackColor = System.Drawing.Color.Gray;
            this.buttonPieClose.FlatAppearance.BorderSize = 0;
            this.buttonPieClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPieClose.ForeColor = System.Drawing.Color.White;
            this.buttonPieClose.Location = new System.Drawing.Point(340, 3);
            this.buttonPieClose.Name = "buttonPieClose";
            this.buttonPieClose.Size = new System.Drawing.Size(43, 33);
            this.buttonPieClose.TabIndex = 4;
            this.buttonPieClose.Text = "X";
            this.buttonPieClose.UseVisualStyleBackColor = false;
            this.buttonPieClose.Click += new System.EventHandler(this.buttonPieClose_Click);
            // 
            // panelPie
            // 
            this.panelPie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPie.Controls.Add(this.buttonPieClose);
            this.panelPie.Controls.Add(this.modernPieChart1);
            this.panelPie.Location = new System.Drawing.Point(538, 59);
            this.panelPie.Name = "panelPie";
            this.panelPie.Size = new System.Drawing.Size(386, 286);
            this.panelPie.TabIndex = 5;
            this.panelPie.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 620);
            this.Controls.Add(this.panelPie);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GridIssues)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTasks)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridIssues;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton IconNewIssue;
        private System.Windows.Forms.ToolStripButton IconEditIssue;
        private System.Windows.Forms.ToolStripButton IconDeleteIssue;
        private System.Windows.Forms.ToolStripButton IconCloneIssue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton IconNewTask;
        private System.Windows.Forms.ToolStripButton IconEditTask;
        private System.Windows.Forms.ToolStripButton IconDeleteTask;
        private System.Windows.Forms.DataGridView GridTasks;
        private System.Windows.Forms.ToolStripButton IconCloneTask;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMiniBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProjectToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton IconConfigureColumns;
        private System.Windows.Forms.ToolStripMenuItem clearRecentProjectsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureColumnsToolStripMenuItem;
        private ModernUI.Charting.ModernPieChart modernPieChart1;
        private System.Windows.Forms.ToolStripButton IconPieChart;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.Panel panelPie;
        private System.Windows.Forms.Button buttonPieClose;
        private System.Windows.Forms.ToolStripButton IconShowClosed;
    }
}

