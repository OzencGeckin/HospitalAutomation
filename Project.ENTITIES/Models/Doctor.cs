using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Doctor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Relational Properties
        public virtual List<Appointment> Appointments { get; set; }
        public virtual List<DoctorBranch> DoctorBranches { get; set; }

        public string GetDoctorsInfo()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
