using Microsoft.VisualStudio.TestTools.UnitTesting;
using PremiumAttendance.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremiumAttendance.objects;
using PremiumAttendance.DB;
using System.Data.SqlClient;

namespace PremiumAttendance.Objects.Tests
{
    [TestClass()]
    public class BusinessLogicLayerTests
    {
        [TestMethod()]
        public void LoginTest()
        {

            BusinessLogicLayer bll = new BusinessLogicLayer();
            Assert.IsTrue(bll.Login("admin", Program.ComputeSHA256("123")));
        }

        [TestMethod()]
        public void CreateEmployeeTest()
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            DatabaseConnection.GetConnection().Open();
            SqlTransaction transaction = DatabaseConnection.GetConnection().BeginTransaction();

            Assert.IsTrue(bll.CreateEmployee(new Employee(0,"testTag","Employee", "unitTest", "password","test", "surname", null, "email@email.com", "+420000000000")));
            
            transaction.Rollback();
        }
    }
}