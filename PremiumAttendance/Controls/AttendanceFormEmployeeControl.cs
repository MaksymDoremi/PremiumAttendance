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
    public partial class AttendanceFormEmployeeControl : UserControl
    {
        private int width;
        private int height;
        private string employeeName;
        public AttendanceFormEmployeeControl(int width, int height, string employeeName)
        {
            InitializeComponent();
            this.width = width;
            this.height = height;
            this.employeeName = employeeName;

            InitItems();
        }

        public void InitItems()
        {
            this.Size = new System.Drawing.Size(width, height);
            this.employeeNameLabel.Text = employeeName;
        }
    }
}
