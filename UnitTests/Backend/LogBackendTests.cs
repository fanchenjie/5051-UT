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



        [TestMethod]
        public void LogBackend_Read_Valid_Item_Should_Pass()
        {
            //Arrage
            var myTest = LogBackend.Instance;
            var oldItem = myTest.Index().LogList.First();

            //Act

            var newItem = myTest.Read(oldItem.ID);
            //Assert

            Assert.AreEqual(oldItem.ID, newItem.ID);
            Assert.AreEqual(oldItem.PhoneID, newItem.PhoneID);
            Assert.AreEqual(oldItem.RecordedDateTime, newItem.RecordedDateTime);
            Assert.AreEqual(oldItem.Value, newItem.Value);
        }

        [TestMethod]
        public void LogBackend_Update_First_Item_Should_Pass()
        {
            //Arrage
            var myTest = LogBackend.Instance;
            var oldItem = myTest.Index().LogList.First();
            var oldValue = oldItem.Value;

            oldItem.Value = "UpdatedValue";

            //Act
            var result = myTest.Update(oldItem);
            var newItem = myTest.Read(oldItem.ID);
            //Assert

            Assert.AreNotEqual(oldValue, newItem.Value);
        }



        [TestMethod]
        public void LogBackend_Delete_First_Item_Should_Pass()
        {
            //Arrage
            var myTest = LogBackend.Instance;
            var oldItem = myTest.Index().LogList.First();
           

            //Act
            var result = myTest.Delete(oldItem.ID);
            var newItem = myTest.Index().LogList.First();
            //Assert

            Assert.AreNotEqual(oldItem.ID, newItem.ID);
        }

        [TestMethod]
        public void LogBackend_Create_InValid_Null_Should_Pass()
        {
            //Arrage
            var myTest = LogBackend.Instance;

            //Act

            var newItem = myTest.Create(null);
            //Assert

            Assert.AreEqual(null, newItem);
        }
    }
}
