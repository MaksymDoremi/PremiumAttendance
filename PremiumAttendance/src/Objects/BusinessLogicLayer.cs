using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance.objects
{
    public class BusinessLogicLayer
    {
        #region CREATE
        /// <summary>
        /// Sends notification to all employees
        /// </summary>
        /// <param name="authorEmployeeID"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <returns>True if success</returns>
        public bool SendNotification(int employeeID, string title, string content)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.SendNotification(employeeID, title, content);

            }
            catch
            {
                throw;
            }
        }

        public bool CreateEmployee(Employee employee)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.CreateEmployee(employee);

            }
            catch
            {
                throw;
            }
        }

        public void InsertAttendance(string rfidTag)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                dal.InsertAttendance(rfidTag);

            }
            catch
            {
                throw;
            }
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
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.Login(login, password);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Gets <see cref="Employee"/> by login from database
        /// </summary>
        /// <param name="login"></param>
        /// <returns>An instance of <see cref="Employee"/> class</returns>
        public Employee GetCurrentUser(string login)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.GetCurrentUser(login);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Gets all <see cref="Notification"/> for the current <see cref="Employee"/> that he received
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns><see cref="System.Data.DataTable"/> of <see cref="PremiumAttendance.Objects.Notification"/> instances</returns>
        public DataTable GetNotifications(int employeeID)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.GetNotifications(employeeID);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// <para>Returns <see cref="DataTable"/> of employee status in format ID, Name, Surname, Type_of_entry, Datetime_of_entry</para>       
        /// </summary>
        /// <param name="currentEmployeeLogin"></param>
        /// <returns><see cref="System.Data.DataTable"/> of employee status</returns>
        public DataTable GetEmployeeStatus(string currentEmployeeLogin)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.GetEmployeeStatus(currentEmployeeLogin);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// <para>Gets <see cref="System.Data.DataTable"/> of <see cref="PremiumAttendance.Objects.Employee"/> in format</para> 
        /// ID, Name, Surname, RFID_Tag, Role_name, Login, Photo, Email, Phone
        /// </summary>
        /// <param name="currentEmployeeLogin"></param>
        /// <returns><see cref="System.Data.DataTable"/> of <see cref="PremiumAttendance.Objects.Employee"/></returns>
        public DataTable GetEmployees(string currentEmployeeLogin)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.GetEmployees(currentEmployeeLogin);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Returns <see cref="DataTable"/> of <see cref="Employee"/> who are momentally at work
        /// </summary>
        /// <param name="currentEmployeeLogin"></param>
        /// <returns><see cref="DataTable"/> of <see cref="Employee"/></returns>
        public DataTable GetColleguesAtWork(string currentEmployeeLogin)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.GetColleguesAtWork(currentEmployeeLogin);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Returns <see cref="Dictionary{string, int}"/> overall worked hours and days for current <see cref="Employee"/>
        /// </summary>
        /// <param name="currentLogin"></param>
        /// <returns><see cref="Dictionary{TKey, TValue}"/> in format days : n, hours : m</returns>
        public Dictionary<string, int> GetHoursDays(string currentLogin)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.GetHoursDays(currentLogin);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// <para>Retrieves overall attendance report for employees</para>
        /// <para>Format: Employee_NameSurname, Attendance_Date, Time_of_Entry, Attendance_Type</para>
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns><see cref="DataTable"/></returns>
        public DataTable GetAttendanceOverall(int year, int month)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.GetAttendanceOverall(year, month);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// <para>Retrieves overall attendance report for exact employee using current login</para>
        /// <para>Format: Employee_NameSurname, Attendance_Date, Time_of_Entry, Attendance_Type</para>
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="employeeLogin"></param>
        /// <returns><see cref="DataTable"/></returns>
        public DataTable GetAttendanceOverall(int year, int month, string employeeLogin)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.GetAttendanceOverall(year, month, employeeLogin);
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #region UPDATE

        /// <summary>
        /// Updates <see cref="PremiumAttendance.Objects.Employee"/> attributes
        /// </summary>
        /// <param name="userInstance"></param>
        /// <returns>True if success</returns>
        public bool UpdateEmployee(Employee userInstance)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.UpdateEmployee(userInstance);
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// Updates old password. Checks for old password correctness
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns>True if success</returns>
        public bool UpdatePassword(int empmloyeeID, string oldPassword, string newPassword)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.UpdatePassword(empmloyeeID, oldPassword, newPassword);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Marks <see cref="Notification"/> as read
        /// </summary>
        /// <param name="haveReadID"></param>
        /// <returns>True if success</returns>
        public bool MarkAsRead(int haveReadID)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.MarkAsRead(haveReadID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region DELETE
        /// <summary>
        /// Deletes <see cref="PremiumAttendance.Objects.Employee"/> from database using ID
        /// </summary>
        /// <param name="employeeID">Id of the employee to be deleted</param>
        /// <returns>True if success</returns>
        public bool DeleteEmployee(int employeeID)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.DeleteEmployee(employeeID);
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
