using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPSQL.DataLayer
{
    public interface IDataAccess
    {
        // transaction capable methods, last three parameters of Sqlonnection,
        //SqlTransaction are optional
        object GetSingleAnswer(string sql, List<DbParameter> PList, DbConnection conn =
       null, DbTransaction sqtr = null, bool bTransaction = false);
        DataTable GetManyRowsCols(string sql, List<DbParameter> PList, DbConnection conn
       = null, DbTransaction sqtr = null, bool bTransaction = false);
        int InsertUpdateDelete(string sql, List<DbParameter> PList, DbConnection conn =
       null, DbTransaction sqtr = null, bool bTransaction = false);
    }
}
