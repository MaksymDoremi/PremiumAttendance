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

        /// <summary>
        /// Method used to insert new <see cref="PremiumAttendance.Objects.Employee"> into database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
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

    }
}
