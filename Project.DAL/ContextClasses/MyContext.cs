using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext():base("MyConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AppointmentMap());
            modelBuilder.Configurations.Add(new BranchMap());
            modelBuilder.Configurations.Add(new PatientMap());
            modelBuilder.Configurations.Add(new DoctorMap());
            modelBuilder.Configurations.Add(new DoctorBranchMap());

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorBranch> DoctorBranches { get; set; }

    }
}
