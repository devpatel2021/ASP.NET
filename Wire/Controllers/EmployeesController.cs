using Microsoft.AspNetCore.Mvc;
using wire.Models;

namespace wire.Controllers
{

    


    public class EmployeesController : Controller
    {


        private static List<Employee> Employees { get; set; }


        public EmployeesController()
        {
            if (Employees == null)
            {
                Employees = new List<Employee>()
                {
                    new Employee { EmployeeID = 1, FirstName = "Dev", LastName = "Patel", Email= "devpatel@gmail.com", DepartmentID = 1, RoleID = 1 },
                    new Employee { EmployeeID = 2, FirstName = "Smit", LastName = "Patel", Email= "smitpatel@gmail.com", DepartmentID = 2, RoleID = 2 },
                    new Employee { EmployeeID = 3, FirstName = "Chintan", LastName = "Vaghasiya", Email= "chintanvaghasiya@gmail.com", DepartmentID = 3, RoleID = 3 },
                };
            }

            
        }


        public IActionResult Index()
        {
            return View(Employees);
        }


        public IActionResult Browse(int id)
        {
            var employee = Employees.Find(Employee => Employee.EmployeeID == id);
            return View(employee);
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
                Employees.Add(employee);

                return RedirectToAction("Index");
            }


            return View(employee);
        }
    }
}
