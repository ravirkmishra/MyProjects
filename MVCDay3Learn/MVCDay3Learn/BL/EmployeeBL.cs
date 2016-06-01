using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDay3Learn.DAL;
using MVCDay3Learn.Models;
using System.Data.Entity.Validation;

namespace MVCDay3Learn.BL
{
    public class EmployeeBL
    {
        public List<EmployeeModel> GetADGroups()
        {
            try
            {
                EmployeeDAL objDAL = new EmployeeDAL();
                return objDAL.ADGroupList.ToList();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
           .SelectMany(x => x.ValidationErrors)
           .Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);
              // Combine the original exception message with the new one.
    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

    // Throw a new DbEntityValidationException with the improved exception message.
    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors); 
            }
          
        }
    }
}