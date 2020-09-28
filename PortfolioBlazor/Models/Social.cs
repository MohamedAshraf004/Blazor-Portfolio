using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBlazor.Models
{
    public class Social
    {
        public int SocialId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Url)]
        public string SocialUrl { get; set; }
        public string Class { get; set; }
        public string FontAweSome { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }
    }
}