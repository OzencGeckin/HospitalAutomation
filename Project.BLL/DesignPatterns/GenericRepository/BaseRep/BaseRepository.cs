using Project.BLL.DesignPatterns.GenericRepository.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.BaseRep
{ 
    //Bu BaseRepository classı miras vermek için oluşturulmuştur. Tek görevi miras vermek oldğu için abstract  class yapılmıştır.

    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity //miras veridiği yerde bir entity(class) istiyor. Miras verildiği yerde içindeki metodlar çalışacaktır.
    {
        MyContext _db; //DataBase erişip işlem yapmak için MyContext classına eriştim.Burada kullanmak için _db ismini verdim.

        public BaseRepository() //burada bu classa erişildiği anda çalışmasını isteiğim kodları yazmak için constractor oluşturdum.
        {
            _db = DBTool.DBInstance; //dbTool da DizaynPatenlerinde SingletonPatteni kullanarak encapsülation yöntemi ile veritabanımızın tekrar tekrar instance alınmasını engellyip var olanın kullanılmasını sağlamıştık. burda da yeniden instance almayıp(engellendiği için zaten alamayız) var olan instanceyi _db ye atadık.
        }

        //Aşağıdaki tüm metodlara bu classı miras alan tüm entittyler erişip işlem yapabilecek.
        void Save()
        {
            _db.SaveChanges();
        }


        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            Save();
        }

        public void AddRange(List<T> list) //Toplu veri eklemek için bu metodumuzu kullanabiliriz.
        {
            _db.Set<T>().AddRange(list);
            Save(); //Save yani kaydet metodu yapılan her veri değişikliği sonunda kullanılmak zorundadır.

        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp); //veri kontrol etme metodudur. Bu metod veya listeleme durumlarında veride bir değişiklik yapılmadığı için save kullanılmamıştır
        }

        public void Delete(T item)
        {
            item.DeletedDate = DateTime.Now;
            item.Status = ENTITIES.Enums.DataStatus.Deleted;
            Save();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (T item in list) Delete(item);
            Save();
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);
            Save();
        }

        public void DestroyRange(List<T> list)
        {
            _db.Set<T>().RemoveRange(list); 
            Save();
        }

        public T Find(int id) //tek kayıt döndürür list olarak döndürmez. PK ya göre filtreleme yapar
        {
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp) //tek bir kayıt getir demektir.
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {

            return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted); //Kayıtların statüleri benim enumdaki statulerimden Silinmiş olana eşit olmayanları yani aktif durumda olanları getir.
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetDatas(int count = 1)
        {
            return _db.Set<T>().Take(count).ToList();
        }

        public List<T> GetFirstDatas(int count = 1)
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).ToList();
        }

        public List<T> GetLastDatas(int count = 1)
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).ToList();

        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);

        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp) //veri getirirken sadece istediğimiz bilgilerini seçmemiz için kullanılır.
        {
            return _db.Set<T>().Select(exp);
        }

        public void Update(T item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            T originalData = Find(item.ID);
            _db.Entry(originalData).CurrentValues.SetValues(item); //_db Entry metodunu kullanarak kaydetme işleminden önce bir değişiklik yapıldığını belirtir 
            Save();
        }

        public void UpdateRange(List<T> list)
        {
            foreach (T item in list) Update(item);
        }

        public List<T> Where(Expression<Func<T, bool>> exp) //çağrıldığı yerde verilen parametrelere göre filtereleme işlemi yapacaktır.
        {



            return _db.Set<T>().Where(exp).ToList();
        }





    }
}
