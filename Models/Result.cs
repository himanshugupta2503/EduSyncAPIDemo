using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduSyncAPIDemo.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Assessment")]
        public int AssessmentId { get; set; }

        public double Score { get; set; }

        public User User { get; set; }
        public Assessment Assessment { get; set; }
    }
}
