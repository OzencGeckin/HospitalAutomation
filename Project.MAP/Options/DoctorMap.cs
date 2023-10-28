using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class DoctorMap:BaseMap<Doctor>
    {
        public DoctorMap() 
        {
            ToTable("Doktorlar");
            Property(x => x.FirstName).HasColumnName("Isim").IsRequired();
            Property(x => x.LastName).HasColumnName("SoyIsim").IsRequired(); 
        
        }
    }
}
