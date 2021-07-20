using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class SAUniCourseRepository : RepositoryBase<SAUniCourse>, ISAUniCourseRepository
    {
        public SAUniCourseRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {

        }
    }
}
