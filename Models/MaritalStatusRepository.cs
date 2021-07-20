using StudentLoan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class MaritalStatusRepository:RepositoryBase<MaritalStatus>, IMaritalStatusRepository
    {
        public MaritalStatusRepository(AppDbContext appDbContext)
            :base(appDbContext)
        {

        }
    }
}
