using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using GlowOn.Models;

namespace GlowOn.ViewModels.Interfaces
{
    public interface IUsers
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task AddUser(User routineUser);
        Task<User> GetUser(int id);
        Task<int> DeleteUsersAsync();
    }
}
