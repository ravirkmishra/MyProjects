using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDay3Learn.Models
{
    public class EmployeeModel
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }
}