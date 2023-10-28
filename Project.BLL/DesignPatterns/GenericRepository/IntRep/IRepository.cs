using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T:BaseEntity
    {
        //T : class demektir. T BaseEntityde hangi claasta çağrılırsa artık o olacaktır. 

       //listeleme komutlarımızdır.
        List<T> GetActives(); // T artık hangi yapıdaysa o yapıdaki bütün verileri getirecektir.
        List<T> GetPassives();// T neyse sadece aktif kullanımda olan verileri getirecektir
        List<T> GetModifieds();// Pasif olan verileri getiriecektir
        List<T> GetAll(); // bu metodmuz ise sadece güncellenmiş verilerimizi getirecektir.


        //Değişiklik yapma komutlarımız
        void Add(T item); 
        void AddRange(List<T> list); //Liste olarak ekleme işlemi yapar
        void Update(T item);
        void UpdateRange(List<T> list);
        void Delete(T item); //veri bizim için çok kıymetlidir bu metodla o an veri işimize yaramıyorsa kullanılmıyorsa paisfe çekeriz.
        void DeleteRange(List<T> list);
        void Destroy(T item); //burda ise veri pasife çekilmez yok edilir.
        void DestroyRange(List<T> list);


        //Linq Commands
        List<T> Where(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);


        //Find
        T Find(int id); //PK sütun üzerinde  arama yapar.

        //Get Last Datas
        List<T> GetLastDatas(int count = 1);

        //Get First Datas
        List<T> GetFirstDatas(int count = 1);

        //Get Datas
        List<T> GetDatas(int count = 1);


    }
}
