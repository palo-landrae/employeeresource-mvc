using Microsoft.AspNetCore.Mvc;
using EmployeeResourceModel.Models;
using EmployeeResourceBusLogic.Manager;
using EmployeeResourceBusLogic.Abstract;

namespace EmployeeResourceWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly AEmployee _regularEmployeeManager = new RegularEmployeeManager();
        private int EmployeeId = 0;

        public ActionResult Index()
        {
            ViewBag.Employee = _regularEmployeeManager.GetEmployee(EmployeeId);
            return View();
        }

        [HttpPost]
        public ActionResult ViewEmployee(int EmployeeId)
        {
            this.EmployeeId = EmployeeId;
            return RedirectToAction("Index");
        }
    }
}
