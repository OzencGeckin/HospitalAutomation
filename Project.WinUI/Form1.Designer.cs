namespace Project.WinUI
{
    partial class Form1
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
            this.btnSwitchForm2 = new System.Windows.Forms.Button();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lstBranches = new System.Windows.Forms.ListBox();
            this.btnBranchAdd = new System.Windows.Forms.Button();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSwitchForm2
            // 
            this.btnSwitchForm2.Location = new System.Drawing.Point(9, 248);
            this.btnSwitchForm2.Name = "btnSwitchForm2";
            this.btnSwitchForm2.Size = new System.Drawing.Size(349, 33);
            this.btnSwitchForm2.TabIndex = 9;
            this.btnSwitchForm2.Text = "Doktor Form\'una Geç";
            this.btnSwitchForm2.UseVisualStyleBackColor = true;
            this.btnSwitchForm2.Click += new System.EventHandler(this.btnSwitchForm2_Click);
            // 
            // lblBranch
            // 
            this.lblBranch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBranch.Location = new System.Drawing.Point(9, 207);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(349, 38);
            this.lblBranch.TabIndex = 8;
            // 
            // lstBranches
            // 
            this.lstBranches.FormattingEnabled = true;
            this.lstBranches.Location = new System.Drawing.Point(118, 11);
            this.lstBranches.Name = "lstBranches";
            this.lstBranches.Size = new System.Drawing.Size(240, 186);
            this.lstBranches.TabIndex = 7;
            this.lstBranches.SelectedIndexChanged += new System.EventHandler(this.lstBranches_SelectedIndexChanged);
            // 
            // btnBranchAdd
            // 
            this.btnBranchAdd.Location = new System.Drawing.Point(12, 39);
            this.btnBranchAdd.Name = "btnBranchAdd";
            this.btnBranchAdd.Size = new System.Drawing.Size(100, 23);
            this.btnBranchAdd.TabIndex = 6;
            this.btnBranchAdd.Text = "Branş Ekle";
            this.btnBranchAdd.UseVisualStyleBackColor = true;
            this.btnBranchAdd.Click += new System.EventHandler(this.btnBranchAdd_Click);
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(12, 12);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(100, 20);
            this.txtBranch.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 286);
            this.Controls.Add(this.btnSwitchForm2);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lstBranches);
            this.Controls.Add(this.btnBranchAdd);
            this.Controls.Add(this.txtBranch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchForm2;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ListBox lstBranches;
        private System.Windows.Forms.Button btnBranchAdd;
        private System.Windows.Forms.TextBox txtBranch;
    }
}

