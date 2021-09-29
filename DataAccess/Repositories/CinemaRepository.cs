using DataAccess.IRepositories;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CinemaRepository : ICinemaRepository
    {
        private readonly TestAppDbContext _db;
        
        public CinemaRepository(TestAppDbContext db)
        {
            _db = db;
        }

        public Cinema Add(Cinema entity)
        {

            if (entity != null)
            {
                _db.Add(entity);
                _db.SaveChanges();
                return entity;
            }

            return entity;
        }

        public bool Delete(int id)
        {
            try
            {
                Cinema? model = _db.Cinemas.Where(x => x.CinemaId == id).FirstOrDefault();
                if(model != null)
                {
                    _db.Remove(model);
                    _db.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Cinema> GetAll()
        {
            var cinemas = _db.Cinemas.ToList();
            return cinemas;
        }

        public Cinema GetById(int id)
        {
            var cinema = _db.Cinemas.Where(x => x.CinemaId == id).FirstOrDefault();
            return cinema;
        }

        public List<Cinema> GetCinemasByCity(int cityId)
        {
            var cinemas = _db.Cinemas.Where(x => x.CityId == cityId).ToList();  
            return cinemas;
        }

        public bool Update(Cinema entity)
        {
            try
            {
                if (entity != null)
                {
                    _db.Update(entity);
                    _db.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
