using PremiumAttendance.Forms.SidebarForms;
using PremiumAttendance.Objects;
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

namespace PremiumAttendance.Forms
{
    public partial class DashBoardForm : Form
    {

        private Employee currentUser;
        private Button currentBtn;

        private Form currentChildForm;

        private LoginForm loginForm;

        private BusinessLogicLayer bll;

        private Thread rfidThread;
        public DashBoardForm(Form loginForm, ref Employee currentUser, ref Thread rfidThread)
        {
            InitializeComponent();

            //load home page


            this.currentUser = currentUser;
            this.loginForm = (LoginForm)loginForm;
            this.rfidThread = rfidThread;
            InitItems();
            this.timer.Start();
        }

        /// <summary>
        /// Init dashboard buttons accroding to Administrator and Employee role
        /// </summary>
        private void InitItems()
        {
            List<Button> administratorBtns = new List<Button>() { homepageBtn, myAccountBtn, notificationsBtn, employeesBtn, attendanceBtn };
            List<Button> employeesBtns = new List<Button>() { myDashboardBtn, myAccountBtn, notificationsBtn, attendanceBtn };


            if (currentUser.Role == "Administrator")
            {
                int i = 0;
                foreach (Button btn in administratorBtns)
                {
                    btn.Visible = true;
                    btn.Location = new System.Drawing.Point(0, 180 + i * (10 + btn.Size.Height));
                    i++;
                }

                homepageBtn_Click(this.homepageBtn, null);

            }

            if (currentUser.Role == "Employee")
            {
                int i = 0;
                foreach (Button btn in employeesBtns)
                {
                    btn.Visible = true;
                    btn.Location = new System.Drawing.Point(0, 180 + i * (10 + btn.Size.Height));
                    i++;
                }
                myDashboardBtn_Click(this.myDashboardBtn, null);
            }
            //photo
            this.dashboardEmployeeAvatar.Image = Program.ConvertByteArrayToImage(currentUser.Photo);

            //homepage label with user's name
            this.dashboardEmployeeNameLabel.Text = currentUser.Name + " " + currentUser.Surname;

            if (this.rfidThread != null)
            {
                this.rfidStatusLabel.Text = "Running";
                this.rfidStatusLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                this.rfidStatusLabel.Text = "Stopped";
                this.rfidStatusLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// Event for updatnig photo change and name change after user changes it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InitItemsEvent(object sender, EventArgs e)
        {
            //photo
            this.dashboardEmployeeAvatar.Image = Program.ConvertByteArrayToImage(currentUser.Photo);

            //homepage label with user's name
            this.dashboardEmployeeNameLabel.Text = currentUser.Name + " " + currentUser.Surname;
        }

        /// <summary>
        /// Struct with colors for buttons
        /// </summary>
        private struct RGBColors
        {
            public static Color activeColor = Color.FromArgb(171, 171, 171);
            public static Color disabledColor = Color.SlateGray;
        }

        /// <summary>
        /// Method to highlight button with active color
        /// </summary>
        /// <param name="senderBtn"></param>
        /// <param name="color"></param>
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //disable previous button
                DisableButton(RGBColors.disabledColor);

                //activate current button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(79, 79, 79);
                currentBtn.ForeColor = color;

            }
        }

        /// <summary>
        /// Method to disable button and change its color to disabled, basic
        /// </summary>
        /// <param name="color"></param>
        private void DisableButton(Color color)
        {
            if (currentBtn != null)
            {
                //disable current button
                currentBtn.BackColor = color;
                currentBtn.ForeColor = Color.Black;

            }
        }

        /// <summary>
        /// Opens child form in childFormPanel
        /// </summary>
        /// <param name="childForm"></param>
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// Opens another form over childForm, works like like layer, so you still have main child form opened but under it
        /// </summary>
        /// <param name="childForm"></param>
        public void OpenChildFormOverChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DashBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// As timer ticks it changes the time label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            this.dateTimeLabel.Text = System.DateTime.Now.ToString();
            
        }

        #region Subforms

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void myDashboardBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            OpenChildForm(new MyDashboardForm());
        }

        private void myAccountBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            MyAccountForm form = new MyAccountForm(this, ref currentUser);
            form.updateChangesEventHandler += InitItemsEvent;
            OpenChildForm(form);
        }

        private void notificationsBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            OpenChildForm(new NotificationForm(this, ref currentUser));
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            OpenChildForm(new EmployeesForm(this, ref this.currentUser));
        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            OpenChildForm(new AttendanceForm());
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            OpenChildForm(new HomepageForm(this, ref this.currentUser));
        }

        #endregion
    }
}
