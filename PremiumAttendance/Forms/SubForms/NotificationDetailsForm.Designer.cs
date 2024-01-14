namespace PremiumAttendance.Forms.SubForms
{
    partial class NotificationDetailsForm
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.contentLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.dateOfDeliveryLabel = new System.Windows.Forms.Label();
            this.markAsReadBtn = new System.Windows.Forms.Button();
            this.messagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeBtn.Image = global::PremiumAttendance.Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz24;
            this.closeBtn.Location = new System.Drawing.Point(12, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(63, 43);
            this.closeBtn.TabIndex = 43;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.messagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messagePanel.Controls.Add(this.dateOfDeliveryLabel);
            this.messagePanel.Controls.Add(this.authorNameLabel);
            this.messagePanel.Controls.Add(this.contentLabel);
            this.messagePanel.Controls.Add(this.titleLabel);
            this.messagePanel.Location = new System.Drawing.Point(12, 92);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(1245, 486);
            this.messagePanel.TabIndex = 44;
            // 
            // contentLabel
            // 
            this.contentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contentLabel.Location = new System.Drawing.Point(13, 90);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(1209, 373);
            this.contentLabel.TabIndex = 1;
            this.contentLabel.Text = "Content";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(13, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(395, 80);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorNameLabel.Location = new System.Drawing.Point(414, 10);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(395, 80);
            this.authorNameLabel.TabIndex = 2;
            this.authorNameLabel.Text = "Author Name";
            // 
            // dateOfDeliveryLabel
            // 
            this.dateOfDeliveryLabel.AutoSize = true;
            this.dateOfDeliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateOfDeliveryLabel.Location = new System.Drawing.Point(815, 10);
            this.dateOfDeliveryLabel.Name = "dateOfDeliveryLabel";
            this.dateOfDeliveryLabel.Size = new System.Drawing.Size(221, 32);
            this.dateOfDeliveryLabel.TabIndex = 3;
            this.dateOfDeliveryLabel.Text = "DateOfDelivery";
            // 
            // markAsReadBtn
            // 
            this.markAsReadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.markAsReadBtn.Location = new System.Drawing.Point(12, 600);
            this.markAsReadBtn.Name = "markAsReadBtn";
            this.markAsReadBtn.Size = new System.Drawing.Size(174, 44);
            this.markAsReadBtn.TabIndex = 45;
            this.markAsReadBtn.Text = "Mark as read";
            this.markAsReadBtn.UseVisualStyleBackColor = true;
            this.markAsReadBtn.Click += new System.EventHandler(this.markAsReadBtn_Click);
            // 
            // NotificationDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 703);
            this.Controls.Add(this.markAsReadBtn);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.closeBtn);
            this.Name = "NotificationDetailsForm";
            this.Text = "NotificationDetailsForm";
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Label dateOfDeliveryLabel;
        private System.Windows.Forms.Button markAsReadBtn;
    }
}