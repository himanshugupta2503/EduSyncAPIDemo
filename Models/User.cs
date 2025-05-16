using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduSyncAPIDemo.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Role { get; set; }  // e.g., "Student", "Instructor"

        public ICollection<Result> Results { get; set; }
    }
}
