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

namespace PremiumAttendance.Forms.SidebarForms
{
    public partial class MyAccountForm : Form
    {
        private Employee currentUser;
        private DashBoardForm dashboardForm;
        private BusinessLogicLayer bll;

        public EventHandler updateChangesEventHandler;

        public MyAccountForm(DashBoardForm dashboardForm, ref Employee currentUser)
        {
            InitializeComponent();
            bll = new BusinessLogicLayer();

            this.currentUser = currentUser;
            this.dashboardForm = dashboardForm;
            InitItems();
        }

        /// <summary>
        /// Init user attributes
        /// </summary>
        private void InitItems()
        {

            //LOAD ROLE
            this.actualRoleFromDB.Text = currentUser.Role;

            //LOAD NAME
            this.actualNameFromDB.Text = currentUser.Name;

            //LOAD SURNAME
            this.actualSurnameFromDB.Text = currentUser.Surname;

            //LOAD PHOTO
            if (currentUser.Photo is null)
            {
                this.bigAvatarPicture.Visible = false;
            }
            else
            {
                this.bigAvatarPicture.Visible = true;
                this.bigAvatarPicture.Image = Program.ConvertByteArrayToImage(currentUser.Photo);
            }


            //LOAD EMAIL
            this.actualEmailFromDB.Text = currentUser.Email;

            //LOAD PHONE
            this.actualPhoneFromDB.Text = currentUser.Phone;

        }

        /// <summary>
        /// Event that updates current attributes and invokes even to the <see cref="PremiumAttendance.Forms.DashBoardForm"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InitItemsEvent(object sender, EventArgs e)
        {
            InitItems();
            if (updateChangesEventHandler != null)
            {
                updateChangesEventHandler.Invoke(this, e);
            }

        }

        /// <summary>
        /// Opens <see cref="PremiumAttendance.Forms.SubForms.CustomizeAccountForm"/> for account customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeAccountInfoBtn_Click(object sender, EventArgs e)
        {
            CustomizeAccountForm form = new CustomizeAccountForm(ref currentUser);
            form.submitChangeEventHandler += InitItemsEvent;

            this.dashboardForm.OpenChildFormOverChildForm(form);
        }

        /// <summary>
        /// Opens <see cref="PremiumAttendance.Forms.SubForms.ChangePasswordForm"/> to change password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(currentUser.Id);
            this.dashboardForm.OpenChildFormOverChildForm(form);
        }
    }
}
