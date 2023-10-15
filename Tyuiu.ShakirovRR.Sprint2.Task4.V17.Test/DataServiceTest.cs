using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint2.Task4.V17.Lib;

namespace Tyuiu.ShakirovRR.Sprint2.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 26;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 1298.558;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}