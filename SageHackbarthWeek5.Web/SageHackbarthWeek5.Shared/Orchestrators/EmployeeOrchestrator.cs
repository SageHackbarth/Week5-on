using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using SageHackbarthWeek5.Domain;
using SageHackbarthWeek5.Domain.Entities;
using SageHackbarthWeek5.Shared.Orchestrators.Interface;
using SageHackbarthWeek5.Shared.ViewModels;

namespace SageHackbarthWeek5.Shared.Orchestrators
{
	public class EmployeeOrchestrator : IEmployeeOrchestrator
	{
		private readonly EmployeeContext _employeeContext;

		public EmployeeOrchestrator()
		{
			_employeeContext = new EmployeeContext();
		}

        public async Task<int> CreateEmployee(EmployeeViewModel employee)
        {
            _employeeContext.Employees.Add(new Employee
            {
                EmplyeeId = employee.EmployeeId,
                Name = employee.EmployeeName,
                Email = employee.Email,
                Role = employee.Role
            });

            return await _employeeContext.SaveChangesAsync();
        }

        public List<EmployeeViewModel> GetAllEmployees()
		{
			var employees = _employeeContext.Employees.Select(x => new EmployeeViewModel
			{
				EmployeeName = x.Name,
				Email = x.Email,
				Role = x.Role
			}).ToList();

			return employees;
		}

        public async Task<bool> UpdateEmployee(EmployeeViewModel employee)
        {
            var updateEntity = await _employeeContext.Employees.FindAsync(employee.EmployeeId);

            if (updateEntity == null)
            {
                return false;
            }

            updateEntity.Name = employee.EmployeeName;
            updateEntity.Email = employee.Email;
            updateEntity.Role = employee.Role;

            await _employeeContext.SaveChangesAsync();

            return true;
        }
        

        public async Task<EmployeeViewModel> SearchEmployee(string searchString)
        {
            var employee = await _employeeContext.Employees
                .Where(x => x.Name.StartsWith(searchString))
                .FirstOrDefaultAsync();

            if (employee == null)
            {
                return new EmployeeViewModel();
            }

            var viewModel = new EmployeeViewModel
            {
                EmployeeId = employee.EmplyeeId,
                EmployeeName = employee.Name,
                Role = employee.Role,
                Email = employee.Email
            };

            return viewModel;
        }
    }
}
