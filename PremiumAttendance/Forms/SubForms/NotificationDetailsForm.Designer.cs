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
            this.dateOfDeliveryLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.markAsReadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.messagePanel.Controls.Add(this.label3);
            this.messagePanel.Controls.Add(this.label2);
            this.messagePanel.Controls.Add(this.label1);
            this.messagePanel.Controls.Add(this.dateOfDeliveryLabel);
            this.messagePanel.Controls.Add(this.authorNameLabel);
            this.messagePanel.Controls.Add(this.contentLabel);
            this.messagePanel.Controls.Add(this.titleLabel);
            this.messagePanel.Location = new System.Drawing.Point(12, 92);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(1245, 486);
            this.messagePanel.TabIndex = 44;
            // 
            // dateOfDeliveryLabel
            // 
            this.dateOfDeliveryLabel.AutoSize = true;
            this.dateOfDeliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateOfDeliveryLabel.Location = new System.Drawing.Point(817, 48);
            this.dateOfDeliveryLabel.Name = "dateOfDeliveryLabel";
            this.dateOfDeliveryLabel.Size = new System.Drawing.Size(221, 32);
            this.dateOfDeliveryLabel.TabIndex = 3;
            this.dateOfDeliveryLabel.Text = "DateOfDelivery";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorNameLabel.Location = new System.Drawing.Point(416, 48);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(395, 80);
            this.authorNameLabel.TabIndex = 2;
            this.authorNameLabel.Text = "Author Name";
            // 
            // contentLabel
            // 
            this.contentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contentLabel.Location = new System.Drawing.Point(13, 128);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(1209, 335);
            this.contentLabel.TabIndex = 1;
            this.contentLabel.Text = "Content";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(15, 48);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(395, 80);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(417, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(818, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delivered";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}