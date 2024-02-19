namespace PremiumAttendance.Forms.SubForms
{
    partial class EmployeeAccount
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
            this.bigAvatarPicture = new System.Windows.Forms.PictureBox();
            this.photoNotSetLabel = new System.Windows.Forms.Label();
            this.changeAccountInfoBtn = new System.Windows.Forms.Button();
            this.actualRoleFromDB = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.actualPhoneFromDB = new System.Windows.Forms.Label();
            this.actualEmailFromDB = new System.Windows.Forms.Label();
            this.actualSurnameFromDB = new System.Windows.Forms.Label();
            this.actualNameFromDB = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.deleteEmployeeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bigAvatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bigAvatarPicture
            // 
            this.bigAvatarPicture.Location = new System.Drawing.Point(726, 50);
            this.bigAvatarPicture.Name = "bigAvatarPicture";
            this.bigAvatarPicture.Size = new System.Drawing.Size(366, 456);
            this.bigAvatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bigAvatarPicture.TabIndex = 39;
            this.bigAvatarPicture.TabStop = false;
            // 
            // photoNotSetLabel
            // 
            this.photoNotSetLabel.AutoSize = true;
            this.photoNotSetLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.photoNotSetLabel.Location = new System.Drawing.Point(752, 246);
            this.photoNotSetLabel.Name = "photoNotSetLabel";
            this.photoNotSetLabel.Size = new System.Drawing.Size(319, 57);
            this.photoNotSetLabel.TabIndex = 38;
            this.photoNotSetLabel.Text = "Photo not set";
            // 
            // changeAccountInfoBtn
            // 
            this.changeAccountInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeAccountInfoBtn.Location = new System.Drawing.Point(83, 576);
            this.changeAccountInfoBtn.Name = "changeAccountInfoBtn";
            this.changeAccountInfoBtn.Size = new System.Drawing.Size(165, 77);
            this.changeAccountInfoBtn.TabIndex = 37;
            this.changeAccountInfoBtn.Text = "Customize Account";
            this.changeAccountInfoBtn.UseVisualStyleBackColor = true;
            this.changeAccountInfoBtn.Click += new System.EventHandler(this.changeAccountInfoBtn_Click);
            // 
            // actualRoleFromDB
            // 
            this.actualRoleFromDB.AutoSize = true;
            this.actualRoleFromDB.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualRoleFromDB.Location = new System.Drawing.Point(299, 316);
            this.actualRoleFromDB.Name = "actualRoleFromDB";
            this.actualRoleFromDB.Size = new System.Drawing.Size(0, 36);
            this.actualRoleFromDB.TabIndex = 35;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roleLabel.Location = new System.Drawing.Point(82, 316);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(81, 36);
            this.roleLabel.TabIndex = 34;
            this.roleLabel.Text = "Role:";
            // 
            // actualPhoneFromDB
            // 
            this.actualPhoneFromDB.AutoSize = true;
            this.actualPhoneFromDB.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualPhoneFromDB.Location = new System.Drawing.Point(299, 246);
            this.actualPhoneFromDB.Name = "actualPhoneFromDB";
            this.actualPhoneFromDB.Size = new System.Drawing.Size(0, 36);
            this.actualPhoneFromDB.TabIndex = 33;
            // 
            // actualEmailFromDB
            // 
            this.actualEmailFromDB.AutoSize = true;
            this.actualEmailFromDB.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualEmailFromDB.Location = new System.Drawing.Point(299, 183);
            this.actualEmailFromDB.Name = "actualEmailFromDB";
            this.actualEmailFromDB.Size = new System.Drawing.Size(0, 36);
            this.actualEmailFromDB.TabIndex = 32;
            // 
            // actualSurnameFromDB
            // 
            this.actualSurnameFromDB.AutoSize = true;
            this.actualSurnameFromDB.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualSurnameFromDB.Location = new System.Drawing.Point(299, 118);
            this.actualSurnameFromDB.Name = "actualSurnameFromDB";
            this.actualSurnameFromDB.Size = new System.Drawing.Size(0, 36);
            this.actualSurnameFromDB.TabIndex = 31;
            // 
            // actualNameFromDB
            // 
            this.actualNameFromDB.AutoSize = true;
            this.actualNameFromDB.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualNameFromDB.Location = new System.Drawing.Point(299, 50);
            this.actualNameFromDB.Name = "actualNameFromDB";
            this.actualNameFromDB.Size = new System.Drawing.Size(0, 36);
            this.actualNameFromDB.TabIndex = 30;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneLabel.Location = new System.Drawing.Point(82, 246);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(107, 36);
            this.phoneLabel.TabIndex = 29;
            this.phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.Location = new System.Drawing.Point(82, 183);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(92, 36);
            this.emailLabel.TabIndex = 28;
            this.emailLabel.Text = "Email:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameLabel.Location = new System.Drawing.Point(82, 118);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(140, 36);
            this.surnameLabel.TabIndex = 27;
            this.surnameLabel.Text = "Surname:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(82, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 36);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "Name: ";
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeBtn.Image = global::PremiumAttendance.Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz24;
            this.closeBtn.Location = new System.Drawing.Point(13, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(63, 43);
            this.closeBtn.TabIndex = 40;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteEmployeeBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(299, 576);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(165, 77);
            this.deleteEmployeeBtn.TabIndex = 41;
            this.deleteEmployeeBtn.Text = "Delete Employee";
            this.deleteEmployeeBtn.UseVisualStyleBackColor = true;
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // EmployeeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 703);
            this.Controls.Add(this.deleteEmployeeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.bigAvatarPicture);
            this.Controls.Add(this.photoNotSetLabel);
            this.Controls.Add(this.changeAccountInfoBtn);
            this.Controls.Add(this.actualRoleFromDB);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.actualPhoneFromDB);
            this.Controls.Add(this.actualEmailFromDB);
            this.Controls.Add(this.actualSurnameFromDB);
            this.Controls.Add(this.actualNameFromDB);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "EmployeeAccount";
            this.Text = "EmployeeAccount";
            ((System.ComponentModel.ISupportInitialize)(this.bigAvatarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bigAvatarPicture;
        private System.Windows.Forms.Label photoNotSetLabel;
        private System.Windows.Forms.Button changeAccountInfoBtn;
        private System.Windows.Forms.Label actualRoleFromDB;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label actualPhoneFromDB;
        private System.Windows.Forms.Label actualEmailFromDB;
        private System.Windows.Forms.Label actualSurnameFromDB;
        private System.Windows.Forms.Label actualNameFromDB;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button deleteEmployeeBtn;
    }
}