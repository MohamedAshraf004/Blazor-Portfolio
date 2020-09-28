using System.ComponentModel.DataAnnotations;

namespace PortfolioBlazor.Models
{
    public class Visitor
    {
        [Key]
        public int VisitorId { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(15)]
        public string Message { get; set; }
        [Required]
        [MinLength(10)]
        public string Subject { get; set; }
    }
}
