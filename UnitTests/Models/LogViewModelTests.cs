using HW1c.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Models
{
    [TestClass]
    public class LogViewModelTests
    {
        [TestMethod]
        public void LogViewModel_Instantiate_Default_should_Pass()
        {

            //Arrange

            //Act

            var result = new LogViewModel();

            //Assert

            Assert.IsNotNull(result);
        }
    }
}
