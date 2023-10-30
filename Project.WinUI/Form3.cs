using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch = Project.ENTITIES.Models.Branch;

namespace Project.WinUI
{
    public partial class Form3 : Form
    {
        DoctorRepository _doctorRepository;
        BranchRepository _brancRepository;
        PatientRepository _patientRepository;
        AppointmentRepository _appointmentRepository;
        public Form3()
        {
            InitializeComponent();
            _brancRepository = new BranchRepository();
            _doctorRepository = new DoctorRepository();
            _patientRepository = new PatientRepository();
            _appointmentRepository = new AppointmentRepository();
            cmbBranch.DataSource = _brancRepository.GetAll();
            cmbBranch.DisplayMember = "BranchName";
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        
        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBranch.SelectedIndex > -1)
            {
                Branch selectedBranch = cmbBranch.SelectedItem as Branch;
                List<Doctor> doctorsInBranch = new List<Doctor>();
                foreach (DoctorBranch item in selectedBranch.DoctorBranches)
                {
                    doctorsInBranch.Add(_doctorRepository.Find(item.DoctorID));
                }
                cmbDoctor.DataSource = doctorsInBranch;
                

            }
        }

        private void cmbDoctor_Format(object sender, ListControlConvertEventArgs e)
        {
            string fullName = $"{(e.ListItem as Doctor).FirstName} {(e.ListItem as Doctor).LastName}";
            e.Value = fullName;
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {


            Patient patient = new Patient();
            patient.FirstName = txtPFirstName.Text;
            patient.LastName = txtPLastName.Text;


            Appointment appointment = new Appointment();
            appointment.Patient = patient;
            appointment.Doctor = cmbDoctor.SelectedItem as Doctor;
            _appointmentRepository.Add(appointment);

            patient.Appointments.Add(appointment);

            lstPatients.Items.Add(patient);
            _patientRepository.Add(patient);




        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPatients.SelectedItems != null)
            {
                lblPatient.Text = (lstPatients.SelectedItem as Patient).GetPatientsInfo();
            }
        }
    }
}
