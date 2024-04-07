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
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }

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
        /// Gets user by login from database
        /// </summary>
        /// <param name="login"></param>
        /// <returns>An instance of <see cref="PremiumAttendance.Objects.Employee"/> class</returns>
        public Employee GetCurrentUser(string login)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }

            try
            {
                string query = "select Employee.ID, Employee.RFID_Tag, Employee_Role.Role_name, Employee.Login, Employee.Name, Employee.Surname, Employee.Photo, Employee.Email, Employee.Phone from Employee inner join Employee_Role on Employee.Employee_Role_ID = Employee_Role.ID where Login=@login";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@login", login);

                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    if (!reader.HasRows) return null;

                    return new Employee(
                        (int)reader[0],
                        reader[1] == DBNull.Value ? "" : (string)reader[1],
                        (string)reader[2],
                        (string)reader[3],
                        (string)reader[4],
                        (string)reader[5],
                        reader[6] == DBNull.Value ? null : (byte[])reader[6],
                        reader[7] == DBNull.Value ? "" : (string)reader[7],
                        reader[8] == DBNull.Value ? "" : (string)reader[8]);
                }
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
        /// Reads notifications for current employee
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns><see cref="System.Data.DataTable"/> of <see cref="PremiumAttendance.Objects.Notification"/> instances</returns>
        public DataTable GetNotifications(int employeeID)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }

            try
            {
                string query = "select mes.ID as 'Message_ID', hr.ID as 'Have_read_ID', hr.Is_Read, CONCAT(emp.Name,' ',emp.Surname) as 'Author_name', mes.Title, mes.Content, mes.Date_of_delivery from Employee emp join System_Message mes on emp.ID = mes.Author_Employee_ID join Have_Read hr on hr.System_Message_ID = mes.ID where hr.Employee_ID = @employeeID";
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
        /// <para>Gets <see cref="System.Data.DataTable"/> of <see cref="PremiumAttendance.Objects.Employee"/> in format</para> 
        /// ID, Name, Surname, RFID_Tag, Role_name, Login, Photo, Email, Phone
        /// </summary>
        /// <param name="currentEmployeeLogin"></param>
        /// <returns><see cref="System.Data.DataTable"/> of <see cref="PremiumAttendance.Objects.Employee"/>'s</returns>
        public DataTable GetEmployees(string currentEmployeeLogin)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }

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
        /// Returns Employee status in format ID, Name, Surname, Type_of_entry, Datetime_of_entry      
        /// </summary>
        /// <param name="currentEmployeeLogin"></param>
        /// <returns><see cref="System.Data.DataTable"></returns>
        public DataTable GetEmployeeStatus(string currentEmployeeLogin)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }

            try
            {
                string query = "SELECT e.ID, e.Name, e.Surname, a.Type_of_entry, a.Datetime_of_entry FROM Employee e LEFT JOIN ( SELECT a.Employee_ID, a.Type_of_entry, a.Datetime_of_entry FROM Attendance a JOIN ( SELECT Attendance.Employee_ID, MAX(Attendance.Datetime_of_entry) AS max_datetime FROM Attendance GROUP BY Attendance.Employee_ID ) b ON a.Employee_ID = b.Employee_ID AND a.Datetime_of_entry = b.max_datetime WHERE CAST(a.Datetime_of_entry AS DATE) = CAST(GETDATE() AS DATE) ) a ON e.ID = a.Employee_ID WHERE e.Login != @currentEmployeeLogin";
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
        /// Returns <see cref="DataTable"> of employees who are momentally at work
        /// </summary>
        /// <param name="currentEmployeeLogin"></param>
        /// <returns></returns>
        public DataTable GetColleguesAtWork(string currentEmployeeLogin)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }
            try
            {
                string query = "SELECT e.Name, e.Surname, e.Photo FROM Employee e LEFT JOIN (SELECT  a.Employee_ID, a.Type_of_entry, a.Datetime_of_entry FROM Attendance a JOIN (SELECT  Attendance.Employee_ID,MAX(Attendance.Datetime_of_entry) AS max_datetime  FROM   Attendance   GROUP BY  Attendance.Employee_ID ) b ON a.Employee_ID = b.Employee_ID AND a.Datetime_of_entry = b.max_datetime    WHERE   CAST(a.Datetime_of_entry AS DATE) = CAST(GETDATE() AS DATE)) a ON e.ID = a.Employee_ID where a.Type_of_entry = 1 and e.Login != @currentEmployeeLogin";
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
        /// Returns <see cref="SqlDataReader"> overall worked hours for employee and overall days
        /// </summary>
        /// <param name="employeeLogin"></param>
        /// <returns></returns>
        public Dictionary<string, int> GetHoursDays(string employeeLogin)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }


            try
            {
                string query = "WITH AllDays AS (SELECT DATEADD(DAY, number, @StartDate) AS Date FROM master.dbo.spt_values WHERE type = 'P' AND DATEADD(DAY, number, @StartDate) <= @EndDate) SELECT E.Name, SUM(CASE  WHEN CheckIn.Datetime_of_entry IS NOT NULL AND CheckOut.Datetime_of_entry IS NOT NULL THEN DATEDIFF(HOUR, CheckIn.Datetime_of_entry, CheckOut.Datetime_of_entry) WHEN CheckIn.Datetime_of_entry IS NOT NULL THEN DATEDIFF(HOUR, CheckIn.Datetime_of_entry, DATEADD(DAY, 1, AD.Date)) ELSE 0 END) AS Total_Worked_Hours, COUNT(DISTINCT CASE WHEN CheckIn.Datetime_of_entry IS NOT NULL THEN AD.Date END) AS Worked_Days FROM Employee E CROSS JOIN AllDays AD LEFT JOIN (SELECT Employee_ID, CAST(Datetime_of_entry AS date) AS Attendance_Date,MAX(CASE WHEN Type_of_entry = 1 THEN Datetime_of_entry END) AS CheckIn, MAX(CASE WHEN Type_of_entry = 0 THEN Datetime_of_entry END) AS CheckOut FROM Attendance GROUP BY Employee_ID, CAST(Datetime_of_entry AS date)) AS AttendanceDetail ON E.ID = AttendanceDetail.Employee_ID AND AD.Date = AttendanceDetail.Attendance_Date LEFT JOIN Attendance AS CheckIn ON CheckIn.Employee_ID = AttendanceDetail.Employee_ID AND CheckIn.Datetime_of_entry = AttendanceDetail.CheckIn LEFT JOIN Attendance AS CheckOut ON CheckOut.Employee_ID = AttendanceDetail.Employee_ID AND CheckOut.Datetime_of_entry = AttendanceDetail.CheckOut WHERE E.Login = @currentLogin GROUP BY E.Name";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    DateTime date = DateTime.Now;
                    var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
                    var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                    cmd.Parameters.AddWithValue("@StartDate", firstDayOfMonth);
                    cmd.Parameters.AddWithValue("@EndDate", lastDayOfMonth);
                    cmd.Parameters.AddWithValue("@currentLogin", employeeLogin);


                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    if (!reader.HasRows) { return null; }

                    return new Dictionary<string, int>()
                    { {"days", (int)reader[2] },
                       { "hours", (int)reader[1] } };
                }
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

        public DataTable GetAttendanceOverall(int year, int month)
        {
            if (DatabaseConnection.GetConnection().State == ConnectionState.Closed)
            {
                DatabaseConnection.GetConnection().Open();
            }


            try
            {
                string query = "WITH AllDays AS (\r\n    SELECT DATEADD(DAY, number, @StartDate) AS Date\r\n    FROM master.dbo.spt_values\r\n    WHERE type = 'P'\r\n    AND DATEADD(DAY, number, @StartDate) <= @EndDate\r\n)\r\nSELECT CONCAT(E.Name,' ', E.Surname) as Employee_NameSurname,\r\n       AD.Date AS Attendance_Date,\r\n       COALESCE(CONVERT(varchar, A.Datetime_of_entry, 108), 'Absent') AS Time_of_Entry, -- Display time or \"Absent\"\r\n       CASE \r\n           WHEN A.Type_of_entry = 1 THEN 'Check In'\r\n           WHEN A.Type_of_entry = 0 THEN 'Check Out'\r\n           ELSE 'Unknown'\r\n       END AS Attendance_Type\r\nFROM Employee E\r\nCROSS JOIN AllDays AD\r\nLEFT JOIN Attendance A ON E.ID = A.Employee_ID AND CAST(A.Datetime_of_entry AS date) = AD.Date\r\nORDER BY Employee_NameSurname, AD.Date";
                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {


                    DateTime startDate = new DateTime(year, month, 1);
                    var firstDayOfMonth = new DateTime(startDate.Year, startDate.Month, 1);
                    var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                    // DateTime date = DateTime.Now;
                    //DateTime lastMonthDate = date.AddMonths(-1); // Subtract 1 month to get the previous month
                    //var firstDayOfMonth = new DateTime(lastMonthDate.Year, lastMonthDate.Month, 1);
                    //var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                    cmd.Parameters.AddWithValue("@StartDate", firstDayOfMonth);
                    cmd.Parameters.AddWithValue("@EndDate", lastDayOfMonth);

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        return dt;
                    }

                }
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
