using PremiumAttendance.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance.Objects
{
    public class DataAccessLayer
    {
        #region SQL commands
        #region CREATE
        #endregion
        #region RETRIEVE
        private const string LOGIN = "select * from Employee where [Login]=@login and [Password]=@password";
        public const string GET_CURRENT_USER = "select Employee.ID, Employee.RFID_Tag, Employee_Role.Role_name, Employee.Login, Employee.Name, Employee.Surname, Employee.Photo, Employee.Email, Employee.Phone from Employee inner join Employee_Role on Employee.Employee_Role_ID = Employee_Role.ID where Login=@login";
        #endregion
        #region UPDATE
        #endregion
        #region DELETE
        #endregion
        #endregion


        #region CREATE
        #endregion
        #region RETRIEVE
        public bool Login(string login, string password)
        {


            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(LOGIN, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();


                    if (!reader.HasRows)
                    {
                        return false;
                    }
                }
                DatabaseConnection.GetConnection().Close();

                return true;
            }
            catch (Exception ex)
            {
                DatabaseConnection.GetConnection().Close();
                throw ex;
            }
        }

        public Employee GetCurrentUser(string login)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(GET_CURRENT_USER, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@login", login);

                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    if (!reader.HasRows) return null;

                    Employee user = new Employee((int)reader[0],
                        reader[1] == DBNull.Value ? "" : (string)reader[1],
                        (string)reader[2],
                        (string)reader[3],
                        (string)reader[4],
                        (string)reader[5],
                        reader[6] == DBNull.Value ? null : (byte[])reader[6],
                        reader[7] == DBNull.Value ? "" : (string)reader[7],
                        reader[8] == DBNull.Value ? "" : (string)reader[8]);

                    DatabaseConnection.GetConnection().Close();

                    return user;

                }

            }
            catch (Exception ex)
            {
                DatabaseConnection.GetConnection().Close();
                throw ex;
            }
        }
        #endregion
        #region UPDATE
        #endregion
        #region DELETE
        #endregion
    }
}
