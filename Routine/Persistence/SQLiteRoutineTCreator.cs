using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Routine.ViewModels.Interfaces;
using Routine.Models;

namespace Routine.Persistence
{
    public class SQLiteRoutineTCreator : IRoutineCreator
    {
        private SQLiteAsyncConnection _connection;
        public SQLiteRoutineTCreator(ISQLiteDb db)
        {
            _connection = db.GetConnection();
            _connection.CreateTableAsync<RoutineT>();
        }
        public async Task<IEnumerable<RoutineT>> GetRoutineTsAsync()
        {
            return await _connection.Table<RoutineT>().ToListAsync();
        }
        public async Task DeleteRoutineT(RoutineT routineT)
        {
            await _connection.DeleteAsync(routineT);
        }
        public async Task AddRoutineT(RoutineT routineT)
        {
            await _connection.InsertAsync(routineT);
        }
        public async Task UpdateRoutineT(RoutineT routineT)
        {
            await _connection.UpdateAsync(routineT);
        }
        public async Task<RoutineT> GetRoutineT(int id)
        {
            return await _connection.FindAsync<RoutineT>(id);
        }
    }
}
