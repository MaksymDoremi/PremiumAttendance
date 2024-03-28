using PremiumAttendance.Forms;
using PremiumAttendance.Forms.SidebarForms;
using PremiumAttendance.Forms.SubForms;
using PremiumAttendance.Objects;
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
    public partial class EmployeeControl : UserControl
    {
        private Employee employee;
        private DashBoardForm dashboardForm;
        private Color currentColor;
        private RFID rfidModule;
        public EmployeeControl(Employee employee, DashBoardForm dashboardForm, ref RFID rfidModule)
        {
            InitializeComponent();
            this.employee = employee;
            this.dashboardForm = dashboardForm;
            this.rfidModule = rfidModule;
            InitItems();
        }

        /// <summary>
        /// Initialize attributes
        /// </summary>
        public void InitItems()
        {
            this.currentColor = this.BackColor;
            this.employeeNameSurname.Text = employee.Name + " " + employee.Surname;
            this.employeeRole.Text = employee.Role;

            if (this.employee.Photo is null)
            {
                this.employeeImage.Image = global::PremiumAttendance.Properties.Resources.unknownPhoto;
            }
            else
            {
                this.employeeImage.Image = Program.ConvertByteArrayToImage(employee.Photo);
            }
        }

        private void EmployeeControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
        }

        private void EmployeeControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.currentColor;
        }

        private void EmployeeControl_Click(object sender, EventArgs e)
        {
            EmployeeAccount form = new EmployeeAccount(employee, dashboardForm, ref this.rfidModule);
            this.dashboardForm.OpenChildFormOverChildForm(form);

            form.deleteEvent += HideControl;
        }

        private void HideControl(object sender, EventArgs e)
        {
            this.Visible = false;
        }

    }
}
