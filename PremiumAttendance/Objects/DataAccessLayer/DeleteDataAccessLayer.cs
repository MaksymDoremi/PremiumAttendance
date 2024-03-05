using PremiumAttendance.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumAttendance.Objects
{
    public partial class DataAccessLayer
    {
        #region DELETE
        /// <summary>
        /// Deletes <see cref="PremiumAttendance.Objects.Employee"/> from database using its ID
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public bool DeleteEmployee(int employeeId)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "delete from Employee where ID = @employeeId";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

                    cmd.ExecuteNonQuery();
                }

                return true;

            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }
        #endregion
    }
}
