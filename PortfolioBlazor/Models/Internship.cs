using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBlazor.Models
{
    public class Internship
    {
        [Key]
        public int InternshipId { get; set; }

        [Required]
        public string Title { get; set; }
        [DataType(DataType.Date)]

        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]

        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}