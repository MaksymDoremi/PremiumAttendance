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

namespace PremiumAttendance.Forms.SubForms
{
    public partial class EmployeeAccount : Form
    {
        private Employee employee;
        private DashBoardForm dashboardForm;
        public EmployeeAccount(Employee employee, DashBoardForm dashboardForm)
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
            //LOAD ROLE
            this.actualRoleFromDB.Text = employee.Role;

            //LOAD NAME
            this.actualNameFromDB.Text = employee.Name;

            //LOAD SURNAME
            this.actualSurnameFromDB.Text = employee.Surname;

            //LOAD PHOTO
            if (employee.Photo is null)
            {
                this.bigAvatarPicture.Visible = false;
            }
            else
            {
                this.bigAvatarPicture.Visible = true;
                this.bigAvatarPicture.Image = Program.ConvertByteArrayToImage(employee.Photo);
            }


            //LOAD EMAIL
            this.actualEmailFromDB.Text = employee.Email;

            //LOAD PHONE
            this.actualPhoneFromDB.Text = employee.Phone;
        }   

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeAccountInfoBtn_Click(object sender, EventArgs e)
        {
            CustomizeAccountForm form = new CustomizeAccountForm(ref employee, true);
            this.dashboardForm.OpenChildFormOverChildForm(form);
        }
    }
}
