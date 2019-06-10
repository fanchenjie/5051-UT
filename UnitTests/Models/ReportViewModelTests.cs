using HW1c.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void RepoertViewModel_Instantiate_Default_Should_Pass()
        {

            //Arrage

            //Act

            var result = new ReportViewModel();
            //Assert

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RepoertViewModel_Get_LogViewModel_Default_Should_Pass()
        {

            //Arrage
            var myTest = new ReportViewModel();
            //Act

            var result = myTest.LogViewModel;
            //Assert

            Assert.IsNotNull(result);
        }
    }
}
