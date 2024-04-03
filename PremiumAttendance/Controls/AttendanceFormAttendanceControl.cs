using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance.Controls
{
    public partial class AttendanceFormAttendanceControl : UserControl
    {
        private int width;
        private int height;
        private List<string> attendanceList;
        public AttendanceFormAttendanceControl(int width, int height, params string[] attendance)
        {

            InitializeComponent();
            this.Size = new System.Drawing.Size(width, height);
            this.attendanceLabel.Size = new System.Drawing.Size(width, height);
            this.attendanceLabel.Text = String.Empty;
            attendanceList =new List<string>();
            if (attendance != null)
            {
                foreach (string a in attendance)
                {
                    if (a is string)
                    {
                        attendanceList.Add(a);
                    }
                }
            }
            
            InitItems();
        }

        public void InitItems()
        {
            

            if (attendanceList.Count == 0)
            {
                this.attendanceLabel.BackColor = this.attendanceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            }
            else
            {
                foreach (string attendance in attendanceList)
                {
                    this.attendanceLabel.Text += attendance + "\n";
                }
            }


        }
    }
}
