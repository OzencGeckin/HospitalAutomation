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

namespace Project.WinUI
{
    public partial class Form2 : Form
    {
        MyContext _db;
        public Form2()
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
        }
        public Form2(ListBox.ObjectCollection branches)
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
            foreach (Branch item in branches)
            {
                cmbBranch.Items.Add(item.BranchName);
                bRaNcHes = branches;
            }
        }
        ListBox.ObjectCollection bRaNcHes;
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDoctorAdd_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            DoctorBranch doctorBranch = new DoctorBranch();
            doctor.FirstName = txtDFirstName.Text;
            doctor.LastName = txtDLastName.Text;
            doctorBranch.Doctor = doctor;
            doctorBranch.Branch = cmbBranch.SelectedItem as Branch;
            lstDoctors.Items.Add(doctor);
        }

        private void lstDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoctors.SelectedItem != null)
            {
                lblDoctor.Text = (lstDoctors.SelectedItem as Doctor).GetDoctorsInfo();
            }
        }

        private void btnSwitchForm3_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form3 = new Form3(bRaNcHes as ListBox.ObjectCollection, lstDoctors.Items as ListBox.ObjectCollection);
            form3.ShowDialog();
        }
    }
}