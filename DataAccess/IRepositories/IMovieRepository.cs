using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace DataAccess.IRepositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        List<Movie> GetMoviesByGenre(int genreId);
        List<Movie> GetByYear(int date);

    }
}
