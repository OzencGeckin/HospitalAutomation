using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Appointment : BaseEntity
    {
        public DateTime? AppointmentDate { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }

        //Relational Properties
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    
    }
}
