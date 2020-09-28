using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioBlazor.Models
{
    public class Honors
    {
        [Key]
        public int HonorId { get; set; }
        public string Descriprion { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }
        public string Media { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}