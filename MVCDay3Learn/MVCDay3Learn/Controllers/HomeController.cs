using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDay3Learn.Models;
using MVCDay3Learn.BL;
using MVCDay3Learn.ViewModel;

namespace MVCDay3Learn.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            EmployeeBL objEmpBL = new EmployeeBL();
            List<EmployeeModel> ADGroupListValuesFromBL = new List<EmployeeModel>();
            ADGroupListValuesFromBL = objEmpBL.GetADGroups();

            List<EmployeeViewModel> ADGroupListforViewModel = new List<EmployeeViewModel>();

            foreach (EmployeeModel adgroup in ADGroupListValuesFromBL)
            {
                EmployeeViewModel objEmpViewModel = new EmployeeViewModel();
                objEmpViewModel.GroupId = adgroup.GroupId;
                objEmpViewModel.GroupName = adgroup.GroupName;

                ADGroupListforViewModel.Add(objEmpViewModel);
            }

            //EmployeeListViewModel emplistviewmodel = new EmployeeListViewModel();
            //emplistviewmodel.ListOfADGroupId = 

            return View("Index", ADGroupListValuesFromBL);
        }

    }
}
