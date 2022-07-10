// Pie chart by RickZeeland.

using ModernUI.Charting;
using System;
using System.Drawing;

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

            if (modernPieChart1.Visible)
            {
                ShowPieChart();
            }
        }

        /// <summary>
        /// Toggle Pie chart visibility on or off.
        /// </summary>
        private void IconPieChart_Click(object sender, EventArgs e)
        {
            if (modernPieChart1.Visible)
            {
                modernPieChart1.Visible = false;
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
            modernPieChart1.GraphTitle = Program.SoftwareProject.Issues.Count + " Issues";      // Total number of issues
            //modernPieChart1.Font = new Font(this.Font, FontStyle.Bold);
            //modernPieChart1.DisplayDoughnut = true;
            modernPieChart1.Items.Clear();
            modernPieChart1.ForeColor = Color.White;
            modernPieChart1.BackColor = Color.Gray;

            modernPieChart1.Items.Add(new PieChartItem(IssuesUnconfirmed, Color.LightGray, "Unconfirmed", $"Unconfirmed {IssuesUnconfirmed}", 0));
            modernPieChart1.Items.Add(new PieChartItem(IssuesConfirmed, Color.Goldenrod, "Confirmed", $"Confirmed {IssuesConfirmed}", 0));
            modernPieChart1.Items.Add(new PieChartItem(IssuesInProgress, Color.Blue, "In progress", $"In progress {IssuesInProgress}", 20));
            modernPieChart1.Items.Add(new PieChartItem(IssuesResolved, Color.ForestGreen, "Resolved", $"Resolved {IssuesResolved}", 0));
            modernPieChart1.Items.Add(new PieChartItem(IssuesClosed, Color.Gray, "Closed", $"Closed {IssuesClosed}", 0));

            modernPieChart1.ItemStyle.SurfaceAlphaTransparency = 0.75F;
            modernPieChart1.FocusedItemStyle.SurfaceAlphaTransparency = 0.75F;
            modernPieChart1.FocusedItemStyle.SurfaceBrightnessFactor = 0.3F;
            modernPieChart1.PieStyle.Thickness = 30;
            modernPieChart1.Radius = 140;
            modernPieChart1.Visible = true;
        }
    }
}