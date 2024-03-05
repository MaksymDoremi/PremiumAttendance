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
        #region RETRIEVE
        /// <summary>
        /// Looks for login and password combination in database
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>True if login and password matches</returns>
        public bool Login(string login, string password)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "select * from Employee where [Login]=@login and [Password]=@password";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();


                    if (!reader.HasRows)
                    {
                        DatabaseConnection.GetConnection().Close();
                        reader.Close();
                        throw new Exception("Wrong login or password.\nTry again.");
                    }
                }

                return true;
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }

        /// <summary>
        /// Gets user by login from database
        /// </summary>
        /// <param name="login"></param>
        /// <returns>An instance of <see cref="PremiumAttendance.Objects.Employee"/> class</returns>
        public Employee GetCurrentUser(string login)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "select Employee.ID, Employee.RFID_Tag, Employee_Role.Role_name, Employee.Login, Employee.Name, Employee.Surname, Employee.Photo, Employee.Email, Employee.Phone from Employee inner join Employee_Role on Employee.Employee_Role_ID = Employee_Role.ID where Login=@login";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@login", login);

                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    if (!reader.HasRows) return null;

                    return new Employee((int)reader[0], reader[1] == DBNull.Value ? "" : (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5], reader[6] == DBNull.Value ? null : (byte[])reader[6], reader[7] == DBNull.Value ? "" : (string)reader[7], reader[8] == DBNull.Value ? "" : (string)reader[8]);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }

        /// <summary>
        /// Reads notifications for current employee
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns><see cref="System.Data.DataTable"/> of <see cref="PremiumAttendance.Objects.Notification"/> instances</returns>
        public DataTable GetNotifications(int employeeID)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "select mes.ID as 'Message_ID', hr.ID as 'Have_read_ID', hr.Is_Read, CONCAT(emp.Name,' ',emp.Surname) as 'Author_name', mes.Title, mes.Content, mes.Date_of_delivery\r\nfrom Employee emp join System_Message mes on emp.ID = mes.Author_Employee_ID\r\njoin Have_Read hr on hr.System_Message_ID = mes.ID where hr.Employee_ID = @employeeID";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        return dt;
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }

        /// <summary>
        /// <para>Gets <see cref="System.Data.DataTable"/> of <see cref="PremiumAttendance.Objects.Employee"/> in format</para> 
        /// ID, Name, Surname, RFID_Tag, Role_name, Login, Photo, Email, Phone
        /// </summary>
        /// <param name="currentEmployeeLogin"></param>
        /// <returns><see cref="System.Data.DataTable"/> of <see cref="PremiumAttendance.Objects.Employee"/>'s</returns>
        public DataTable GetEmployees(string currentEmployeeLogin)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "select Employee.ID, Employee.RFID_Tag, Employee.Name, Employee.Surname, Employee_Role.Role_name, Employee.Login, Employee.Password, Employee.Photo, Employee.Email, Employee.Phone from Employee join Employee_Role on Employee.Employee_Role_ID = Employee_Role.ID where Login != @currentEmployeeLogin";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@currentEmployeeLogin", currentEmployeeLogin);

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        return dt;
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }

        public DataTable GetEmployeeStatus(string currentEmployeeLogin)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "select SELECT a.Type_of_entry, a.Datetime_of_entry, e.Name, e.Surname \r\n\tFROM Attendance a \r\n\tJOIN (   \r\n\t\tSELECT Attendance.Employee_ID, MAX(Attendance.Datetime_of_entry) AS max_datetime   \r\n\t\tFROM Attendance GROUP BY Attendance.Employee_ID \r\n\t) \r\n\tb ON a.Employee_ID = b.Employee_ID AND a.Datetime_of_entry = b.max_datetime \r\n\tJOIN Employee e ON a.Employee_ID = e.ID where e.Login != @currentEmployeeLogin";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@currentEmployeeLogin", currentEmployeeLogin);

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        return dt;
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }
        #endregion
    }
}
