using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDay2Learn.Models;
using MVCDay2Learn.ViewModel;

namespace MVCDay2Learn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult GetEmployee()
        {
            //Model Value assignment

            //EmployeeModel objEmpModel = new EmployeeModel();
            //objEmpModel.FirstName = "Ravi";
            //objEmpModel.LastName = "Mishra";
            //objEmpModel.Salary = 60000;

            //return View("GetEmployee", objEmpModel);

            //ViewModel Value assignment

            //EmployeeViewModel objEmpVwModel = new EmployeeViewModel();
            //objEmpVwModel.EmployeeName = objEmpModel.FirstName + " " + objEmpModel.LastName;
            //objEmpVwModel.Salary = Convert.ToString(objEmpModel.Salary);
            //if (objEmpModel.Salary > 50000)
            //{
            //    objEmpVwModel.SalaryColor = "Yellow";
            //}
            //else
            //{
            //    objEmpVwModel.SalaryColor = "Red";
            //}

            ////objEmpVwModel.UserName = "Admin";

            //return View("GetEmployee", objEmpVwModel);


            EmployeeBL empbl = new EmployeeBL();

            List<EmployeeModel> listEmployees = empbl.GetEmployees();

            List<EmployeeViewModel> listEmpViewModel = new List<EmployeeViewModel>();

            foreach (EmployeeModel emp in listEmployees)
            {
                EmployeeViewModel objEmpViewModel = new EmployeeViewModel();

                objEmpViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                objEmpViewModel.Salary = emp.Salary.ToString("C");

                if (emp.Salary > 50000)
                {
                    objEmpViewModel.SalaryColor = "Yellow";
                }
                else
                {
                    objEmpViewModel.SalaryColor = "Red";
                }
                listEmpViewModel.Add(objEmpViewModel);
            }
            EmployeelistViewModel objEmpListViewModel = new EmployeelistViewModel();
            objEmpListViewModel.Employees = listEmpViewModel;
            objEmpListViewModel.UserName = "Admin";

            return View("GetEmployee", objEmpListViewModel);
        }
    }
}
