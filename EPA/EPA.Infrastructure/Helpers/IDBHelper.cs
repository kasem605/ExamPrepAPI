using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPA.Infrastructure.Helpers
{
    public interface IDBHelper
    {
        Task<DataSet> GetListDataAsync<T>(string sql, CommandType cmdType, );
    }
}
