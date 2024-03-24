using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance.Forms.SidebarForms
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
            InitItems();
        }

        public void InitItems()
        {

            TableLayoutPanel attendanceTableLayoutPanel = new TableLayoutPanel();
            int height = 50;
            int width = 100;
            attendanceTableLayoutPanel.RowCount = 30;
            attendanceTableLayoutPanel.ColumnCount = 30;

           
            
            attendanceTableLayoutPanel.Dock= DockStyle.None;
            attendanceTableLayoutPanel.AutoScroll = true;
            attendanceTableLayoutPanel.Location = new System.Drawing.Point(12, 143);
            attendanceTableLayoutPanel.Size = new System.Drawing.Size(940, 450);
            attendanceTableLayoutPanel.MaximumSize = new System.Drawing.Size(940, 450);
            
            //attendanceTableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            //attendanceTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowOnly;
           

            for (int i = 0; i < attendanceTableLayoutPanel.RowCount; i++)
            {
                attendanceTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, height));

                for (int j = 0; j < attendanceTableLayoutPanel.ColumnCount; j++)
                {
                    attendanceTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, width));

                    Button button = new Button();
                    button.Height = height;
                    button.Width = width;
                    button.Text = $"Button ({i + 1},{j + 1})";
                    attendanceTableLayoutPanel.Controls.Add(button, j, i);
                }
            }

            // Add TableLayoutPanel to the parent control (assuming attendanceCalendarFlowLayoutPanel is the parent)
            //this.attendanceCalendarFlowLayoutPanel.Controls.Add(tableLayoutPanel);
            this.Controls.Add(attendanceTableLayoutPanel);

        }
    }
}
