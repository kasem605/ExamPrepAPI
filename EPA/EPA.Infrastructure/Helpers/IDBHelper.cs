using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace EPA.Infrastructure.Helpers
{
    public interface IDBHelper
    {
        Task<DataSet> GetQuestionDataBySystemAsync(string storedProcedure, IList<OracleParameter> parameters);
    }
}
