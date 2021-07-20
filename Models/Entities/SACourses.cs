using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class SACourses
    {
        public int SACoursesId { get; set; }
        [Required(ErrorMessage="Enter a course field")]
        public string Field { get; set; }
        [Required(ErrorMessage = "Enter a course name")]
        public string Course { get; set; }
        [DisplayName("Undergraduate")]
        public bool Undergrad { get; set; }
        [DisplayName("Postgraduate")]
        public bool Postgrad { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Enter the cost of the course")]
        public decimal Cost { get; set; }
        public virtual ICollection<SAUniCourse> UniCourses { get; set; }

    }
}
