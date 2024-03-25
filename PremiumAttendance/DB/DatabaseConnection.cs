using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumAttendance.DB
{
    class DatabaseConnection
    {
        private DatabaseConnection() { }

        private static SqlConnection _connection = null;
        private static readonly object _lock = new object();

        /// <summary>
        /// Static method, returns current singleton connection
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                lock (_lock)
                {
                    if (_connection == null)
                    {
                        _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["remoteConnection"].ConnectionString);
                    }
                }
            }
            return _connection;
        }


    }

}
