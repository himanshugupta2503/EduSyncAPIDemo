using System.ComponentModel.DataAnnotations;

namespace EduSyncAPIDemo.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required, MaxLength(100)]
        public string CourseName { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        public ICollection<Assessment> Assessments { get; set; }
    }
}
