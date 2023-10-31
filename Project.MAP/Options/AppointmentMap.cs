using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppointmentMap:BaseMap<Appointment>
    {
        public AppointmentMap()
        {
            ToTable("Randevular");
            //Property(x => x.AppointmentDate).HasColumnName("Randevu Tarihi").IsRequired(); // IsRequired null gecilememesini sagliyoruz.
            Ignore(x => x.ID); //Ignore edip anonymous type yapiyoruz.
            HasKey(x => new
            {
                x.PatientID,
                x.DoctorID
            });
        }
    }
}
