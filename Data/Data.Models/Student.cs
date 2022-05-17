using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [MaxLength(50)]
        public string StudentName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public List<Course> StudentCourses { get; set; }
    }
}
