using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YurlovVN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.YurlovVN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            
            var name = "Виктор";
            var res = DataService.GetMessage(name);

            
            Assert.AreEqual("Привет, Виктор", res);
        }
    }
}