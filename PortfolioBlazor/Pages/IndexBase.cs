using Microsoft.AspNetCore.Components;
using PortfolioBlazor.Models;
using PortfolioBlazor.Repos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioBlazor.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public IUserRepository UserRepository { get; set; }

        public User User { get; set; }
        public List<Models.Skills> USkills { get; set; }
        protected async override Task OnInitializedAsync()
        {
            User = (await UserRepository.GetUsers()).FirstOrDefault();

        }

    }
}
