using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortfolioBlazor.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        public DateTime Birthdate { get; set; } = new DateTime(18 / 11 / 1997);

        public Degree Degree { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }

        public string Resume { get; set; }

        public List<Phone> Phones { get; set; }

        public List<Address> Address { get; set; }

        public Freelance Freelance { get; set; }


        [DataType(DataType.Url)]
        public string Website { get; set; }

        public string Image { get; set; }

        public string JobTitle { get; set; }
        public string Descreption { get; set; }
        public string About { get; set; }
        public string Fact { get; set; } = "Hard worker good and good learner.";

        public List<Social> Socials { get; set; }
        public List<Project> Projects { get; set; }
        public List<Skills> Skills { get; set; }
        public List<Language> Languages { get; set; }

        public List<Internship> Internships { get; set; }
        public List<Activites> Activites { get; set; }
        public List<Honors> Honors { get; set; }


    }
}
