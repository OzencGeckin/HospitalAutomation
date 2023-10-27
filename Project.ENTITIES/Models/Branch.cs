using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Branch : BaseEntity
    {
        public string BranchName { get; set; }
        // Relational Properties 
        public virtual List<DoctorBranch> DoctorBranches { get; set; }
        
    }
}
