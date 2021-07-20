using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class SAUniversity
    {
        public int SAUniversityId { get; set; }
        [Required(ErrorMessage = "Enter a university name")]
        public string Name { get; set; }
    
        public virtual ICollection<SAUniCourse> UniCourses { get; set; }
    }
}
