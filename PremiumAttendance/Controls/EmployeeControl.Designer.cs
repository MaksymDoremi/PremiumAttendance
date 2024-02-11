namespace PremiumAttendance.Controls
{
    partial class EmployeeControl
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
            this.employeeImage = new System.Windows.Forms.PictureBox();
            this.employeeNameSurname = new System.Windows.Forms.Label();
            this.employeeRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeImage
            // 
            this.employeeImage.Location = new System.Drawing.Point(14, 12);
            this.employeeImage.Name = "employeeImage";
            this.employeeImage.Size = new System.Drawing.Size(100, 100);
            this.employeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeeImage.TabIndex = 1;
            this.employeeImage.TabStop = false;
            this.employeeImage.Click += new System.EventHandler(this.EmployeeControl_Click);
            this.employeeImage.MouseEnter += new System.EventHandler(this.EmployeeControl_MouseEnter);
            this.employeeImage.MouseLeave += new System.EventHandler(this.EmployeeControl_MouseLeave);
            // 
            // employeeNameSurname
            // 
            this.employeeNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.employeeNameSurname.Location = new System.Drawing.Point(228, 12);
            this.employeeNameSurname.Name = "employeeNameSurname";
            this.employeeNameSurname.Size = new System.Drawing.Size(165, 49);
            this.employeeNameSurname.TabIndex = 2;
            this.employeeNameSurname.Text = "label1";
            this.employeeNameSurname.Click += new System.EventHandler(this.EmployeeControl_Click);
            this.employeeNameSurname.MouseEnter += new System.EventHandler(this.EmployeeControl_MouseEnter);
            this.employeeNameSurname.MouseLeave += new System.EventHandler(this.EmployeeControl_MouseLeave);
            // 
            // employeeRole
            // 
            this.employeeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.employeeRole.Location = new System.Drawing.Point(228, 71);
            this.employeeRole.Name = "employeeRole";
            this.employeeRole.Size = new System.Drawing.Size(165, 37);
            this.employeeRole.TabIndex = 3;
            this.employeeRole.Text = "label1";
            this.employeeRole.Click += new System.EventHandler(this.EmployeeControl_Click);
            this.employeeRole.MouseEnter += new System.EventHandler(this.EmployeeControl_MouseEnter);
            this.employeeRole.MouseLeave += new System.EventHandler(this.EmployeeControl_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.EmployeeControl_Click);
            this.label1.MouseEnter += new System.EventHandler(this.EmployeeControl_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.EmployeeControl_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(131, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Role:";
            this.label2.Click += new System.EventHandler(this.EmployeeControl_Click);
            this.label2.MouseEnter += new System.EventHandler(this.EmployeeControl_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.EmployeeControl_MouseLeave);
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeRole);
            this.Controls.Add(this.employeeNameSurname);
            this.Controls.Add(this.employeeImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(409, 124);
            this.Click += new System.EventHandler(this.EmployeeControl_Click);
            this.MouseEnter += new System.EventHandler(this.EmployeeControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.EmployeeControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.employeeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox employeeImage;
        private System.Windows.Forms.Label employeeNameSurname;
        private System.Windows.Forms.Label employeeRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
