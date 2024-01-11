﻿using System;
using System.Collections.Generic;
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
                MessageBox.Show(ex.Message);
                return false;
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
                MessageBox.Show(ex.Message);
                return null;
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
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        #endregion
        #region DELETES
        #endregion
    }
}
