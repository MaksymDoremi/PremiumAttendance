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

namespace PremiumAttendance.Objects
{
    public class DataAccessLayer
    {
        #region SQL commands
        #region CREATE
        #endregion
        #region RETRIEVE
        private const string LOGIN = "select * from Employee where [Login]=@login and [Password]=@password";
        private const string GET_CURRENT_USER = "select Employee.ID, Employee.RFID_Tag, Employee_Role.Role_name, Employee.Login, Employee.Name, Employee.Surname, Employee.Photo, Employee.Email, Employee.Phone from Employee inner join Employee_Role on Employee.Employee_Role_ID = Employee_Role.ID where Login=@login";
        private const string GET_PASSWORD = "select Employee.Password from Employee where Employee.ID = @employeeID";
        #endregion
        #region UPDATE
        private const string UPDATE_USER = "update [Employee] set RFID_Tag = @rfidTag, Name = @name, Surname = @surname, Photo = @photo, Email = @email, Phone = @phone where [Employee].ID = @employeeID";
        private const string UPDATE_PASSWORD = "update [Employee] set Password = @newPassword where ID = @employeeID";
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
                        DatabaseConnection.GetConnection().Close();
                        reader.Close();
                        throw new Exception("Wrong login or password");
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
        public bool UpdateEmployee(Employee userInstance)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(UPDATE_USER, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@employeeID", userInstance.Id);

                    if (String.IsNullOrEmpty(userInstance.Rfid_tag))
                    {
                        cmd.Parameters.AddWithValue("@rfidTag", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@rfidTag", userInstance.Rfid_tag);
                    }
                    cmd.Parameters.AddWithValue("@name", userInstance.Name);
                    cmd.Parameters.AddWithValue("@surname", userInstance.Surname);
                    if (userInstance.Photo == null)
                    {
                        cmd.Parameters.AddWithValue("@photo", SqlBinary.Null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@photo", userInstance.Photo);
                    }

                    if (String.IsNullOrEmpty(userInstance.Email))
                    {
                        cmd.Parameters.AddWithValue("@email", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@email", userInstance.Email);
                    }

                    if (String.IsNullOrEmpty(userInstance.Phone))
                    {
                        cmd.Parameters.AddWithValue("@phone", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@phone", userInstance.Phone);
                    }


                    cmd.ExecuteNonQuery();
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

        public bool UpdatePassword(int employeeID, string oldPassword, string newPassword)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }

            try
            {

                using (SqlCommand cmd = new SqlCommand(GET_PASSWORD, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    //check for old password
                    if (Program.ComputeSHA256(oldPassword) != (string)reader[0])
                    {
                        reader.Close();
                        DatabaseConnection.GetConnection().Close();
                        throw new Exception("Old password is incorrect");
                        
                        
                    }
                    reader.Close();
                }

                using (SqlCommand cmd = new SqlCommand(UPDATE_PASSWORD, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    cmd.Parameters.AddWithValue("@newPassword", Program.ComputeSHA256(newPassword));


                    cmd.ExecuteNonQuery();
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
        #endregion
        #region DELETE
        #endregion
    }
}
