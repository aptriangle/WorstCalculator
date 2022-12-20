using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorstMath
{
    public partial class WorstNumber
    {
        public static bool operator ==(WorstNumber a, WorstNumber b)
        {
            if (a is null && b is null)
            {
                return true;
            }
            if (a is null || b is null)
            {
                return false;
            }
            if (a.IsNegative != b.IsNegative)
            {
                return false;
            }

            a.ClipLeadingZeros();
            b.ClipLeadingZeros();

            WorstNumber aPart = a.WholePart;
            WorstNumber bPart = b.WholePart;

            if (aPart.length != bPart.length)
            {
                return false;
            }

            for (int i = 0; i < aPart.length; i++)
            {
                if (!isEqualSingleDigit(aPart[i], bPart[i]))
                {
                    return false;
                }
            }

            aPart = a.FractionPart;
            bPart = b.FractionPart;

            if ((aPart is null) != (bPart is null))
            {
                return false;
            }

            if (aPart is null)
            {
                return true;
            }

            if (aPart.length != bPart.length)
            {
                return false;
            }

            for (int i = 0; i < aPart.length; i++)
            {
                if (!isEqualSingleDigit(aPart[i], bPart[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(WorstNumber a, WorstNumber b)
        {
            return !(a == b);
        }

        public static bool operator <(WorstNumber a, WorstNumber b)
        {
            if (a is null || b is null)
            {
                return false;
            }

            if (a.IsNegative && !b.IsNegative)
            {
                return true;
            }
            if (!a.IsNegative && b.IsNegative)
            {
                return false;
            }
            if (a.IsNegative && b.IsNegative)
            {
                return a.Negate > b.Negate;
            }

            a.ClipLeadingZeros();
            b.ClipLeadingZeros();


            WorstNumber aPart = a.WholePart;
            WorstNumber bPart = b.WholePart;

            if (aPart.length > bPart.length)
            {
                return false;
            }
            if (aPart.length < bPart.length)
            {
                return true;
            }

            for (int i = 0; i < aPart.length; i++)
            {
                if (isSmallerSingleDigit(aPart[i], bPart[i]))
                {
                    return false;
                }
                if (isLargerSingleDigit(aPart[i], bPart[i]))
                {
                    return true;
                }
            }

            aPart = a.FractionPart;
            bPart = b.FractionPart;

            if (bPart is null && aPart is null)
            {
                return false;
            }

            if (aPart is null && !(bPart is null))
            {
                return true;
            }

            if (bPart is null && !(aPart is null))
            {
                return false;
            }
            int fractionLength = Math.Max(aPart.length, bPart.length);

            for (int i = 0; i < fractionLength; i++)
            {
                if (aPart.length <= i)
                {
                    return true;
                }
                if (bPart.length <= i)
                {
                    return false;
                }
                if (isSmallerSingleDigit(aPart[i], bPart[i]))
                {
                    return false;
                }
                if (isLargerSingleDigit(aPart[i], bPart[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator >(WorstNumber a, WorstNumber b)
        {
            return !(a < b) && !(a == b);
        }

        public static bool operator <=(WorstNumber a, WorstNumber b)
        {
            return (a < b) || (a == b);
        }

        public static bool operator >=(WorstNumber a, WorstNumber b)
        {
            return (a > b) || (a == b);
        }
    }
}
