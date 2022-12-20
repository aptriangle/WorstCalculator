using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorstMath
{
    public partial class WorstNumber
    {
        public static WorstNumber operator +(WorstNumber a, WorstNumber b)
        {
            if (a.IsNegative && b.IsNegative)
            {
                return (a.Negate + b.Negate).Negate;
            }
            if (a.IsNegative)
            {
                return b - a.Negate;
            }
            if (b.IsNegative)
            {
                return a - b.Negate;
            }

            WorstNumber previous = null;
            WorstNumber aWhole = a.WholePart;
            WorstNumber bWhole = b.WholePart;
            WorstNumber aFraction = a.FractionPart;
            WorstNumber bFraction = b.FractionPart;
            int wholeLength = Math.Max(aWhole.length, bWhole.length) + 1;
            int fractionLength;
            if (aFraction is null && bFraction is null)
            {
                fractionLength = 0;
            }
            else if (aFraction is null)
            {
                fractionLength = bFraction.length;
            }
            else if (bFraction is null)
            {
                fractionLength = aFraction.length;
            }
            else
            {
                fractionLength = Math.Max(aFraction.length, bFraction.length);
            }
            string result = "";

            WorstNumber digitA;
            WorstNumber digitB;
            WorstNumber singleDigitSum;

            for (int i = -fractionLength - 1; i <= wholeLength; i++)
            {
                if (i < 0)
                {
                    int fractionIndex = -i - 1;
                    if (aFraction != null && aFraction.length > fractionIndex)
                    {
                        digitA = aFraction[fractionIndex];
                    }
                    else
                    {
                        digitA = null;
                    }
                    if (bFraction != null && bFraction.length > fractionIndex)
                    {
                        digitB = bFraction[fractionIndex];
                    }
                    else
                    {
                        digitB = null;
                    }
                }
                else
                {
                    if (aWhole.length > i)
                    {
                        digitA = aWhole[aWhole.length - 1 - i];
                    }
                    else
                    {
                        digitA = null;
                    }
                    if (bWhole.length > i)
                    {
                        digitB = bWhole[bWhole.length - 1 - i];
                    }
                    else
                    {
                        digitB = null;
                    }
                }

                if (i == 0 && result.Length > 0)
                {
                    result = '.' + result;
                }

                if (digitA is null && digitB is null)
                {
                    if (previous is null || previous.length < 2)
                    {
                        continue;
                    }
                    singleDigitSum = "0";
                }
                else if (digitA is null)
                {
                    singleDigitSum = digitB;
                }
                else if (digitB is null)
                {
                    singleDigitSum = digitA;
                }
                else
                {
                    singleDigitSum = addSingleDigit(digitA, digitB);
                }

                if (!(previous is null) && previous.length > 1)
                {
                    singleDigitSum[singleDigitSum.length - 1] = addSingleDigit(singleDigitSum[singleDigitSum.length - 1], "1");
                }

                result = singleDigitSum[singleDigitSum.length - 1].ToString() + result;

                previous = singleDigitSum;
            }
            WorstNumber num = new WorstNumber(result);
            num.ClipLeadingZeros();
            return num;
        }
    }
}
