using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        MyContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
        }
        
        private void btnBranchAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBranch.Text))
            {
                MessageBox.Show("Lütfen Branş giriniz.");
                return;
            }
            Branch branch = new Branch();
            branch.BranchName = txtBranch.Text;
            lstBranches.Items.Add(branch);
            _db.SaveChanges();
        }

        private void lstBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstBranches.SelectedIndex > -1)
            {
                lblBranch.Text = (lstBranches.SelectedItem as Branch).BranchName;
            }
        }

        private void btnSwitchForm2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2((ListBox.ObjectCollection)lstBranches.Items);
            form2.ShowDialog();
        }
    }
}
