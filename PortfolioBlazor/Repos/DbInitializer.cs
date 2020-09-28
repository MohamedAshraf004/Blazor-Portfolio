using Microsoft.EntityFrameworkCore;
using PortfolioBlazor.Data;
using PortfolioBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioBlazor.Repos
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _dbContext;

        public DbInitializer(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task InitiateAsync()
        {
            try
            {
                if (_dbContext.Database.GetPendingMigrations().Count() > 0)
                {
                    _dbContext.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                if (_dbContext.PortfolioUsers.Any())
                {
                    return;
                }
                var user = new User()
                {

                    Name = "Mohamed Ashraf",
                    Email = "MohamedAshraf1811@outlook.com",
                    Freelance = Freelance.Available,
                    Faculty = "Faculty of Computer and Information Science",
                    University = "Mansoura University",
                    Degree = Degree.Bachelor,
                    JobTitle = ".Net Developer",
                    About = "Seeking to get opportunity as .Net developer in a company" +
                            " where I can develop my skills and enhance " +
                            "my experience.",
                    Birthdate = new DateTime(1997, 11, 18),
                    Image = "assets/img/profile-img.jpg",
                    Website = "www.github.com/mohamedashraf004",
                    Descreption = "Mohamed Ashraf graduated from FCIS MU. ",
                    Resume = "Mohamed Ashraf.pdf",
                    Address = new List<Address>()
                 {
                     new Address()
                     {
                         City="Mansoura",
                         Country="Egypt",
                         Code="22458",
                         Region="Nabarouh"
                     }
                 },
                    Phones = new List<Phone>()
                 {
                     new Phone()
                     {
                         PhoneNumber="+201201339358"
                     },
                     new Phone()
                     {
                         PhoneNumber="+201557033852"
                     }
                 },
                    Languages = new List<Language>
                 {
                     new Language
                     {
                         LanguageName="Arabic",
                         LanguageLevel=LanguageLevel.Perfect,
                     },
                      new Language
                       {
                         LanguageName="English",
                         LanguageLevel=LanguageLevel.VeryGood,
                       }
                     },
                    Socials = new List<Social>
                     {
                         new Social
                         {
                             Class="twitter",
                             FontAweSome="bx bxl-twitter",
                             SocialUrl="https://twitter.com/MohAshraf1811",
                             Name="Twitter"
                         },
                         new Social
                         {
                             Class="facebook",
                             FontAweSome="bx bxl-facebook",
                             SocialUrl="https://www.facebook.com/lionel.mido.376/",
                             Name="Facebook"
                         },
                         new Social
                         {
                             Class="instagram",
                             FontAweSome="bx bxl-instagram",
                             SocialUrl="https://www.instagram.com/mohamed_ashraf1811/",
                             Name="Instagram"
                         },new Social
                         {
                             Class="linkedin",
                             FontAweSome="bx bxl-linkedin",
                             SocialUrl="https://www.linkedin.com/in/mohamedashraf1811/",
                             Name="linkedin"
                         },new Social
                         {
                             Class="github",
                             FontAweSome="bx bxl-github",
                             SocialUrl="https://github.com/MohamedAshraf004",
                             Name="Github"
                         }
                     },
                    Projects = new List<Project>
                    {
                        new Project
                        {
                            Name="Spicy App",
                            Image="assets/img/spicyapp.jpg",
                            Website="",
                            Github="https://github.com/MohamedAshraf004/StudentApp-",
                            Description="SPICY APPLICATION BUILT WITH ASP.NET CORE"
                        },
                        new Project
                        {
                            Name="TAVSS Student App",
                            Image="assets/img/spicyapp.jpg",
                            Website="https://spiceapp20200925143058.azurewebsites.net/",
                            Github="https://github.com/MohamedAshraf004/Tavss-student-app",
                            Description="TAVSS Student APPLICATION BUILT WITH ASP.NET CORE and Blazor server"
                        }
                    },
                    Skills = new List<Skills>
                    {
                        new Models.Skills
                        {
                            Title = "C#",
                            Level = 90,
                            SkillPriority = 1,
                            SkillType = SkillType.Programming


                        },
                        new Models.Skills
                        {
                            Title = ".Net Core",
                            Level = 80,
                            SkillPriority = 1,
                            SkillType = SkillType.Programming


                        },new Models.Skills
                        {
                            Title = "Blazor",
                            Level = 90,
                            SkillPriority = 1,
                            SkillType = SkillType.Programming


                        },new Models.Skills
                        {
                            Title = "Javascript",
                            Level = 70,
                            SkillPriority = 2,
                            SkillType = SkillType.Programming


                        },new Models.Skills
                        {
                            Title = "Web Api",
                            Level = 85,
                            SkillPriority = 2,
                            SkillType = SkillType.Programming


                        },
                    },
                    Internships = new List<Internship>
                    {
                        new Internship
                        {
                            Title="Trainee, .Net Web Development",
                            Description="• Learned how to development web sites."+
                                        "• Learned C#, Sql Server, EF, LINQ, ASP .Net MVC."+
                                        "• Implemented project in the end of training with my team.",
                            Location="Information Technology Institute ITI-Mansoura branch, Mansoura, Egypt",
                            StartDate=new DateTime(2019,7,1),
                            EndDate=new DateTime(2019,9,27)
                        }
                    },
                    Honors = new List<Honors>
                    {
                        new Honors
                        {
                            Descriprion= "The Best Goalkeeper in Mansoura University",
                            Media="goalkeeper.mp4",
                            DateTime = new DateTime(2017, 8, 15)
                        },
                        new Honors
                        {
                            Descriprion= "Won the second place in Fourth Forum for Information Technology Developers,"+
                                        "Mansoura University",
                            DateTime = new DateTime(2017, 8, 15)
                        }
                    }


                };

                _dbContext.PortfolioUsers.AddAsync(user).GetAwaiter().GetResult();
                //_dbContext.Honors.AddAsync(new Models.Honors
                //{
                //    Descriprion = "The Best Goalkeeper in Mansoura University",
                //    Media = "goalkeeper.mp4",
                //    DateTime = new DateTime(2017, 8, 15),
                //    UserId = 3
                //}).GetAwaiter().GetResult();

                //_dbContext.PortfolioUsers.Update(user);
                if (await _dbContext.SaveChangesAsync() > 0)
                {
                    Console.WriteLine("Db Effected");
                }
                else
                {
                    Console.WriteLine("Db Not Effected");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Db Not Effected" + ex.Message);
                throw;
            }

        }
    }
}
