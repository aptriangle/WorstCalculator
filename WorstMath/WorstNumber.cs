using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorstMath
{
    /// <summary>
    /// The goal of this class is to create the worst, actually working, math implementation possible, for a competition.
    /// It uses string operations to do basic math.
    /// No part of this is actually intended for use.
    /// </summary>
    public partial class WorstNumber
    {
        private string value;
        private static string leadingZeroRegex = @"(?<=^|-)0*(?=\d+\.?\d*)";
        public WorstNumber(IConvertible value)
        {
            this.value = value.ToString(CultureInfo.InvariantCulture);
        }

        public WorstNumber(string value)
        {
            if (!isNumber(value))
            {
                throw new InvalidOperationException("String passed to WorstNumber constructor must be a number");
            }
            this.value = value;
        }

        public void ClipLeadingZeros()
        {
            this.value = Regex.Replace(value, leadingZeroRegex, "");
        }

        private WorstNumber this[int key]
        {
            get => new WorstNumber(value[key]);
            set
            {
                string merged = "";
                if (key > 0)
                {
                    merged += this.value.Substring(0, key);
                }
                merged += value.ToString();
                if (key < this.value.Length - 1)
                {
                    merged += this.value.Substring(key + 1);
                }
                this.value = merged;
            }
        }

        private void Prepend(WorstNumber a)
        {
            if (IsNegative)
            {
                throw new InvalidOperationException("Cannot prepend to negative number");
            }
            this.value = a.ToString() + this.ToString();
        }

        /// <summary>
        /// This is for multiplying by powers of 10, aka moving the decimal point
        /// </summary>
        public WorstNumber ShiftOrder(int orders)
        {
            if (orders == 0)
            {
                return this.clone();
            }

            if (HasFractionPart)
            {
                string wholePart = WholePart.ToString();
                string fractionPart = FractionPart.ToString();
                if (orders > 0)
                {
                    if (orders <= fractionPart.Length)
                    {
                        wholePart += fractionPart.Substring(0, orders);
                        fractionPart = fractionPart.Substring(orders);
                        if (fractionPart.Length > 0)
                        {
                            return new WorstNumber(wholePart + '.' + fractionPart);
                        }
                        else
                        {
                            return wholePart;
                        }
                    }
                    else
                    {
                        return new WorstNumber(wholePart + fractionPart + new string('0', orders - fractionPart.Length));
                    }
                }
                else
                {
                    if (-orders <= wholePart.Length)
                    {
                        int pointOffset = wholePart.Length + orders;
                        fractionPart = wholePart.Substring(pointOffset) + fractionPart;
                        wholePart = wholePart.Substring(0, pointOffset);
                        if (wholePart.Length > 0)
                        {
                            return new WorstNumber(wholePart + '.' + fractionPart);
                        }
                        else
                        {
                            return new WorstNumber("0." + fractionPart);
                        }
                    }
                    else
                    {
                        return new WorstNumber("0." + new string('0', -orders - wholePart.Length) + wholePart + fractionPart);
                    }
                }
            }
            else
            {
                if (orders > 0)
                {
                    return new WorstNumber(value + new string('0', orders));
                }
                else
                {
                    if (-orders < value.Length)
                    {
                        int dotIndex = value.Length + orders;
                        string wholePart = value.Substring(0, dotIndex);
                        string fractionPart = value.Substring(dotIndex);
                        return new WorstNumber(wholePart + '.' + fractionPart);
                    }
                    else
                    {
                        int padding = -orders - value.Length;
                        return new WorstNumber("0." + new string('0', padding) + value);
                    }
                }
            }
        }

        public override string ToString()
        {
            return value;
        }

        public int length
        {
            get
            {
                return value.Length;
            }
        }

        public bool IsNegative
        {
            get
            {
                return value[0] == '-';
            }
        }

        private bool HasFractionPart
        {
            get
            {
                return value.IndexOf('.') != -1;
            }
        }

        private WorstNumber WholePart
        {
            get
            {
                int decimalIdx = value.IndexOf('.');
                if (decimalIdx == -1)
                {
                    if (IsNegative)
                    {
                        return new WorstNumber(value.Substring(1));
                    }
                    return this;
                }

                if (IsNegative)
                {
                    return new WorstNumber(value.Substring(1, decimalIdx - 1));
                }

                return new WorstNumber(value.Substring(0, decimalIdx));
            }
        }

        private WorstNumber FractionPart
        {
            get
            {
                int decimalIdx = value.IndexOf('.');
                if (decimalIdx == -1)
                {
                    return null;
                }

                return new WorstNumber(value.Substring(decimalIdx + 1));
            }
        }

        private WorstNumber Negate
        {
            get
            {
                if (IsNegative)
                {
                    return new WorstNumber(value.Substring(1));
                }
                return new WorstNumber("-" + value);
            }
        }

        private WorstNumber clone()
        {
            return new WorstNumber(this.value);
        }

        private static bool isNumber(string value)
        {
            Regex regex = new Regex("^-?[0-9]+\\.?[0-9]*$");
            return regex.IsMatch(value);
        }

        // Yeah, let's do some implicit casting to our new type, but explicit casting away,
        // so people might not even realize they are working with darkness... until it's too late
        // and it's alreaedy insinuated its way through the codebase.
        // It's okay, we'll get to the refactoring next year. (No you won't)
        public static implicit operator WorstNumber(int value) => new WorstNumber(value);
        public static explicit operator int(WorstNumber value) => (int)double.Parse(value.ToString());
        public static implicit operator WorstNumber(double value) => new WorstNumber(value);
        public static explicit operator double(WorstNumber value) => double.Parse(value.ToString());
        public static implicit operator WorstNumber(string value) => new WorstNumber(value);
        public static implicit operator string(WorstNumber value) => value.ToString();


        public static WorstNumber operator ++(WorstNumber a)
        {
            return a + "1";
        }

        public override bool Equals(object obj)
        {
            return this.ToString().Equals(obj.ToString());
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
    }
}
