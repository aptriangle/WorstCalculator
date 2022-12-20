using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorstMath
{
    public partial class WorstNumber
    {
        public static WorstNumber operator *(WorstNumber a, WorstNumber b)
        {
            WorstNumber aWhole = a.WholePart;
            WorstNumber bWhole = b.WholePart;
            WorstNumber aFraction = a.FractionPart;
            WorstNumber bFraction = b.FractionPart;

            WorstNumber result = 0;

            for (int i = 0; i < aWhole.length; i++)
            {
                for (int k = 0; k < bWhole.length; k++)
                {
                    WorstNumber aDigit = aWhole[aWhole.length - 1 - i];
                    WorstNumber bDigit = bWhole[bWhole.length - 1 - k];

                    WorstNumber digit = multiplySingleDigit(aDigit, bDigit).ShiftOrder(i + k);

                    result = result + digit;
                }
                if (!(bFraction is null))
                {
                    for (int k = 0; k < bFraction.length; k++)
                    {
                        WorstNumber aDigit = aWhole[aWhole.length - 1 - i];
                        WorstNumber bDigit = bFraction[k];

                        WorstNumber digit = multiplySingleDigit(aDigit, bDigit).ShiftOrder(i - k - 1);

                        result = result + digit;
                    }

                }
            }
            if (!(aFraction is null))
            {
                for (int i = 0; i < aFraction.length; i++)
                {
                    for (int k = 0; k < bWhole.length; k++)
                    {
                        WorstNumber aDigit = aFraction[i];
                        WorstNumber bDigit = bWhole[bWhole.length - 1 - k];

                        WorstNumber digit = multiplySingleDigit(aDigit, bDigit).ShiftOrder(-i + k - 1);

                        result = result + digit;
                    }
                    if (!(bFraction is null))
                    {
                        for (int k = 0; k < bFraction.length; k++)
                        {
                            WorstNumber aDigit = aFraction[i];
                            WorstNumber bDigit = bFraction[k];

                            WorstNumber digit = multiplySingleDigit(aDigit, bDigit).ShiftOrder(-i - k - 2);

                            result = result + digit;
                        }
                    }
                }
            }

            if ((a.IsNegative && !b.IsNegative ) || (!a.IsNegative && b.IsNegative))
            {
                result = result.Negate;
            }
            result.ClipLeadingZeros();
            return result;
        }
    }
}
