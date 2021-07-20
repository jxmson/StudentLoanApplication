using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class SACourseRepository:RepositoryBase<SACourses>, ISACourseRepository
    {
        public SACourseRepository(AppDbContext appDbContext)
            :base(appDbContext)
        {

        }
    }
}
