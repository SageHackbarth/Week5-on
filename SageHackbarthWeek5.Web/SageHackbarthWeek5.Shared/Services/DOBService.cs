using SageHackbarthWeek5.Shared.Services.Interfaces;
using SageHackbarthWeek5.Shared.ViewModels;

namespace SageHackbarthWeek5.Shared.Services
{
    public class DOBService : IDOBService
    {
        private readonly IDateTimeService _dateTimeService;

        public DOBService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        public bool IsTodayYourBD(EmployeeViewModel employee)
        {
            return employee.DOB.DayOfYear == _dateTimeService.Now().DayOfYear;
        }
    }
}
