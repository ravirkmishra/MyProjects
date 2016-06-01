using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDay3Learn.Models;

namespace MVCDay3Learn.ViewModel
{
    public class EmployeeListViewModel
    {
        public List<EmployeeModel> ListOfADGroupId { get; set; }
        public List<EmployeeModel> ListOfADGroupName { get; set; }
        public string UserName { get; set; }
    }
}