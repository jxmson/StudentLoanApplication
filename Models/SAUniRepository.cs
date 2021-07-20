using Microsoft.EntityFrameworkCore;
using StudentLoan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class SAUniRepository : RepositoryBase<SAUniversity>, ISAUniRepository
    {
        public SAUniRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {

        }


        public IEnumerable<SAUniCourse> GetVarsityCourseList(int id, string search)
        {
            IEnumerable<SAUniCourse> items = _appDbContext.SAUniCourses.Include(item => item.Course)
                .Where(u => u.SAUniversityId == id && u.Course.Field.Contains(search) || u.Course.Course.Contains(search))
                .ToList();
            return items;
        }        
    }
}
