namespace PremiumAttendance.Controls
{
    partial class ColleagueControl
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
            this.colleaguePicture = new System.Windows.Forms.PictureBox();
            this.colleagueNameSurnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colleaguePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // colleaguePicture
            // 
            this.colleaguePicture.Location = new System.Drawing.Point(3, 3);
            this.colleaguePicture.Name = "colleaguePicture";
            this.colleaguePicture.Size = new System.Drawing.Size(91, 89);
            this.colleaguePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colleaguePicture.TabIndex = 0;
            this.colleaguePicture.TabStop = false;
            // 
            // colleagueNameSurnameLabel
            // 
            this.colleagueNameSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colleagueNameSurnameLabel.Location = new System.Drawing.Point(100, 3);
            this.colleagueNameSurnameLabel.Name = "colleagueNameSurnameLabel";
            this.colleagueNameSurnameLabel.Size = new System.Drawing.Size(229, 69);
            this.colleagueNameSurnameLabel.TabIndex = 1;
            this.colleagueNameSurnameLabel.Text = "name surname";
            // 
            // ColleagueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.colleagueNameSurnameLabel);
            this.Controls.Add(this.colleaguePicture);
            this.Name = "ColleagueControl";
            this.Size = new System.Drawing.Size(406, 93);
            ((System.ComponentModel.ISupportInitialize)(this.colleaguePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox colleaguePicture;
        private System.Windows.Forms.Label colleagueNameSurnameLabel;
    }
}
