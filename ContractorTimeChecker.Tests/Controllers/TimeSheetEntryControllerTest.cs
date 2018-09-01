using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using ContractorTimeChecker.DAL;
using ContractorTimeChecker.Controllers;

namespace ContractorTimeChecker.Tests.Controllers
{
    [TestClass]
    public class TimeSheetEntryControllerTest
    {
        ApplicationContext mockContext;

        [TestInitialize]
        public void Setup()
        {
            mockContext = MockRepository.GenerateMock<ApplicationContext>();
        }

        [TestMethod]
        public void TestCreateEntry()
        {
            // Arrange
            TimeSheetEntryController controller = new TimeSheetEntryController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestCleanup]
        public void TearDown()
        {
           
        }
        
    }
}
