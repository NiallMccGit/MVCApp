using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLoic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeID, string firstName, string lastName, string emailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeID,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress
            };

            string sql = @"INSERT INTO EmployeeTbl (EmployeeID, FirstName, LastName, EmailAddress) 
                           VALUES (@EmployeeID, @FirstName, @LastName, @EmailAddress);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = "SELECT Id, EmployeeID,  FirstName, LastName, EmailAddress FROM EmployeeTbl;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
