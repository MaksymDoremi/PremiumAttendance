namespace PremiumAttendance.Controls
{
    partial class NotificationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.author_nameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // author_nameLabel
            // 
            this.author_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.author_nameLabel.Location = new System.Drawing.Point(20, 0);
            this.author_nameLabel.Name = "author_nameLabel";
            this.author_nameLabel.Size = new System.Drawing.Size(178, 81);
            this.author_nameLabel.TabIndex = 0;
            this.author_nameLabel.Text = "author name";
            this.author_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(204, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(168, 81);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeLabel.Location = new System.Drawing.Point(828, 28);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(94, 25);
            this.dateTimeLabel.TabIndex = 2;
            this.dateTimeLabel.Text = "Date time";
            // 
            // NotificationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.author_nameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NotificationControl";
            this.Size = new System.Drawing.Size(1198, 77);
            this.MouseEnter += new System.EventHandler(this.NotificationControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NotificationControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label author_nameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateTimeLabel;
    }
}
