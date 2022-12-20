using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorstMath;

namespace WorstMathTests
{
    /// <summary>
    /// Hmmm, these "Comparison" tests are in a separate class from the "Math" tests, but they really are math too.
    /// Maybe we should schedule a meeting with key decision makers to discuss the organization of our test classes.
    /// </summary>
    [TestClass]
    public class WorstComparison
    {
        [TestMethod]
        public void MaxInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = WorstNumber.Max(a, b);
                    Assert.AreEqual(Math.Max(i, k), (int)result);
                }
            }
        }

        [TestMethod]
        public void MaxNegativeInteger()
        {
            for (int i = -50; i < 50; i++)
            {
                for (int k =- 50; k < 50; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = WorstNumber.Max(a, b);
                    Assert.AreEqual(Math.Max(i, k), (int)result);
                }
            }
        }

        [TestMethod]
        public void MaxDouble()
        {
            for (double i = -10.0; i < 10.0; i = Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = Math.Round(k + 0.1, 2))
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    WorstNumber result = WorstNumber.Max(a, b);
                    Assert.AreEqual(Math.Max(i, k), (double)result, 0.01);
                }
            }
        }

        [TestMethod]
        public void EqualsInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a == b;
                    Assert.AreEqual(i == k, result);
                }
            }
        }

        [TestMethod]
        public void NotEqualsInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a != b;
                    Assert.AreEqual(i != k, result);
                }
            }
        }

        [TestMethod]
        public void GreaterInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a > b;
                    Assert.AreEqual(i > k, result);
                }
            }
        }

        [TestMethod]
        public void LessInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a < b;
                    Assert.AreEqual(i < k, result);
                }
            }
        }

        [TestMethod]
        public void GreaterOrEqualsInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a >= b;
                    Assert.AreEqual(i >= k, result);
                }
            }
        }

        [TestMethod]
        public void LessOrEqualsInteger()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a <= b;
                    Assert.AreEqual(i <= k, result);
                }
            }
        }

        [TestMethod]
        public void EqualsDouble()
        {
            for (double i = -10.0; i < 10.0; i = Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = Math.Round(k + 0.1, 2))
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a == b;
                    Assert.AreEqual(i == k, result);
                }
            }
        }

        [TestMethod]
        public void NotEqualsDouble()
        {
            for (double i = -10.0; i < 10.0; i = Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = Math.Round(k + 0.1, 2))
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a != b;
                    Assert.AreEqual(i != k, result);
                }
            }
        }

        [TestMethod]
        public void GreaterDouble()
        {
            for (double i = -10.0; i < 10.0; i = Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = Math.Round(k + 0.1, 2))
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a > b;
                    Assert.AreEqual(i > k, result);
                }
            }
        }

        [TestMethod]
        public void LessDouble()
        {
            for (double i = -10.0; i < 10.0; i = Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = Math.Round(k + 0.1, 2))
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a < b;
                    Assert.AreEqual(i < k, result);
                }
            }
        }

        [TestMethod]
        public void GreaterOrEqualsDouble()
        {
            for (double i = -10.0; i < 10.0; i = Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = Math.Round(k + 0.1, 2))
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a >= b;
                    Assert.AreEqual(i >= k, result);
                }
            }
        }

        [TestMethod]
        public void LessOrEqualsDouble()
        {
            for (double i = -10.0; i < 10.0; i = Math.Round(i + 0.1, 2))
            {
                for (double k = -10.0; k < 10.0; k = Math.Round(k + 0.1, 2))
                {
                    WorstNumber a = i;
                    WorstNumber b = k;
                    bool result = a <= b;
                    Assert.AreEqual(i <= k, result);
                }
            }
        }
    }
}
