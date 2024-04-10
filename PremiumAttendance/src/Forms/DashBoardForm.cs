using PremiumAttendance.Forms.SidebarForms;
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

namespace PremiumAttendance.Forms
{
    public partial class DashBoardForm : Form
    {

        private Employee currentUser;
        private Button currentBtn;

        private Form currentChildForm;

        private LoginForm loginForm;

        private Thread rfidThread;

        private RFID rfidModule;
        public DashBoardForm(Form loginForm, ref Employee currentUser, ref Thread rfidThread, ref RFID rfidModule)
        {
            InitializeComponent();

            this.currentUser = currentUser;
            this.loginForm = (LoginForm)loginForm;
            this.rfidThread = rfidThread;
            this.rfidModule = rfidModule;
            InitItems();
            this.timer.Start();
        }

        /// <summary>
        /// Init method. Initializes every needed component. Buttons, labels, avatar picture and RFID status
        /// </summary>
        private void InitItems()
        {
            //Administrator and employee button division
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

            //rfid reader status
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
        /// Event for updatnig photo and name after user changes it in database
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
        /// Method to disable button and change its color to disabled default color
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
        /// Opens another form over childForm, works like layer, so you still have main child form opened but under it
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

        /// <summary>
        /// Exists prorgam, kills all processeses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DashBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// As timer ticks it changes the time label. Also tries to restore RFID reader if it's not working
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            this.dateTimeLabel.Text = System.DateTime.Now.ToString();

            // if reader wasn't connected at first
            if (rfidModule == null)
            {
                this.rfidStatusLabel.Text = "Stopped";
                this.rfidStatusLabel.ForeColor = System.Drawing.Color.Red;

                try
                {
                    rfidModule = new RFID();
                    rfidThread = new Thread(rfidModule.ReadTag);
                    rfidThread.IsBackground = true;
                    rfidThread.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // if reader is connected and works properly
            if (this.rfidThread != null && this.rfidThread.ThreadState != ThreadState.Stopped)
            {
                this.rfidStatusLabel.Text = "Running";
                this.rfidStatusLabel.ForeColor = System.Drawing.Color.Green;
            }
            // if reader was connected but stopped working => try to restore
            else if (this.rfidThread != null && this.rfidThread.ThreadState == ThreadState.Stopped)
            {
                this.rfidStatusLabel.Text = "Stopped";
                this.rfidStatusLabel.ForeColor = System.Drawing.Color.Red;

                try
                {
                    rfidModule.OpenSerialPort();
                    rfidThread = new Thread(rfidModule.ReadTag);
                    rfidThread.IsBackground = true;
                    rfidThread.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        #region Subforms

        /// <summary>
        /// Logs out, show login page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.timer.Stop();
            this.Hide();
        }

        /// <summary>
        /// Opens dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myDashboardBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            OpenChildForm(new MyDashboardForm(this.currentUser));
        }

        /// <summary>
        /// Opens my account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myAccountBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            MyAccountForm form = new MyAccountForm(this, ref currentUser);
            form.updateChangesEventHandler += InitItemsEvent;
            OpenChildForm(form);
        }

        /// <summary>
        /// Opens notifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notificationsBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            OpenChildForm(new NotificationForm(this, ref currentUser));
        }

        /// <summary>
        /// Opens employees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeesBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            OpenChildForm(new EmployeesForm(this, ref this.currentUser));
        }

        /// <summary>
        /// Opens attendancce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            OpenChildForm(new AttendanceForm(this.currentUser));
        }

        /// <summary>
        /// Opens homepage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homepageBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeColor);
            OpenChildForm(new HomepageForm(this, ref this.currentUser));
        }

        #endregion

        /// <summary>
        /// Opens homepage or dashboard regarding to user role
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoPictureBox_Click(object sender, EventArgs e)
        {
            if (this.currentUser.Role == "Administrator")
            {
                homepageBtn_Click(this.homepageBtn, null);
            }

            if (this.currentUser.Role == "Employee")
            {
                myDashboardBtn_Click(this.myDashboardBtn, null);
            }
        }
    }
}
