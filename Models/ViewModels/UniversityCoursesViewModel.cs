using StudentLoan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.ViewModels
{
    public class UniversityCoursesViewModel
    {
        public IEnumerable<SAUniCourse> Items {get; set;}
        public SAUniversity SAUniversity { get; set; }
    }
}
