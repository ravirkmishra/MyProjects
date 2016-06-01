using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDay2Learn.Models
{
    public class EmployeeBL
    {
        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> employess = new List<EmployeeModel>();
            EmployeeModel emp = new EmployeeModel();
            emp.FirstName = "Ravi";
            emp.LastName = "Mishra";
            emp.Salary = 40000;
            employess.Add(emp);
            return employess;
        }
    }
}