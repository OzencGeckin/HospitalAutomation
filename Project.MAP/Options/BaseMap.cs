using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public abstract class BaseMap<T> :EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap() //Ayarlamalarin yapildigi siniftir.Entitiesten referance alıyoruz ,context sinifi olmaz.EF yuklenir.Generic parantezler classin gorevi neyse cagrildigi yere göre calisir.Base map sinifinda miras veren sinifi aciyoruz.Tetıklemek ıcınde ctor aciyoruz.
        {
            Property(x => x.CreatedDate).HasColumnName("Yaratilma Tarihi");
            Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
            Property(x => x.ModifiedDate).HasColumnName("Guncellenme Tarihi");
            Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }
}
