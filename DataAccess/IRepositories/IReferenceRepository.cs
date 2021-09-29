using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IReferenceRepository : IRepository<Reference>
    {
        List<Reference> GetByReferenceType(int referenceTypeId);
        List<Reference> GetByCodeAndReferenceType(string referenceCode, int referenceTypeId);
    }
}
