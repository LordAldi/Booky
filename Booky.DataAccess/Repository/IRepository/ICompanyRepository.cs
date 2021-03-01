using Booky.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booky.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company company);
    }
}
