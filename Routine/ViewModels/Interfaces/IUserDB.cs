using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Routine.Models;

namespace Routine.ViewModels.Interfaces
{
    public interface IUserDB
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUser(int id);
        Task AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(User user);
    }
}
