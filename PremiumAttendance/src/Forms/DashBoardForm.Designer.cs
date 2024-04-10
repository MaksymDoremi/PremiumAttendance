namespace PremiumAttendance.Forms
{
    partial class DashBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.rfidStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.attendanceBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.myDashboardBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.notificationsBtn = new System.Windows.Forms.Button();
            this.myAccountBtn = new System.Windows.Forms.Button();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.dashboardEmployeeAvatar = new System.Windows.Forms.PictureBox();
            this.dashboardEmployeeNameLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardEmployeeAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.SlateGray;
            this.sidebarPanel.Controls.Add(this.rfidStatusLabel);
            this.sidebarPanel.Controls.Add(this.label1);
            this.sidebarPanel.Controls.Add(this.logoPictureBox);
            this.sidebarPanel.Controls.Add(this.attendanceBtn);
            this.sidebarPanel.Controls.Add(this.employeesBtn);
            this.sidebarPanel.Controls.Add(this.myDashboardBtn);
            this.sidebarPanel.Controls.Add(this.logoutBtn);
            this.sidebarPanel.Controls.Add(this.notificationsBtn);
            this.sidebarPanel.Controls.Add(this.myAccountBtn);
            this.sidebarPanel.Controls.Add(this.homepageBtn);
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(290, 858);
            this.sidebarPanel.TabIndex = 0;
            // 
            // rfidStatusLabel
            // 
            this.rfidStatusLabel.AutoSize = true;
            this.rfidStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rfidStatusLabel.Location = new System.Drawing.Point(143, 648);
            this.rfidStatusLabel.Name = "rfidStatusLabel";
            this.rfidStatusLabel.Size = new System.Drawing.Size(55, 20);
            this.rfidStatusLabel.TabIndex = 9;
            this.rfidStatusLabel.Text = "status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "RFID Status:";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPictureBox.Image = global::PremiumAttendance.Properties.Resources.logo;
            this.logoPictureBox.InitialImage = global::PremiumAttendance.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 32);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(290, 142);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 7;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // attendanceBtn
            // 
            this.attendanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attendanceBtn.FlatAppearance.BorderSize = 0;
            this.attendanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendanceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attendanceBtn.Image = global::PremiumAttendance.Properties.Resources.today_FILL0_wght400_GRAD0_opsz24;
            this.attendanceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attendanceBtn.Location = new System.Drawing.Point(0, 471);
            this.attendanceBtn.Name = "attendanceBtn";
            this.attendanceBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.attendanceBtn.Size = new System.Drawing.Size(290, 63);
            this.attendanceBtn.TabIndex = 6;
            this.attendanceBtn.Text = "Attendance";
            this.attendanceBtn.UseVisualStyleBackColor = true;
            this.attendanceBtn.Click += new System.EventHandler(this.attendanceBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeesBtn.FlatAppearance.BorderSize = 0;
            this.employeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.employeesBtn.Image = global::PremiumAttendance.Properties.Resources.groups_FILL0_wght400_GRAD0_opsz24;
            this.employeesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesBtn.Location = new System.Drawing.Point(0, 394);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.employeesBtn.Size = new System.Drawing.Size(290, 63);
            this.employeesBtn.TabIndex = 5;
            this.employeesBtn.Text = "Employess";
            this.employeesBtn.UseVisualStyleBackColor = true;
            this.employeesBtn.Visible = false;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            // 
            // myDashboardBtn
            // 
            this.myDashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myDashboardBtn.FlatAppearance.BorderSize = 0;
            this.myDashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myDashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.myDashboardBtn.Image = global::PremiumAttendance.Properties.Resources.home_FILL0_wght400_GRAD0_opsz24;
            this.myDashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myDashboardBtn.Location = new System.Drawing.Point(0, 220);
            this.myDashboardBtn.Name = "myDashboardBtn";
            this.myDashboardBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.myDashboardBtn.Size = new System.Drawing.Size(290, 63);
            this.myDashboardBtn.TabIndex = 4;
            this.myDashboardBtn.Text = "My Dashboard";
            this.myDashboardBtn.UseVisualStyleBackColor = true;
            this.myDashboardBtn.Visible = false;
            this.myDashboardBtn.Click += new System.EventHandler(this.myDashboardBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Silver;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoutBtn.Location = new System.Drawing.Point(0, 790);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(290, 63);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // notificationsBtn
            // 
            this.notificationsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationsBtn.FlatAppearance.BorderSize = 0;
            this.notificationsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notificationsBtn.Image = global::PremiumAttendance.Properties.Resources.notifications_FILL0_wght400_GRAD0_opsz24;
            this.notificationsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notificationsBtn.Location = new System.Drawing.Point(0, 326);
            this.notificationsBtn.Name = "notificationsBtn";
            this.notificationsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.notificationsBtn.Size = new System.Drawing.Size(290, 63);
            this.notificationsBtn.TabIndex = 2;
            this.notificationsBtn.Text = "Notifications";
            this.notificationsBtn.UseVisualStyleBackColor = true;
            this.notificationsBtn.Click += new System.EventHandler(this.notificationsBtn_Click);
            // 
            // myAccountBtn
            // 
            this.myAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myAccountBtn.FlatAppearance.BorderSize = 0;
            this.myAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myAccountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.myAccountBtn.Image = global::PremiumAttendance.Properties.Resources.account_circle_FILL0_wght400_GRAD0_opsz24;
            this.myAccountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myAccountBtn.Location = new System.Drawing.Point(0, 253);
            this.myAccountBtn.Name = "myAccountBtn";
            this.myAccountBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.myAccountBtn.Size = new System.Drawing.Size(290, 63);
            this.myAccountBtn.TabIndex = 1;
            this.myAccountBtn.Text = "My Account";
            this.myAccountBtn.UseVisualStyleBackColor = true;
            this.myAccountBtn.Click += new System.EventHandler(this.myAccountBtn_Click);
            // 
            // homepageBtn
            // 
            this.homepageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homepageBtn.FlatAppearance.BorderSize = 0;
            this.homepageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homepageBtn.Image = global::PremiumAttendance.Properties.Resources.home_FILL0_wght400_GRAD0_opsz24;
            this.homepageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homepageBtn.Location = new System.Drawing.Point(0, 180);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homepageBtn.Size = new System.Drawing.Size(290, 63);
            this.homepageBtn.TabIndex = 0;
            this.homepageBtn.Text = "Homepage";
            this.homepageBtn.UseVisualStyleBackColor = true;
            this.homepageBtn.Visible = false;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.upperPanel.Controls.Add(this.dashboardEmployeeAvatar);
            this.upperPanel.Controls.Add(this.dashboardEmployeeNameLabel);
            this.upperPanel.Controls.Add(this.dateTimeLabel);
            this.upperPanel.Location = new System.Drawing.Point(290, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1192, 100);
            this.upperPanel.TabIndex = 1;
            // 
            // dashboardEmployeeAvatar
            // 
            this.dashboardEmployeeAvatar.Location = new System.Drawing.Point(760, 12);
            this.dashboardEmployeeAvatar.Name = "dashboardEmployeeAvatar";
            this.dashboardEmployeeAvatar.Size = new System.Drawing.Size(90, 80);
            this.dashboardEmployeeAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dashboardEmployeeAvatar.TabIndex = 2;
            this.dashboardEmployeeAvatar.TabStop = false;
            // 
            // dashboardEmployeeNameLabel
            // 
            this.dashboardEmployeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dashboardEmployeeNameLabel.Location = new System.Drawing.Point(866, 9);
            this.dashboardEmployeeNameLabel.Name = "dashboardEmployeeNameLabel";
            this.dashboardEmployeeNameLabel.Size = new System.Drawing.Size(314, 80);
            this.dashboardEmployeeNameLabel.TabIndex = 1;
            this.dashboardEmployeeNameLabel.Text = "name surname";
            this.dashboardEmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeLabel.Location = new System.Drawing.Point(26, 34);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(92, 32);
            this.dateTimeLabel.TabIndex = 0;
            this.dateTimeLabel.Text = "label1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.childFormPanel.Location = new System.Drawing.Point(290, 100);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1192, 758);
            this.childFormPanel.TabIndex = 2;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.sidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premium Attendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashBoardForm_FormClosed);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardEmployeeAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button homepageBtn;
        private System.Windows.Forms.Button notificationsBtn;
        private System.Windows.Forms.Button myAccountBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button myDashboardBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Button attendanceBtn;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.PictureBox dashboardEmployeeAvatar;
        private System.Windows.Forms.Label dashboardEmployeeNameLabel;
        private System.Windows.Forms.Label rfidStatusLabel;
        private System.Windows.Forms.Label label1;
    }
}