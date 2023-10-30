using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.BLL.DesignPatterns.SingletonPattern;
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
        DoctorRepository _doctorRepository;
        BranchRepository _brancRepository;
        DoctorBranchRepository _doctorBranchRepository;
        public Form2()
        {
            InitializeComponent();
            _brancRepository = new BranchRepository();
            _doctorRepository = new DoctorRepository();
            _doctorBranchRepository = new DoctorBranchRepository();
            cmbBranch.DataSource = _brancRepository.GetAll();
            cmbBranch.DisplayMember = "BranchName";
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
            _doctorRepository.Add(doctor);
            _doctorBranchRepository.Add(doctorBranch);
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
            
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}