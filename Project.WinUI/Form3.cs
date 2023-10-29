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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Project.WinUI
{
    public partial class Form3 : Form
    {
        MyContext _db;
        public Form3()
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
        }
        public Form3(ListBox.ObjectCollection branches, ListBox.ObjectCollection doctors)
        {
            InitializeComponent();
            foreach (ENTITIES.Models.Branch item in branches)
            {
                cmbBranch.Items.Add(item.BranchName);
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBranch.SelectedIndex > -1)
            {
                
                foreach (DoctorBranch item in (cmbBranch.SelectedItem as ENTITIES.Models.Branch).DoctorBranches)
                {
                    cmbDoctor.Items.Add(item.Doctor.GetDoctorsInfo());
                }
            }
        }
    }
}
