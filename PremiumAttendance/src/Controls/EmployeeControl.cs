using PremiumAttendance.Forms;
using PremiumAttendance.Forms.SidebarForms;
using PremiumAttendance.Forms.SubForms;
using PremiumAttendance.objects;
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

        /// <summary>
        /// Control that sees admin at <see cref="EmployeesForm"/>, references to <see cref="EmployeeAccount"/>
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="dashboardForm"></param>
        public EmployeeControl(Employee employee, DashBoardForm dashboardForm)
        {
            InitializeComponent();
            this.employee = employee;
            this.dashboardForm = dashboardForm;

            InitItems();
        }

        /// <summary>
        /// Init attributes
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

        /// <summary>
        /// Hover effect enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
        }

        /// <summary>
        /// Hover effect leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.currentColor;
        }

        /// <summary>
        /// References to <see cref="EmployeeAccount"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeControl_Click(object sender, EventArgs e)
        {
            EmployeeAccount form = new EmployeeAccount(employee, dashboardForm);
            this.dashboardForm.OpenChildFormOverChildForm(form);

            form.deleteEvent += HideControl;
        }

        /// <summary>
        /// Event that hides control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideControl(object sender, EventArgs e)
        {
            this.Visible = false;
        }

    }
}
