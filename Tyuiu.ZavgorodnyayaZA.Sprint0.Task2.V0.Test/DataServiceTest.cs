using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZavgorodnyayaZA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ZavgorodnyayaZA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Жанна";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Жанна", res);
        }
    }
}
