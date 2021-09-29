using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface ICinemaRepository : IRepository<Cinema>
    {
        List<Cinema> GetCinemasByCity(int cityId);
    }
}
