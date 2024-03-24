namespace PremiumAttendance.Forms.SubForms
{
    partial class SendNotificationForm
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
            this.adminPanel = new System.Windows.Forms.Panel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.sendNotificationBtn = new System.Windows.Forms.Button();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.titleTextBox);
            this.adminPanel.Controls.Add(this.contentTextBox);
            this.adminPanel.Controls.Add(this.sendNotificationBtn);
            this.adminPanel.Location = new System.Drawing.Point(89, 12);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(623, 395);
            this.adminPanel.TabIndex = 37;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleTextBox.Location = new System.Drawing.Point(3, 5);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(380, 27);
            this.titleTextBox.TabIndex = 39;
            this.titleTextBox.Text = "Title";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contentTextBox.Location = new System.Drawing.Point(3, 38);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(380, 354);
            this.contentTextBox.TabIndex = 38;
            this.contentTextBox.Text = "Content";
            // 
            // sendNotificationBtn
            // 
            this.sendNotificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sendNotificationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendNotificationBtn.Location = new System.Drawing.Point(445, 329);
            this.sendNotificationBtn.Name = "sendNotificationBtn";
            this.sendNotificationBtn.Size = new System.Drawing.Size(175, 63);
            this.sendNotificationBtn.TabIndex = 37;
            this.sendNotificationBtn.Text = "Send Notification";
            this.sendNotificationBtn.UseVisualStyleBackColor = true;
            this.sendNotificationBtn.Click += new System.EventHandler(this.sendNotificationBtn_Click);
            // 
            // SendNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendNotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SendNotificationForm";
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RichTextBox contentTextBox;
        private System.Windows.Forms.Button sendNotificationBtn;
    }
}