using PortfolioBlazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioBlazor.Repos
{
    public interface IUserRepository
    {
        Task<bool> DeleteUser(int id);
        Task<User> GetUser(int id);
        Task<IEnumerable<User>> GetUsers();
        Task<User> InsertUser(User insertedUser);
        Task<User> UpdateUser(User updatedUser);
    }
}