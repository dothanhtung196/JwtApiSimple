using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApiSimple.Helpers
{
    interface IDbHelper
    {
        void Connect();
        bool ExecuteProcedure(string procName);
        bool ExecuteProcedure(string procName, SqlParameter[] parameters);
        SqlDataReader ExecuteReader(string procName);
        SqlDataReader ExecuteReader(string procName, SqlParameter[] parameters);
        void Close();
    }
}
