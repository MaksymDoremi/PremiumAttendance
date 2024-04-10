using PremiumAttendance.objects;
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

namespace PremiumAttendance.Forms.SubForms
{
    public partial class EmployeeAccount : Form
    {
        private Employee employee;
        private DashBoardForm dashboardForm;
        private BusinessLogicLayer bll;
        public EventHandler deleteEvent;

        /// <summary>
        /// Displays employee account information
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="dashboardForm"></param>
        public EmployeeAccount(Employee employee, DashBoardForm dashboardForm)
        {
            InitializeComponent();
            this.employee = employee;
            this.dashboardForm = dashboardForm;


            bll = new BusinessLogicLayer();

            InitItems();
        }

        /// <summary>
        /// Init <see cref="Employee"/> attributes
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

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens <see cref="CustomizeAccountForm"/> for current <see cref="Employee"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeAccountInfoBtn_Click(object sender, EventArgs e)
        {
            CustomizeAccountForm form = new CustomizeAccountForm(ref employee, true);

            Program.markRfidAttendance = false;
            this.dashboardForm.OpenChildFormOverChildForm(form);
        }

        /// <summary>
        /// Deletes current <see cref="Employee"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bll.DeleteEmployee(this.employee.Id);
                MessageBox.Show("Employee deleted successfully");

                //event that hides control from view
                if (deleteEvent != null)
                {
                    deleteEvent.Invoke(sender, e);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
