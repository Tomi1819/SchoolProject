using System.ComponentModel.DataAnnotations;

namespace Data.Data.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        [MaxLength(50)]
        public string CourseName { get; set; }
        [Required]
        public int MaxCourseSize { get; set; }

    }
}