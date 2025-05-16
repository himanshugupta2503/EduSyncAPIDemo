using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduSyncAPIDemo.Models
{
    public class Assessment
    {
        [Key]
        public int AssessmentId { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public Course Course { get; set; }

        public ICollection<Result> Results { get; set; }
    }
}
