using JwtApiSimple.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApiSimple.Helpers
{
    public class DbHelper : IDbHelper
    {
        private readonly AppSettings _appSettings;
        public DbHelper(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public bool ExecuteProcedure(string procName)
        {
            throw new NotImplementedException();
        }

        public bool ExecuteProcedure(string procName, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public SqlDataReader ExecuteReader(string procName)
        {
            throw new NotImplementedException();
        }

        public SqlDataReader ExecuteReader(string procName, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
