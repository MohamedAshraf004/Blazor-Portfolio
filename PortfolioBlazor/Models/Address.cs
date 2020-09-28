using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBlazor.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Code { get; set; }
        public string Region { get; set; }

        public User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}