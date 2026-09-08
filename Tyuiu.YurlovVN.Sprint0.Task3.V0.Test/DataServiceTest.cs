using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YurlovVN.Sprint0.Task3.V0.Lib;

namespace Tyuiu.YurlovVN.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}