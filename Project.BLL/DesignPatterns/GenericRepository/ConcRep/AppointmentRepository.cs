using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    //buradaki classlarımızın hepsi BaseRepositoryden miras almıştır.
    public class AppointmentRepository : BaseRepository<Appointment>
    { 
    }
}
