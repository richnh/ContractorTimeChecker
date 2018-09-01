using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using ContractorTimeChecker.DAL;
using ContractorTimeChecker.Controllers;
using ContractorTimeChecker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContractorTimeChecker.Tests.Controllers
{
    [TestClass]
    public class TimeSheetSummaryControllerTests
    {
        ApplicationContext mockedContext;

        TimeCheckerService mockedService;

        [TestInitialize]
        public void Setup()
        {
            mockedContext = MockRepository.GenerateMock<ApplicationContext>();

            mockedService = MockRepository.GenerateMock<TimeCheckerService>();
        }

        public void TestCreateEntry()
        {
            IEnumerable<SelectListItem> selectItems = new List<SelectListItem>();

            mockedService.Expect(x => x.GetCandidateNames()).Return(selectItems);

            // Arrange
            TimeSheetSummaryController controller = new TimeSheetSummaryController(mockedService);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            controller.VerifyAllExpectations();
        }

        [TestCleanup]
        public void TearDown()
        {
           
        }
        
    }
}
