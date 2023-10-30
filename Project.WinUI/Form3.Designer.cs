namespace Project.WinUI
{
    partial class Form3
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
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.txtPLastName = new System.Windows.Forms.TextBox();
            this.txtPFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(12, 39);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(121, 21);
            this.cmbDoctor.TabIndex = 23;
            this.cmbDoctor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbDoctor_Format);
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(12, 12);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(121, 21);
            this.cmbBranch.TabIndex = 24;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // lblPatient
            // 
            this.lblPatient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPatient.Location = new System.Drawing.Point(9, 207);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(371, 38);
            this.lblPatient.TabIndex = 22;
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.Location = new System.Drawing.Point(140, 12);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(240, 186);
            this.lstPatients.TabIndex = 21;
            this.lstPatients.SelectedIndexChanged += new System.EventHandler(this.lstPatients_SelectedIndexChanged);
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.Location = new System.Drawing.Point(12, 118);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(122, 23);
            this.btnCreateAppointment.TabIndex = 20;
            this.btnCreateAppointment.Text = "Randevu Oluştur";
            this.btnCreateAppointment.UseVisualStyleBackColor = true;
            this.btnCreateAppointment.Click += new System.EventHandler(this.btnCreateAppointment_Click);
            // 
            // txtPLastName
            // 
            this.txtPLastName.Location = new System.Drawing.Point(12, 92);
            this.txtPLastName.Name = "txtPLastName";
            this.txtPLastName.Size = new System.Drawing.Size(122, 20);
            this.txtPLastName.TabIndex = 18;
            // 
            // txtPFirstName
            // 
            this.txtPFirstName.Location = new System.Drawing.Point(12, 66);
            this.txtPFirstName.Name = "txtPFirstName";
            this.txtPFirstName.Size = new System.Drawing.Size(122, 20);
            this.txtPFirstName.TabIndex = 19;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 286);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lstPatients);
            this.Controls.Add(this.btnCreateAppointment);
            this.Controls.Add(this.txtPLastName);
            this.Controls.Add(this.txtPFirstName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.TextBox txtPLastName;
        private System.Windows.Forms.TextBox txtPFirstName;
    }
}