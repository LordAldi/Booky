using Booky.DataAccess.Data;
using Booky.DataAccess.Repository.IRepository;
using Booky.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Booky.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            var objFromDb = _db.Companies.FirstOrDefault(s => s.Id == company.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = company.Name;
                objFromDb.StreetAddress = company.StreetAddress;
                objFromDb.State = company.State;
                objFromDb.PostalCode = company.PostalCode;
                objFromDb.PhoneNumber = company.PhoneNumber;
                objFromDb.IsAuthorizedCompany = company.IsAuthorizedCompany;
                objFromDb.City = company.City;
            }
            
        }
    }
}
