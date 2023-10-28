using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext : DbContext // Entity framework sayesinde Dbcontext'den miras alabiliyoruz bu sayede Mycontext classımızı  bir veri tabanı sınıfı yapmış oluyoruz.
    {
        public MyContext():base("MyConnection") //Construcktor'da Miras aldıgımız yerden  her zaman parametresiz ctorunu alır parametreli ctoru almak için base keywordunu kullanırız  ve içinde  adresi belirtmemiz lazım... Ui kısmının appconfiginde olusturdugumuz Myconnection isminin temsil ettiği adrese ulasmamızı saglar yani server'a...
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)//ovveride yaptıgımızda ise bütün ayarlalarımız MAP classında yapıldıgı için  classların  contructırları calısıp ayarların tetiklenmesi için modelbuilder dan  MAP classmanında olusturulan  classları instance'ını alıyoruz.
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AppointmentMap());
            modelBuilder.Configurations.Add(new BranchMap());
            modelBuilder.Configurations.Add(new PatientMap());
            modelBuilder.Configurations.Add(new DoctorMap());
            modelBuilder.Configurations.Add(new DoctorBranchMap());

        }
        //Sql tablo olarak anlatabilecek tek koleksiyon tipi dbset'dir... Yani Dbset bir tablo koleksiyon tipidir ... Olusturdugumuz classların Property ismini vererek  Tabloları olustuyor veritabanımızın  herhangi isimde  bir tablosu oldugunu  soyluyoruz.

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorBranch> DoctorBranches { get; set; }


        //Package menager console da  default projeyi DAL yapmamız önemlidir.Çünkü Veritabanınız ile haberlesecek ve veritabanınızın olusmasını saglayacak katmandır
    }
}
