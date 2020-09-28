using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBlazor.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}