using Rhino.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContractorTimeChecker.DAL;
using ContractorTimeChecker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContractorTimeChecker.Tests.Services
{
    [TestClass]
    class TimeCheckerServiceTests
    {
        private ApplicationContext mockContext;

        private ITimeCheckerService service;

        [TestInitialize]
        public void Setup()
        {
            mockContext = MockRepository.GenerateMock<ApplicationContext>();
        }

        [TestMethod]
        public void TestGetCandidates()
        {

        }
    }
}
