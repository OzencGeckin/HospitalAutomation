using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.ContextClasses;
namespace Project.BLL.DesignPatterns.SingletonPattern
{
    //SingletonPattern : veritabanını sürekli olarak instance oluşturmak hem güvenlik hem de kalite açısından doğru değildir. Singleton Pattern ise sürekli instance oluşturmayı engellemek ve burda oluşturlan instanceyi kullanmamızı sağlar.
    public class DBTool
    {
        DBTool() { } 
        static MyContext _dbInstance;

        public static MyContext DBInstance //sürekli insatnce oluştrulmasını engelllemyi de encapsülation (gette uygulayarak) yapar.
        {
            get
            {
                if (_dbInstance == null) { _dbInstance = new MyContext(); }
                return _dbInstance;
            }
        }

    }
}
