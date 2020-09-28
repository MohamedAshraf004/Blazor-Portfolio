using Microsoft.EntityFrameworkCore;
using PortfolioBlazor.Data;
using PortfolioBlazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioBlazor.Repos
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var result = await _dbContext.PortfolioUsers.Include(a => a.Projects).Include(a => a.Address).
                Include(a => a.Socials).Include(a => a.Phones).Include(a => a.Languages)
                .Include(a => a.Internships).Include(a => a.Honors).Include(a => a.Skills).ToListAsync();
            return result;
        }
        public async Task<User> GetUser(int id)
        {
            return await _dbContext.PortfolioUsers.FirstOrDefaultAsync(u => u.UserId == id);

        }

        public async Task<User> UpdateUser(User updatedUser)
        {
            var user = _dbContext.PortfolioUsers.Attach(updatedUser);
            user.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return updatedUser;
        }
        public async Task<User> InsertUser(User insertedUser)
        {
            await _dbContext.PortfolioUsers.AddAsync(insertedUser);
            await _dbContext.SaveChangesAsync();
            return insertedUser;
        }
        public async Task<bool> DeleteUser(int id)
        {
            var user = await _dbContext.PortfolioUsers.FirstOrDefaultAsync(u => u.UserId == id);
            _dbContext.PortfolioUsers.Remove(user);
            return await _dbContext.SaveChangesAsync() > 0 ? true : false;
        }
    }
}
