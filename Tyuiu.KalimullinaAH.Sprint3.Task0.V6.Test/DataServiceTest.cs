﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint3.Task0.V6.Lib;
namespace Tyuiu.KalimullinaAH.Sprint3.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
             DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetMultiplySeries( startValue, stopValue);
            double wait = 0.001;
            Assert.AreEqual(res, wait);
        }
    }
}
