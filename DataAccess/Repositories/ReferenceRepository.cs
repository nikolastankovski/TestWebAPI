using DataAccess.IRepositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ReferenceRepository : IReferenceRepository
    {
        public Reference Add(Reference entity)
        {
            throw new NotImplementedException();
        }

        public Reference Delete(Reference entity)
        {
            throw new NotImplementedException();
        }

        public List<Reference> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Reference> GetByCodeAndReferenceType(string referenceCode, int referenceTypeId)
        {
            throw new NotImplementedException();
        }

        public Reference GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reference> GetByReferenceType(int referenceTypeId)
        {
            throw new NotImplementedException();
        }

        public Reference Update(Reference entity)
        {
            throw new NotImplementedException();
        }
    }
}
