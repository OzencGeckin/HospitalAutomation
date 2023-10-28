using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class BranchMap:BaseMap<Branch>
    {
        public BranchMap() 
        {
            ToTable("Branslar");
            Property(x => x.BranchName).HasColumnName("Brans İsmi").IsRequired();
        
        }
    }
}
