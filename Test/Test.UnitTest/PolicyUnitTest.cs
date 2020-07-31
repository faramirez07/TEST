using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Model.Migration;
using Test.WebAPI.Controllers;

namespace Test.UnitTest
{
    [TestClass]
    public class PolicyUnitTest
    {
        private List<ClientM> testPolicy;

        [TestMethod]
    
            public void Policy()
            {
                ////Arrange
                //var testClients = GetAllPolicy();
                //var controller = new PolicyController(testPolicy);

                ////Act
                //var result = controller.ResultPrueba() as List<PolicyM>;


                ////Assert
                //Assert.AreEqual(testClients.Count, result.Count);


            }
            private List<PolicyM> GetAllPolicy()
            {
                var testPolicy = new List<PolicyM>();
                testPolicy.Add(new PolicyM { IdPolicy = 1, Duration = 20, Name = "Test Policy", Active = true, UserCreate = "framirez", DateCreate = DateTime.Now });
                return testPolicy;
            }
        
    }
}
