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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.contentLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateOfDeliveryLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.markAsReadBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.messagePanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
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
            this.messagePanel.Controls.Add(this.contentPanel);
            this.messagePanel.Controls.Add(this.label3);
            this.messagePanel.Controls.Add(this.label2);
            this.messagePanel.Controls.Add(this.label1);
            this.messagePanel.Controls.Add(this.dateOfDeliveryLabel);
            this.messagePanel.Controls.Add(this.authorNameLabel);
            this.messagePanel.Controls.Add(this.titleLabel);
            this.messagePanel.Location = new System.Drawing.Point(12, 92);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(1245, 486);
            this.messagePanel.TabIndex = 44;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentPanel.Controls.Add(this.contentLabel);
            this.contentPanel.Location = new System.Drawing.Point(3, 136);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1235, 343);
            this.contentPanel.TabIndex = 7;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contentLabel.Location = new System.Drawing.Point(3, 10);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(114, 32);
            this.contentLabel.TabIndex = 2;
            this.contentLabel.Text = "Content";
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
            this.markAsReadBtn.Location = new System.Drawing.Point(27, 613);
            this.markAsReadBtn.Name = "markAsReadBtn";
            this.markAsReadBtn.Size = new System.Drawing.Size(174, 59);
            this.markAsReadBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.markAsReadBtn.StateCommon.Border.Rounding = 30;
            this.markAsReadBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.markAsReadBtn.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.markAsReadBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.markAsReadBtn.StatePressed.Border.Color1 = System.Drawing.Color.Silver;
            this.markAsReadBtn.StatePressed.Border.Color2 = System.Drawing.Color.Silver;
            this.markAsReadBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.markAsReadBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.markAsReadBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.markAsReadBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.markAsReadBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.markAsReadBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.markAsReadBtn.TabIndex = 45;
            this.markAsReadBtn.Values.Text = "Mark as read";
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
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Label dateOfDeliveryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label contentLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton markAsReadBtn;
    }
}