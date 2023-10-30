using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Patient : BaseEntity
    {
        public Patient()
        {
            Appointments = new List<Appointment>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual List<Appointment> Appointments { get; set; }

        public string GetPatientsInfo()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
