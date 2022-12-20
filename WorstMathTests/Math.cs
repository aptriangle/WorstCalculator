using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorstMath;

namespace WorstMathTests
{
    /// <summary>
    /// Oh yes, we have unit tests, and they pass too.
    /// So that must mean the code's good and ready to be merged in?
    /// Bwa ha ha ha, stick that up your sprint.
    /// </summary>
    [TestClass]
    public class WorstMath
    {
        [TestMethod]
        public void Increment()
        {
            for (int i = 0; i < 100; i++)
            {
                WorstNumber a = i;
                a++;
                Assert.AreEqual((int)a, i + 1);
            }
        }

        internal static double Pow(int v, int i)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void AdditionInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = a + b;
                    Assert.AreEqual((int)result, i + k);
                }
            }
        }

        [TestMethod]
        public void SubtractionInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = a - b;
                    Assert.AreEqual((int)result, i - k);
                }
            }
        }

        [TestMethod]
        public void MultiplicationInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = a * b;
                    Assert.AreEqual((int)result, i * k);
                }
            }
        }

        [TestMethod]
        public void DivisionInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 1; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = a / b;
                    Assert.AreEqual((int)result, i / k);
                }
            }
        }

        [TestMethod]
        public void AdditionDouble()
        {
            for (double i = -10.0; i < 10.0; i = System.Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = System.Math.Round(k + 0.1, 2))
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = a + b;
                    Assert.AreEqual((double)result, i + k, 0.01);
                }
            }
        }

        [TestMethod]
        public void SubtractionDouble()
        {
            for (double i = -10.0; i < 10.0; i = System.Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = System.Math.Round(k + 0.1, 2))
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = a - b;
                    Assert.AreEqual((double)result, i - k, 0.01);
                }
            }
        }

        [TestMethod]
        public void MultiplicationDouble()
        {
            for (double i = -10.0; i < 10.0; i = System.Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = System.Math.Round(k + 0.1, 2))
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = a * b;
                    Assert.AreEqual((double)result, i * k, 0.01);
                }
            }
        }

        [TestMethod]
        public void DivisionDouble()
        {
            for (double i = -10.0; i < 10.0; i = System.Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = System.Math.Round(k + 0.1, 2))
                {
                    if (k == 0.0)
                    {
                        continue;
                    }
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = a / b;
                    Assert.AreEqual((double)result, i / k, 0.01);
                }
            }
        }
    }
}
