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
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // notificationsFloatLayoutPanel
            // 
            this.notificationsFloatLayoutPanel.AutoScroll = true;
            this.notificationsFloatLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.notificationsFloatLayoutPanel.Location = new System.Drawing.Point(12, 171);
            this.notificationsFloatLayoutPanel.Name = "notificationsFloatLayoutPanel";
            this.notificationsFloatLayoutPanel.Size = new System.Drawing.Size(1245, 520);
            this.notificationsFloatLayoutPanel.TabIndex = 0;
            // 
            // sendNotificationBtn
            // 
            this.sendNotificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sendNotificationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendNotificationBtn.Location = new System.Drawing.Point(437, 50);
            this.sendNotificationBtn.Name = "sendNotificationBtn";
            this.sendNotificationBtn.Size = new System.Drawing.Size(175, 63);
            this.sendNotificationBtn.TabIndex = 33;
            this.sendNotificationBtn.Text = "Send Notification";
            this.sendNotificationBtn.UseVisualStyleBackColor = true;
            this.sendNotificationBtn.Click += new System.EventHandler(this.sendNotificationBtn_Click);
            // 
            // contentTextBox
            // 
            this.contentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contentTextBox.Location = new System.Drawing.Point(12, 50);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(380, 94);
            this.contentTextBox.TabIndex = 34;
            this.contentTextBox.Text = "";
            // 
            // filterBtn
            // 
            this.filterBtn.Image = global::PremiumAttendance.Properties.Resources.tune_FILL0_wght400_GRAD0_opsz24;
            this.filterBtn.Location = new System.Drawing.Point(1192, 12);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(65, 42);
            this.filterBtn.TabIndex = 35;
            this.filterBtn.UseVisualStyleBackColor = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleTextBox.Location = new System.Drawing.Point(12, 13);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(137, 27);
            this.titleTextBox.TabIndex = 36;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1269, 703);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.sendNotificationBtn);
            this.Controls.Add(this.notificationsFloatLayoutPanel);
            this.Name = "NotificationForm";
            this.Text = "NotificationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel notificationsFloatLayoutPanel;
        private System.Windows.Forms.Button sendNotificationBtn;
        private System.Windows.Forms.RichTextBox contentTextBox;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}