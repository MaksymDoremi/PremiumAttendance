using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance.Objects
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
            catch (Exception ex)
            {
                throw ex;
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets user by login from database
        /// </summary>
        /// <param name="login"></param>
        /// <returns>An instance of <see cref="PremiumAttendance.Objects.Employee"/> class</returns>
        public Employee GetCurrentUser(string login)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.GetCurrentUser(login);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Reads notifications for current employee
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
            catch (Exception ex)
            {
                throw ex;
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
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.GetEmployees(currentEmployeeLogin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                return dal.UpdateEmployee(userInstance);
            }
            catch (Exception ex)
            {
                throw ex;
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Mark message as read
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
        #endregion
    }
}
