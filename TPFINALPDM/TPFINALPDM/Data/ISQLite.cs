using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TPFINALPDM.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConexao();
    }
}
