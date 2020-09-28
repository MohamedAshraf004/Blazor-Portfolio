using System.Threading.Tasks;

namespace PortfolioBlazor.Repos
{
    public interface IDbInitializer
    {
        Task InitiateAsync();
    }
}