using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Routine.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
