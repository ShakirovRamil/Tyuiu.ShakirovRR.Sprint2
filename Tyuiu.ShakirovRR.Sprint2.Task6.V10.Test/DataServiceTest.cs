using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint2.Task6.V10.Lib;

namespace Tyuiu.ShakirovRR.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("4.10.2012", ds.FindDateOfPreviousDay(5, 10, 2012));
        }
    }
}
