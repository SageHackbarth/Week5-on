using SageHackbarthWeek5.Shared.Orchestrators.Interface;
using SageHackbarthWeek5.Shared.ViewModels;
using SageHackbarthWeek5.Web.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SageHackbarthWeek5.Web.Controllers
{
    public class EmployeeController : Controller
	{
		private readonly IEmployeeOrchestrator _employeeOrchestrator;

		public EmployeeController(IEmployeeOrchestrator employeeOrchestrator)
		{
			_employeeOrchestrator = employeeOrchestrator;
		}

		// GET: Student
		public async Task<ActionResult> Index()
		{
			var employeeDisplayModel = new EmployeeDisplayModel
            {
				Students =  _employeeOrchestrator.GetAllEmployees()

			};

			return View(employeeDisplayModel);
		}

		public async Task<ActionResult> Create(CreateEmployeeModel employee)
		{
			if (string.IsNullOrWhiteSpace(employee.Name))
				return View();

			var updatedCount = await _employeeOrchestrator.CreateEmployee(new EmployeeViewModel
			{
				EmployeeId = Guid.NewGuid(),
                EmployeeName = employee.Name,
                Email = employee.Email,
                Role = employee.Role
            });

			return View();
		}

		public ActionResult Update()
		{
			return View();
		}

		public async Task<JsonResult> UpdateStudent(UpdateEmployeeModel employee)
		{
            if (employee.EmployeeId == Guid.Empty)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
				

			var result = await _employeeOrchestrator.UpdateEmployee(new EmployeeViewModel
			{
                EmployeeId = Guid.NewGuid(),
                EmployeeName = employee.Name,
                Email = employee.Email,
                Role = employee.Role
            });

			return Json(result, JsonRequestBehavior.AllowGet);
		}

		public async Task<JsonResult> Search(string searchString)
		{
			var viewModel = await _employeeOrchestrator.SearchEmployee(searchString);

			return Json(viewModel, JsonRequestBehavior.AllowGet);
		} 
	}
}