using HW1c.Backend;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Linq;
using System;

namespace UnitTests.Backend
{
    [TestClass]
    public class LogBackendTests
    {
        [TestMethod]
        public void LogBackend_Create_Valid_Item_Should_Pass()
        {
            //Arrage
            var myTest = LogBackend.Instance;
            //var myRepository = new LogRepositoryMock();


            var oldItem = new LogModel();
            oldItem.ID = "ID";
            oldItem.PhoneID = "PhoneID";
            oldItem.RecordedDateTime = DateTime.Parse("01/23/2019");
            oldItem.Value = "Value";

            //Act

            var newItem = myTest.Create(oldItem);
            //Assert

            Assert.AreEqual(oldItem, myTest.Read(newItem.ID));
        }
    }
}
