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

        /// <summary>
        /// Employee cell at <see cref="Forms.SidebarForms.AttendanceForm"/>. Displays employee name and surname
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="employeeName"></param>
        public AttendanceFormEmployeeControl(int width, int height, string employeeName)
        {
            InitializeComponent();
            this.width = width;
            this.height = height;
            this.employeeName = employeeName;

            InitItems();
        }

        /// <summary>
        /// Init attributes
        /// </summary>
        public void InitItems()
        {
            this.Size = new System.Drawing.Size(width, height);
            this.employeeNameLabel.Text = employeeName;
        }
    }
}
