using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using SQLite;
using GlowOn.Models;
using GlowOn.ViewModels.Interfaces;

namespace GlowOn.DBServices
{
    public class SQLiteUsers : IUsers
    {
        private SQLiteAsyncConnection _connection;
        public SQLiteUsers(ISQLiteDb db)
        {
            _connection = db.GetConnection();
            _connection.CreateTableAsync<User>();
        }
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _connection.Table<User>().ToListAsync();
        }
        public async Task<int> DeleteUsersAsync()
        {
            return await _connection.DeleteAllAsync<User>();
        }
        public async Task AddUser(User routineUser)
        {
            await _connection.InsertAsync(routineUser);
        }
        public async Task<User> GetUser(int id)
        {
            return await _connection.FindAsync<User>(id);
        }
        public async Task UpdateUser(User user)
        {
            await _connection.UpdateAsync(user);
        }
    }
}
