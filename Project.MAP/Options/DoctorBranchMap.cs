using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class DoctorBranchMap:BaseMap<DoctorBranch>
    {
        public DoctorBranchMap() 
        {
            ToTable("DoktorBranslari");
            Ignore (x=> x.ID); //Ignore edip anonymous type yapiyoruz.
            HasKey(x => new
            {
                x.BranchID,
                x.DoctorID
            });
        }
    }
}
