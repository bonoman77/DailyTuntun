using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace DailyTuntun.DbConns
{
    public class DapperORM
    {
        private static string connectionString = @"data source=121.254.129.200;initial catalog=memberbiz;user id=tuntunplay;password=#ZKYeZ=0peq&";

        public static void ExecuteWithoutReturn(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        // DapperORM.ExecuteReturnScalar<int>(_,_); 
        public static T ExecuteReturn<T>(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        // DapperORM.ExecuteReturnScalar<int>(_,_); 
        public static T ExecuteReturnScalar<T>(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.Execute(procedurename, param, commandType: System.Data.CommandType.StoredProcedure), typeof(T));
            }
        }

        // DapperORM.ReturnList<EmployeeModel> <= IEnumerble<EmployeeModel>     
        public static IEnumerable<T> ReturnList<T>(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
