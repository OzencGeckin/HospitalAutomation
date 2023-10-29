namespace Project.WinUI
{
    partial class Form2
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
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btnSwitchForm3 = new System.Windows.Forms.Button();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lstDoctors = new System.Windows.Forms.ListBox();
            this.btnDoctorAdd = new System.Windows.Forms.Button();
            this.txtDLastName = new System.Windows.Forms.TextBox();
            this.txtDFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(13, 65);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(121, 21);
            this.cmbBranch.TabIndex = 17;
            // 
            // btnSwitchForm3
            // 
            this.btnSwitchForm3.Location = new System.Drawing.Point(9, 248);
            this.btnSwitchForm3.Name = "btnSwitchForm3";
            this.btnSwitchForm3.Size = new System.Drawing.Size(371, 33);
            this.btnSwitchForm3.TabIndex = 16;
            this.btnSwitchForm3.Text = "Hasta Form\'una Geç";
            this.btnSwitchForm3.UseVisualStyleBackColor = true;
            this.btnSwitchForm3.Click += new System.EventHandler(this.btnSwitchForm3_Click);
            // 
            // lblDoctor
            // 
            this.lblDoctor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDoctor.Location = new System.Drawing.Point(9, 207);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(371, 38);
            this.lblDoctor.TabIndex = 15;
            // 
            // lstDoctors
            // 
            this.lstDoctors.FormattingEnabled = true;
            this.lstDoctors.Location = new System.Drawing.Point(140, 12);
            this.lstDoctors.Name = "lstDoctors";
            this.lstDoctors.Size = new System.Drawing.Size(240, 186);
            this.lstDoctors.TabIndex = 14;
            this.lstDoctors.SelectedIndexChanged += new System.EventHandler(this.lstDoctors_SelectedIndexChanged);
            // 
            // btnDoctorAdd
            // 
            this.btnDoctorAdd.Location = new System.Drawing.Point(12, 92);
            this.btnDoctorAdd.Name = "btnDoctorAdd";
            this.btnDoctorAdd.Size = new System.Drawing.Size(122, 23);
            this.btnDoctorAdd.TabIndex = 13;
            this.btnDoctorAdd.Text = "DoktorEkle";
            this.btnDoctorAdd.UseVisualStyleBackColor = true;
            this.btnDoctorAdd.Click += new System.EventHandler(this.btnDoctorAdd_Click);
            // 
            // txtDLastName
            // 
            this.txtDLastName.Location = new System.Drawing.Point(12, 38);
            this.txtDLastName.Name = "txtDLastName";
            this.txtDLastName.Size = new System.Drawing.Size(122, 20);
            this.txtDLastName.TabIndex = 11;
            // 
            // txtDFirstName
            // 
            this.txtDFirstName.Location = new System.Drawing.Point(12, 12);
            this.txtDFirstName.Name = "txtDFirstName";
            this.txtDFirstName.Size = new System.Drawing.Size(122, 20);
            this.txtDFirstName.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.btnSwitchForm3);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lstDoctors);
            this.Controls.Add(this.btnDoctorAdd);
            this.Controls.Add(this.txtDLastName);
            this.Controls.Add(this.txtDFirstName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Button btnSwitchForm3;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ListBox lstDoctors;
        private System.Windows.Forms.Button btnDoctorAdd;
        private System.Windows.Forms.TextBox txtDLastName;
        private System.Windows.Forms.TextBox txtDFirstName;
    }
}