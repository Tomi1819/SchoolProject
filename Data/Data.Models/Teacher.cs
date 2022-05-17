using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        [MaxLength(50)]
        public  string TeacherName { get; set; }
        [Required]
        public List<Student> Students { get; set; }

    }
}
