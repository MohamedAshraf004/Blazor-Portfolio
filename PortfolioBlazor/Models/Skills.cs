using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBlazor.Models
{
    public class Skills
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Range(40, 100)]
        public int Level { get; set; }
        public SkillType SkillType { get; set; }
        public int SkillPriority { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }
    }
}