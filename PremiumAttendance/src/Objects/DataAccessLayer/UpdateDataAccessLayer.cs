using PremiumAttendance.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumAttendance.Objects
{
    public partial class DataAccessLayer
    {
        #region UPDATE

        /// <summary>
        /// Updates <see cref="PremiumAttendance.Objects.Employee"/> attributes
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
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DatabaseConnection.GetConnection().Close();
            }
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
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DatabaseConnection.GetConnection().Close();
            }
        }

        /// <summary>
        /// Marks message as read
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
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DatabaseConnection.GetConnection().Close();
            }
        }
        #endregion
    }
}
