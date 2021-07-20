using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class SAUniCourse
    {
        [Key]
        [Column(Order = 1)]
        public int SACoursesId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int SAUniversityId { get; set; }

        public virtual SACourses Course { get; set; }
        public virtual SAUniversity University { get; set; }
    }
}
