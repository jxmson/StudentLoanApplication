using StudentLoan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class GenderRepository : RepositoryBase<Gender>, IGenderRepository
    {
        public GenderRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {

        }
    }
}
