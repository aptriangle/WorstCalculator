using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorstMath;

namespace WorstMathTests
{
    [TestClass]
    public class WorstBasic
    {
        [TestMethod]
        public void ShiftOrder()
        {
            double example = 445.0;
            WorstNumber worst = new WorstNumber(example);
            for (int i = -5; i <= 5; i++)
            {
                WorstNumber shifted = worst.ShiftOrder(i);
                double scaled = example * Math.Pow(10, i);
                Assert.AreEqual((double)shifted, scaled, 0.0000001);
            }
        }
        [TestMethod]
        public void ShiftOrderDouble()
        {
            double example = 0.446;
            WorstNumber worst = new WorstNumber(example);
            for (int i = -5; i <= 5; i++)
            {
                WorstNumber shifted = worst.ShiftOrder(i);
                double scaled = example * Math.Pow(10, i);
                Assert.AreEqual((double)shifted, scaled, 0.0000001);
            }
        }
    }
}
