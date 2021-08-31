using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("tobasco");
            testInstance.Sauces.Add("tobasco");
            testInstance.Sauces.Add("tobasco");

            //expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));

            //expected false
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
