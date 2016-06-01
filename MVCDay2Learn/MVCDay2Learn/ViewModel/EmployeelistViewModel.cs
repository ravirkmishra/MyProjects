using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDay2Learn.ViewModel
{
    public class EmployeelistViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }
    }
  
}