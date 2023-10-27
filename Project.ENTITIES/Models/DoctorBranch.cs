using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class DoctorBranch : BaseEntity
    {
        public int DoctorID { get; set; }
        public int BranchID { get; set; }
        //Relational Properties
        public virtual Doctor Doctor { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
