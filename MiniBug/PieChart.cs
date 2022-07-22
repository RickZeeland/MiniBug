// Pie chart by RickZeeland.

using ModernUI.Charting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniBug
{
    /// <summary>
    /// Pie chart with modified ModernUI.Charting.dll by Angelo Cresta:
    /// https://www.codeproject.com/Articles/5299801/A-Control-to-Display-Pie-and-Doughtnut-Charts-with
    /// It can be rotated using the mousewheel.
    /// </summary>
    public partial class MainForm
    {
        public int IssuesClosed { get; set; }

        public int IssuesInProgress { get; set; }

        public int IssuesResolved { get; set; }

        public int IssuesUnconfirmed { get; set; }

        public int IssuesConfirmed { get; set; }

        /// <summary>
        /// The (filtered) total issues.
        /// </summary>
        public int IssuesFilteredTotal { get; set; }

        /// <summary>
        /// Allow to drag the Pie chart.
        /// </summary>
        private Point MouseDownLocation;

        /// <summary>
        /// Increment or decrement status count for the Pie chart.
        /// </summary>
        /// <param name="issueStatus">The issue status</param>
        /// <param name="add">Amount to add, default 1</param>
        private void PiechartCountersAdd(IssueStatus issueStatus, int add = 1)
        {
            switch (issueStatus)
            {
                case IssueStatus.None:
                    break;
                case IssueStatus.Unconfirmed:
                    IssuesUnconfirmed += add;
                    break;
                case IssueStatus.Confirmed:
                    IssuesConfirmed += add;
                    break;
                case IssueStatus.InProgress:
                    IssuesInProgress += add;
                    break;
                case IssueStatus.Resolved:
                    IssuesResolved += add;
                    break;
                case IssueStatus.Closed:
                    IssuesClosed += add;
                    break;
                default:
                    break;
            }

            IssuesFilteredTotal += add;

            if (panelPie.Visible)
            {
                ShowPieChart();
            }
        }

        /// <summary>
        /// Toggle Pie chart visibility on or off.
        /// </summary>
        private void IconPieChart_Click(object sender, EventArgs e)
        {
            if (panelPie.Visible)
            {
                panelPie.Visible = false;
            }
            else
            {
                ShowPieChart();
            }
        }

        /// <summary>
        /// Show a pie chart with issue counts.
        /// </summary>
        private void ShowPieChart()
        {
            try
            {
                if (ShowClosedIssues)
                {
                    modernPieChart1.GraphTitle = Program.SoftwareProject.Issues.Count + " Issues";                              // Total number of issues
                }
                else
                {
                    modernPieChart1.GraphTitle = $"{IssuesFilteredTotal} Issues shown of {Program.SoftwareProject.Issues.Count}";    // Filtered and total number of issues
                }

                //modernPieChart1.Font = new Font(this.Font, FontStyle.Bold);
                //modernPieChart1.DisplayDoughnut = true;
                modernPieChart1.Items.Clear();
                modernPieChart1.ForeColor = Color.White;
                modernPieChart1.BackColor = Color.Gray;

                AddItem(IssuesUnconfirmed, Color.LightGray, "Unconfirmed");
                AddItem(IssuesConfirmed, Color.Goldenrod, "Confirmed");
                AddItem(IssuesInProgress, Color.Blue, "In progress", 20);
                AddItem(IssuesResolved, Color.ForestGreen, "Resolved");
                AddItem(IssuesClosed, Color.Gray, "Closed");

                modernPieChart1.ItemStyle.SurfaceAlphaTransparency = 0.75F;
                modernPieChart1.FocusedItemStyle.SurfaceAlphaTransparency = 0.75F;
                modernPieChart1.FocusedItemStyle.SurfaceBrightnessFactor = 0.3F;
                modernPieChart1.PieStyle.Thickness = 30;
                modernPieChart1.Radius = 140;
                panelPie.Visible = true;
            }
            catch
            {
            }
        }

        private void AddItem(int itemCount, Color color, string status, int offset = 0)
        {
            if (itemCount > 0)
            {
                modernPieChart1.Items.Add(new PieChartItem(itemCount, color, status, $"{status} {itemCount}", offset));
            }
        }

        /// <summary>
        /// Allow to drag the Pie chart.
        /// </summary>
        private void modernPieChart1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        /// <summary>
        /// Allow to drag the Pie chart.
        /// </summary>
        private void modernPieChart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelPie.Left = e.X + panelPie.Left - MouseDownLocation.X;
                panelPie.Top = e.Y + panelPie.Top - MouseDownLocation.Y;
            }
        }

        private void buttonPieClose_Click(object sender, EventArgs e)
        {
            panelPie.Visible = false;
        }
    }
}