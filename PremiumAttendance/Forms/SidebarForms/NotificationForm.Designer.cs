namespace PremiumAttendance.Forms.SidebarForms
{
    partial class NotificationForm
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
            this.notificationsFloatLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sendNotificationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notificationsFloatLayoutPanel
            // 
            this.notificationsFloatLayoutPanel.AutoScroll = true;
            this.notificationsFloatLayoutPanel.Location = new System.Drawing.Point(12, 171);
            this.notificationsFloatLayoutPanel.Name = "notificationsFloatLayoutPanel";
            this.notificationsFloatLayoutPanel.Size = new System.Drawing.Size(1245, 520);
            this.notificationsFloatLayoutPanel.TabIndex = 0;
            // 
            // sendNotificationBtn
            // 
            this.sendNotificationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendNotificationBtn.Location = new System.Drawing.Point(1021, 127);
            this.sendNotificationBtn.Name = "sendNotificationBtn";
            this.sendNotificationBtn.Size = new System.Drawing.Size(236, 38);
            this.sendNotificationBtn.TabIndex = 36;
            this.sendNotificationBtn.Text = "Send Notification";
            this.sendNotificationBtn.UseVisualStyleBackColor = true;
            this.sendNotificationBtn.Click += new System.EventHandler(this.sendNotificationBtn_Click);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1269, 703);
            this.Controls.Add(this.sendNotificationBtn);
            this.Controls.Add(this.notificationsFloatLayoutPanel);
            this.Name = "NotificationForm";
            this.Text = "NotificationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel notificationsFloatLayoutPanel;
        private System.Windows.Forms.Button sendNotificationBtn;
    }
}