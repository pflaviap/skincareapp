using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GlowOn.DBServices
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
