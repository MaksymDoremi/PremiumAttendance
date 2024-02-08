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
            this.filterBtn = new System.Windows.Forms.Button();
            this.newestRadionBtn = new System.Windows.Forms.RadioButton();
            this.oldestRadionBtn = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
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
            // filterBtn
            // 
            this.filterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterBtn.Location = new System.Drawing.Point(18, 128);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(122, 36);
            this.filterBtn.TabIndex = 37;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // newestRadionBtn
            // 
            this.newestRadionBtn.AutoSize = true;
            this.newestRadionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newestRadionBtn.Location = new System.Drawing.Point(6, 21);
            this.newestRadionBtn.Name = "newestRadionBtn";
            this.newestRadionBtn.Size = new System.Drawing.Size(116, 33);
            this.newestRadionBtn.TabIndex = 38;
            this.newestRadionBtn.TabStop = true;
            this.newestRadionBtn.Text = "Newest";
            this.newestRadionBtn.UseVisualStyleBackColor = true;
            // 
            // oldestRadionBtn
            // 
            this.oldestRadionBtn.AutoSize = true;
            this.oldestRadionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oldestRadionBtn.Location = new System.Drawing.Point(6, 60);
            this.oldestRadionBtn.Name = "oldestRadionBtn";
            this.oldestRadionBtn.Size = new System.Drawing.Size(105, 33);
            this.oldestRadionBtn.TabIndex = 39;
            this.oldestRadionBtn.TabStop = true;
            this.oldestRadionBtn.Text = "Oldest";
            this.oldestRadionBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.newestRadionBtn);
            this.groupBox.Controls.Add(this.oldestRadionBtn);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 100);
            this.groupBox.TabIndex = 40;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Filter by:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromTextBox.Location = new System.Drawing.Point(351, 22);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(207, 34);
            this.fromTextBox.TabIndex = 41;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectTextBox.Location = new System.Drawing.Point(351, 78);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(207, 34);
            this.subjectTextBox.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(243, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(243, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 44;
            this.label2.Text = "Subject:";
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1269, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.sendNotificationBtn);
            this.Controls.Add(this.notificationsFloatLayoutPanel);
            this.Name = "NotificationForm";
            this.Text = "NotificationForm";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel notificationsFloatLayoutPanel;
        private System.Windows.Forms.Button sendNotificationBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.RadioButton newestRadionBtn;
        private System.Windows.Forms.RadioButton oldestRadionBtn;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}