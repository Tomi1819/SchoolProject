using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public  string TeacherName { get; set; }
        public List<Student> Students { get; set; }

    }
}
