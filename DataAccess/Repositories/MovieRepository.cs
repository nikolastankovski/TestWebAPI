using DataAccess.IRepositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public Movie Add(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Movie Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Movie Update(Movie entity)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetMoviesByGenre(int genreId)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetByYear(int date)
        {
            throw new NotImplementedException();
        }
    }
}
