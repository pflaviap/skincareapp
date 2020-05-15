using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Routine.Models;
using Routine.ViewModels.Interfaces;

namespace Routine.Persistence
{
    public class SQLiteUserDB : IUserDB
    {
        private SQLiteAsyncConnection _connection;
        public SQLiteUserDB(ISQLiteDb db)
        {
            _connection = db.GetConnection();
            _connection.CreateTableAsync<User>();
        }
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _connection.Table<User>().ToListAsync();
        }

        public async Task DeleteUser(User user)
        {
            await _connection.DeleteAsync(user);
        }
        public async Task AddUser(User user)
        {
            await _connection.InsertAsync(user);
        }
        public async Task UpdateUser(User user)
        {
            await _connection.UpdateAsync(user);
        }
        public async Task<User> GetUser(int id)
        {
            return await _connection.FindAsync<User>(id);
        }
    }
}
