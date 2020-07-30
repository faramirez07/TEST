using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Controllers;
using Test.Model.Migration;


namespace Test.UnitTest
{
    [TestClass]
    public class ClientUnitTest
    {
        [TestMethod]
        public void Client()
        {
            //Arrange
            var testClients = GetAllClients();
            var controller = new ClientController(testClients);

            //Act
            var result = controller.ResultPrueba() as List<ClientM>;
                      

            //Assert
            Assert.AreEqual(testClients.Count, result.Count);
          

        }
       private List<ClientM> GetAllClients()
        {
            var testClient = new List<ClientM>();
            testClient.Add(new ClientM { IdClient = 1, Id = 304520014, Name = "Fabian Ramirez", Nationality = "Costa Rica", Active = true, Age = 29, UserCreate = "framirez", DateCreate = DateTime.Now });
            return testClient;
        }
}
}
