using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorstMath
{
    public partial class WorstNumber
    {
        public static WorstNumber operator -(WorstNumber a, WorstNumber b)
        {
            // -a - -b = b - a
            if (a.IsNegative && b.IsNegative)
            {
                return b.Negate - a.Negate;
            }
            // -a - b = -(a + b)
            if (a.IsNegative)
            {
                return (a.Negate + b).Negate;
            }
            // a - -b = a + b
            if (b.IsNegative)
            {
                return a + b.Negate;
            }

            if (a < b)
            {
                return (b - a).Negate;
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
            WorstNumber singleDigitSubtraction;

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
                    singleDigitSubtraction = "0";
                }
                else if (digitA is null)
                {
                    singleDigitSubtraction = subtractSingleDigit("0", digitB);
                }
                else if (digitB is null)
                {
                    singleDigitSubtraction = digitA;
                }
                else
                {
                    singleDigitSubtraction = subtractSingleDigit(digitA, digitB);
                }

                if (!(previous is null) && previous.IsNegative)
                {
                    if (singleDigitSubtraction.IsNegative)
                    {
                        singleDigitSubtraction = addSingleDigit(singleDigitSubtraction.Negate, "1").Negate;
                    }
                    else
                    {
                        singleDigitSubtraction = subtractSingleDigit(singleDigitSubtraction, "1");
                    }
                }

                WorstNumber appendValue = singleDigitSubtraction;
                if (appendValue.IsNegative)
                {
                    appendValue = tenMinusSingleDigit(appendValue[appendValue.length - 1]);
                }

                result = appendValue[appendValue.length - 1].ToString() + result;

                previous = singleDigitSubtraction;
            }
            result = result.Trim(new char['0']);

            return new WorstNumber(result);
        }
    }
}
