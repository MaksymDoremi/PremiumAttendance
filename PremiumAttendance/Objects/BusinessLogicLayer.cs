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
        #region RETRIEV
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
        #endregion
        #region UPDATE
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
        #region DELETES
        #endregion
    }
}
