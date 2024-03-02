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
using System.Data.SqlTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.InteropServices;

namespace PremiumAttendance.Objects
{
    public class DataAccessLayer
    {
        #region CREATE
        /// <summary>
        /// Sends notification to all employees
        /// </summary>
        /// <param name="authorEmployeeID"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <returns>True if success</returns>
        public bool SendNotification(int authorEmployeeID, string title, string content)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "insert into System_Message(Author_Employee_ID,Title, Content, Date_of_delivery)\r\nvalues(@employeeID,@title,@content, CURRENT_TIMESTAMP)";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@employeeID", authorEmployeeID);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@content", content);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }

        public bool CreateEmployee(Employee employee)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "insert into Employee(RFID_Tag, Employee_Role_ID, Login, Password, Name, Surname, Email, Phone, Photo) values(@rfid_tag, @role_id, @login, @password, @name, @surname, @email, @phone, @photo)";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@rfid_tag", employee.Rfid_tag);
                    cmd.Parameters.AddWithValue("@role_id", employee.RoleID);
                    cmd.Parameters.AddWithValue("@login", employee.Login);
                    cmd.Parameters.AddWithValue("@password", employee.Password);
                    cmd.Parameters.AddWithValue("@name", employee.Name);
                    cmd.Parameters.AddWithValue("@surname", employee.Surname);
                    cmd.Parameters.AddWithValue("@email", employee.Email);
                    cmd.Parameters.AddWithValue("@phone", employee.Phone);
                    cmd.Parameters.AddWithValue("@photo", employee.Photo);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }

        public void InsertAttendance(string rfidTag)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string insertAttendanceQuery = "insert into Attendance(Employee_ID, Datetime_of_entry, Type_of_entry) values((select Employee.ID from Employee where Employee.RFID_Tag = @rfidTag),CURRENT_TIMESTAMP,@type)";
                string getAttendanceType = "select top 1 Attendance.Type_of_entry from Attendance where Attendance.Employee_ID = (select Employee.ID from Employee where Employee.RFID_Tag = @rfidTag) order by Attendance.Datetime_of_entry desc";
                using (SqlCommand cmd = new SqlCommand(insertAttendanceQuery, DatabaseConnection.GetConnection()))
                {
                    // 0 check out, 1 check in
                    int type = 0;
                    using (SqlCommand subSelect = new SqlCommand(getAttendanceType, DatabaseConnection.GetConnection()))
                    {
                        subSelect.Parameters.AddWithValue("@rfidTag", rfidTag);
                        SqlDataReader reader = subSelect.ExecuteReader();
                        reader.Read();

                        if (reader.HasRows)
                        {

                            type = Convert.ToInt32(reader[0]);
                        }

                        reader.Close();
                    }
                    cmd.Parameters.AddWithValue("@rfidTag", rfidTag);
                    cmd.Parameters.AddWithValue("@type", type == 0 ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }
        #endregion
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
        #endregion
        #region UPDATE
        /// <summary>
        /// Update <see cref="PremiumAttendance.Objects.Employee"/> attributes
        /// </summary>
        /// <param name="userInstance"></param>
        /// <returns>True if success</returns>
        public bool UpdateEmployee(Employee userInstance)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "update [Employee] set RFID_Tag = @rfidTag, Name = @name, Surname = @surname, Photo = @photo, Email = @email, Phone = @phone where [Employee].ID = @employeeID";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@employeeID", userInstance.Id);

                    cmd.Parameters.AddWithValue("@rfidTag", String.IsNullOrEmpty(userInstance.Rfid_tag) ? DBNull.Value : (object)userInstance.Rfid_tag);

                    cmd.Parameters.AddWithValue("@name", userInstance.Name);

                    cmd.Parameters.AddWithValue("@surname", userInstance.Surname);

                    cmd.Parameters.AddWithValue("@photo", userInstance.Photo == null ? SqlBinary.Null : userInstance.Photo);

                    cmd.Parameters.AddWithValue("@email", String.IsNullOrEmpty(userInstance.Email) ? DBNull.Value : (object)userInstance.Email);

                    cmd.Parameters.AddWithValue("@phone", String.IsNullOrEmpty(userInstance.Phone) ? DBNull.Value : (object)userInstance.Phone);

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }

        /// <summary>
        /// Updates old password. Checks for old password correctness
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns>True if success</returns>
        public bool UpdatePassword(int employeeID, string oldPassword, string newPassword)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "select Employee.Password from Employee where Employee.ID = @employeeID";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    //check for old password
                    if (Program.ComputeSHA256(oldPassword) != (string)reader[0])
                    {
                        reader.Close();

                        throw new Exception("Old password is incorrect");
                    }
                    reader.Close();
                }

                query = "update [Employee] set Password = @newPassword where ID = @employeeID";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    cmd.Parameters.AddWithValue("@newPassword", Program.ComputeSHA256(newPassword));

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }

        /// <summary>
        /// Mark message as read
        /// </summary>
        /// <param name="haveReadID"></param>
        /// <returns>True if success</returns>
        public bool MarkAsRead(int haveReadID)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed) { DatabaseConnection.GetConnection().Open(); }

            try
            {
                string query = "update Have_Read\r\nset Is_Read = 1\r\nwhere ID = @haveReadID";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@haveReadID", haveReadID);

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex) { throw ex; }
            finally { DatabaseConnection.GetConnection().Close(); }
        }
        #endregion
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
