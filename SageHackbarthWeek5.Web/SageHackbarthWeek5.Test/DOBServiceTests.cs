using System;
using AutoMoq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageHackbarthWeek5.Shared.Services;
using SageHackbarthWeek5.Shared.Services.Interfaces;
using SageHackbarthWeek5.Shared.ViewModels;

namespace SageHackbarthWeek5.Test
{
    [TestClass]
    public class DOBServiceTests
    {
        private readonly AutoMoqer _mocker = new AutoMoqer();

        [TestInitialize]
        public void Initialize()
        {
            _mocker.GetMock<IDateTimeService>()
                .Setup(x => x.Now())
                .Returns(new DateTime(2018, 10, 15));
        }

        [TestMethod]
        public void BirthdayToday_ReturnsTrue_WhenBirthdayIsToday()
        {
            var employee = new EmployeeViewModel
            {
                EmployeeId = Guid.NewGuid(),
                DOB = new DateTime(1997, 10, 15),
                Email = "ShinGodzilla@g.c",
                EmployeeName = "Sheeshee",
                Role = "Jester"
            };

            var datOfBirthService = _mocker.Create<DOBService>();
            var isBirthday = datOfBirthService.IsTodayYourBD(employee);

            Assert.IsTrue(isBirthday);
        }
    }
}
