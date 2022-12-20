using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorstMath
{
    public partial class WorstNumber
    {
        public static WorstNumber HighestSignificantDigit(WorstNumber worstNumber)
        {
            WorstNumber whole = worstNumber.WholePart;
            if (whole.length > 1)
            {
                return whole.length - 1;
            }

            if (whole != "0")
            {
                return "0";
            }

            WorstNumber fraction = worstNumber.FractionPart;
            for (int i = 0; i < fraction.length; i++)
            {
                if (fraction[i] != 0)
                {
                    return -1 - i;
                }
            }
            return "0";
        }
        public static WorstNumber operator /(WorstNumber a, WorstNumber b)
        {
            if (a.IsNegative && b.IsNegative)
            {
                return a.Negate / b.Negate;
            }
            if (a.IsNegative)
            {
                return (a.Negate / b).Negate;
            }
            if (b.IsNegative)
            {
                return (a / b.Negate).Negate;
            }
            if (b == "0")
            {
                throw new InvalidOperationException("Cannot divide by zero");
            }
            if (a == "0")
            {
                return "0";
            }
            if (a == b)
            {
                return "1";
            }
            WorstNumber aWhole = a.WholePart;
            WorstNumber bWhole = b.WholePart;
            WorstNumber aFraction = a.FractionPart;
            WorstNumber bFraction = b.FractionPart;

            // int digitIndex

            WorstNumber[] multiples = new WorstNumber[] { "9", "8", "7", "6", "5", "4", "3", "2", "1" };

            WorstNumber shift = HighestSignificantDigit(a) - HighestSignificantDigit(b);
            WorstNumber remainder = a.clone();
            WorstNumber result = new WorstNumber("0");
            bool complete = false;
            // a hard limit to prevent infinite loops
            int limit = 10;
            while (!complete)
            {
                WorstNumber bShifted = b.ShiftOrder((int)shift);
                for (int i = 0; i < multiples.Length; i++)
                {
                    WorstNumber comparison = bShifted * multiples[i];
                    if (comparison <= remainder)
                    {
                        result = result + multiples[i].ShiftOrder((int)shift);
                        remainder = remainder - comparison;
                        break;
                    }
                }
                limit--;
                shift = shift - "1";
                if (remainder == "0")
                {
                    complete = true;
                }
                if (limit < 0)
                {
                    complete = true;
                }
            }

            return result;
        }
    }
}
