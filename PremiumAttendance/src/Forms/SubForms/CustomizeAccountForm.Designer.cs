namespace PremiumAttendance.Forms.SubForms
{
    partial class CustomizeAccountForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.changeImageBox = new System.Windows.Forms.PictureBox();
            this.applyChangesAccountInfoBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.changeNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.changePhoneTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.changeEmailTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.changeRfidTagTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.changeSurnameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.browseImagesBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.changeImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(77, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 36);
            this.label5.TabIndex = 33;
            this.label5.Text = "RFID_TAG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(77, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 36);
            this.label4.TabIndex = 27;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(77, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 36);
            this.label3.TabIndex = 26;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(77, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 36);
            this.label2.TabIndex = 25;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(77, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeBtn.Image = global::PremiumAttendance.Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz24;
            this.closeBtn.Location = new System.Drawing.Point(12, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(63, 43);
            this.closeBtn.TabIndex = 37;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // changeImageBox
            // 
            this.changeImageBox.Location = new System.Drawing.Point(787, 31);
            this.changeImageBox.Name = "changeImageBox";
            this.changeImageBox.Size = new System.Drawing.Size(381, 446);
            this.changeImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changeImageBox.TabIndex = 35;
            this.changeImageBox.TabStop = false;
            // 
            // applyChangesAccountInfoBtn
            // 
            this.applyChangesAccountInfoBtn.Location = new System.Drawing.Point(83, 550);
            this.applyChangesAccountInfoBtn.Name = "applyChangesAccountInfoBtn";
            this.applyChangesAccountInfoBtn.Size = new System.Drawing.Size(154, 80);
            this.applyChangesAccountInfoBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.applyChangesAccountInfoBtn.StateCommon.Border.Rounding = 35;
            this.applyChangesAccountInfoBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applyChangesAccountInfoBtn.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.applyChangesAccountInfoBtn.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.applyChangesAccountInfoBtn.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.applyChangesAccountInfoBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.applyChangesAccountInfoBtn.StatePressed.Border.Color1 = System.Drawing.Color.Silver;
            this.applyChangesAccountInfoBtn.StatePressed.Border.Color2 = System.Drawing.Color.Silver;
            this.applyChangesAccountInfoBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.applyChangesAccountInfoBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.applyChangesAccountInfoBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.applyChangesAccountInfoBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.applyChangesAccountInfoBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.applyChangesAccountInfoBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.applyChangesAccountInfoBtn.TabIndex = 6;
            this.applyChangesAccountInfoBtn.Values.Text = "Apply \r\nChanges";
            this.applyChangesAccountInfoBtn.Click += new System.EventHandler(this.applyChangesAccountInfoBtn_Click);
            // 
            // changeNameTextBox
            // 
            this.changeNameTextBox.Location = new System.Drawing.Point(278, 61);
            this.changeNameTextBox.Name = "changeNameTextBox";
            this.changeNameTextBox.Size = new System.Drawing.Size(285, 54);
            this.changeNameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeNameTextBox.StateCommon.Border.Rounding = 25;
            this.changeNameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeNameTextBox.TabIndex = 1;
            // 
            // changePhoneTextBox
            // 
            this.changePhoneTextBox.Location = new System.Drawing.Point(278, 358);
            this.changePhoneTextBox.Name = "changePhoneTextBox";
            this.changePhoneTextBox.Size = new System.Drawing.Size(285, 54);
            this.changePhoneTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changePhoneTextBox.StateCommon.Border.Rounding = 25;
            this.changePhoneTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changePhoneTextBox.TabIndex = 5;
            // 
            // changeEmailTextBox
            // 
            this.changeEmailTextBox.Location = new System.Drawing.Point(278, 283);
            this.changeEmailTextBox.Name = "changeEmailTextBox";
            this.changeEmailTextBox.Size = new System.Drawing.Size(285, 54);
            this.changeEmailTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeEmailTextBox.StateCommon.Border.Rounding = 25;
            this.changeEmailTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeEmailTextBox.TabIndex = 4;
            // 
            // changeRfidTagTextBox
            // 
            this.changeRfidTagTextBox.Location = new System.Drawing.Point(278, 208);
            this.changeRfidTagTextBox.Name = "changeRfidTagTextBox";
            this.changeRfidTagTextBox.Size = new System.Drawing.Size(285, 54);
            this.changeRfidTagTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeRfidTagTextBox.StateCommon.Border.Rounding = 25;
            this.changeRfidTagTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeRfidTagTextBox.TabIndex = 3;
            // 
            // changeSurnameTextBox
            // 
            this.changeSurnameTextBox.Location = new System.Drawing.Point(278, 135);
            this.changeSurnameTextBox.Name = "changeSurnameTextBox";
            this.changeSurnameTextBox.Size = new System.Drawing.Size(285, 54);
            this.changeSurnameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeSurnameTextBox.StateCommon.Border.Rounding = 25;
            this.changeSurnameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeSurnameTextBox.TabIndex = 2;
            // 
            // browseImagesBtn
            // 
            this.browseImagesBtn.Location = new System.Drawing.Point(892, 483);
            this.browseImagesBtn.Name = "browseImagesBtn";
            this.browseImagesBtn.Size = new System.Drawing.Size(179, 60);
            this.browseImagesBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.browseImagesBtn.StateCommon.Border.Rounding = 35;
            this.browseImagesBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browseImagesBtn.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.browseImagesBtn.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.browseImagesBtn.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.browseImagesBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.browseImagesBtn.StatePressed.Border.Color1 = System.Drawing.Color.Silver;
            this.browseImagesBtn.StatePressed.Border.Color2 = System.Drawing.Color.Silver;
            this.browseImagesBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.browseImagesBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.browseImagesBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.browseImagesBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.browseImagesBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.browseImagesBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.browseImagesBtn.TabIndex = 7;
            this.browseImagesBtn.Values.Text = "Browse Files";
            this.browseImagesBtn.Click += new System.EventHandler(this.browseImagesBtn_Click);
            // 
            // CustomizeAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 703);
            this.Controls.Add(this.browseImagesBtn);
            this.Controls.Add(this.changeSurnameTextBox);
            this.Controls.Add(this.changeRfidTagTextBox);
            this.Controls.Add(this.changeEmailTextBox);
            this.Controls.Add(this.changePhoneTextBox);
            this.Controls.Add(this.changeNameTextBox);
            this.Controls.Add(this.applyChangesAccountInfoBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.changeImageBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomizeAccountForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomizeAccountForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.changeImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox changeImageBox;
        private System.Windows.Forms.Button closeBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton applyChangesAccountInfoBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox changeNameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox changePhoneTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox changeEmailTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox changeRfidTagTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox changeSurnameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton browseImagesBtn;
    }
}