using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorstMath
{
    public partial class WorstNumber
    {
        public static WorstNumber Min(WorstNumber a, WorstNumber b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }

        public static WorstNumber Max(WorstNumber a, WorstNumber b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
    }
}
