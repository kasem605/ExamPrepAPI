using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace EPA.Infrastructure.Helpers
{
    public class DBHelper : IDBHelper
    {
        private readonly Connectionstrings _connectionString;

        private readonly ILogger<DBHelper>   _iLogger;

        public DBHelper(string connectionString, ILogger<DBHelper> iLogger)
        {
            _connectionString = connectionString;
            _iLogger = iLogger;
        }

        public async Task<DataSet> GetQuestionDataBySystemAsync(string storedProcedure, IList<OracleParameter> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
