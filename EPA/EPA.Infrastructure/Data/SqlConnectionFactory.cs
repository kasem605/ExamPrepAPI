using Microsoft.Data.SqlClient;

namespace EPA.Infrastructure.Data
{
    public class SqlConnectionFactory
    {
        private readonly string _connectionString;
        private readonly int _commandTimeout;

        public SqlConnectionFactory(string connectionString, int commandTimeout)
        {
            _connectionString = connectionString;
            _commandTimeout = commandTimeout;
        }

        public SqlConnection Create()
        {
            return new SqlConnection(_connectionString);
        }

        public int CommandTimeout => _commandTimeout;
    }
}
