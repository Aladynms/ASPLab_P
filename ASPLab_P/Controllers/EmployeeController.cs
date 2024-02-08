using ASPLab_P.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPLab_P.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View(_employeeService.FindAll());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Add(employee);
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {

            return View(_employeeService.FindById(id));
        }

        [HttpGet]
        public IActionResult AdvancedEdit(int id)
        {

            return View(_employeeService.FindById(id));
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Edit(employee);
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Detalis(int id)
        {
            return View(_employeeService.FindById(id));
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_employeeService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            _employeeService.DeleteById(employee.Id);
            return RedirectToAction("Index");
        }
    }
}
