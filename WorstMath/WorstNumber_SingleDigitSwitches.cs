using System;

namespace WorstMath
{
    /// <summary>
    /// This part of the class implements the basic math operations for single digits.
    /// It uses nested switch statements because I'm not going to cheat and subtract the char code of "0" or use the index of an array of numbers.
    /// Oh yes, this class is strings (and pure evil) all the way down. 
    /// </summary>
    public partial class WorstNumber
    {
        private static void checkSingleDigit(WorstNumber a, WorstNumber b)
        {
            checkSingleDigit(a);
            checkSingleDigit(b);
        }
        private static void checkSingleDigit(WorstNumber a)
        {
            if (a.length != 1)
            {
                throw new InvalidOperationException("single digit operation was passed a WorstNumber with a length greater than 1");
            }
        }

        private static WorstNumber tenMinusSingleDigit(WorstNumber a)
        {
            checkSingleDigit(a);
            switch (a.value[0])
            {
                case '0':
                    return new WorstNumber("10");
                case '1':
                    return new WorstNumber("9");
                case '2':
                    return new WorstNumber("8");
                case '3':
                    return new WorstNumber("7");
                case '4':
                    return new WorstNumber("6");
                case '5':
                    return new WorstNumber("5");
                case '6':
                    return new WorstNumber("4");
                case '7':
                    return new WorstNumber("3");
                case '8':
                    return new WorstNumber("2");
                case '9':
                    return new WorstNumber("1");
            }
            throw new InvalidOperationException("Single digit (10 - a) failed");
        }

        private static WorstNumber subtractSingleDigit(WorstNumber a, WorstNumber b)
        {
            checkSingleDigit(a, b);
            switch (a.value[0])
            {
                case '0':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("-1");
                        case '2':
                            return new WorstNumber("-2");
                        case '3':
                            return new WorstNumber("-3");
                        case '4':
                            return new WorstNumber("-4");
                        case '5':
                            return new WorstNumber("-5");
                        case '6':
                            return new WorstNumber("-6");
                        case '7':
                            return new WorstNumber("-7");
                        case '8':
                            return new WorstNumber("-8");
                        case '9':
                            return new WorstNumber("-9");
                    }
                    break;
                case '1':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("1");
                        case '1':
                            return new WorstNumber("0");
                        case '2':
                            return new WorstNumber("-1");
                        case '3':
                            return new WorstNumber("-2");
                        case '4':
                            return new WorstNumber("-3");
                        case '5':
                            return new WorstNumber("-4");
                        case '6':
                            return new WorstNumber("-5");
                        case '7':
                            return new WorstNumber("-6");
                        case '8':
                            return new WorstNumber("-7");
                        case '9':
                            return new WorstNumber("-8");
                    }
                    break;
                case '2':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("2");
                        case '1':
                            return new WorstNumber("1");
                        case '2':
                            return new WorstNumber("0");
                        case '3':
                            return new WorstNumber("-1");
                        case '4':
                            return new WorstNumber("-2");
                        case '5':
                            return new WorstNumber("-3");
                        case '6':
                            return new WorstNumber("-4");
                        case '7':
                            return new WorstNumber("-5");
                        case '8':
                            return new WorstNumber("-6");
                        case '9':
                            return new WorstNumber("-7");
                    }
                    break;
                case '3':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("3");
                        case '1':
                            return new WorstNumber("2");
                        case '2':
                            return new WorstNumber("1");
                        case '3':
                            return new WorstNumber("0");
                        case '4':
                            return new WorstNumber("-1");
                        case '5':
                            return new WorstNumber("-2");
                        case '6':
                            return new WorstNumber("-3");
                        case '7':
                            return new WorstNumber("-4");
                        case '8':
                            return new WorstNumber("-5");
                        case '9':
                            return new WorstNumber("-6");
                    }
                    break;
                case '4':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("4");
                        case '1':
                            return new WorstNumber("3");
                        case '2':
                            return new WorstNumber("2");
                        case '3':
                            return new WorstNumber("1");
                        case '4':
                            return new WorstNumber("0");
                        case '5':
                            return new WorstNumber("-1");
                        case '6':
                            return new WorstNumber("-2");
                        case '7':
                            return new WorstNumber("-3");
                        case '8':
                            return new WorstNumber("-4");
                        case '9':
                            return new WorstNumber("-5");
                    }
                    break;
                case '5':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("5");
                        case '1':
                            return new WorstNumber("4");
                        case '2':
                            return new WorstNumber("3");
                        case '3':
                            return new WorstNumber("2");
                        case '4':
                            return new WorstNumber("1");
                        case '5':
                            return new WorstNumber("0");
                        case '6':
                            return new WorstNumber("-1");
                        case '7':
                            return new WorstNumber("-2");
                        case '8':
                            return new WorstNumber("-3");
                        case '9':
                            return new WorstNumber("-4");
                    }
                    break;
                case '6':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("6");
                        case '1':
                            return new WorstNumber("5");
                        case '2':
                            return new WorstNumber("4");
                        case '3':
                            return new WorstNumber("3");
                        case '4':
                            return new WorstNumber("2");
                        case '5':
                            return new WorstNumber("1");
                        case '6':
                            return new WorstNumber("0");
                        case '7':
                            return new WorstNumber("-1");
                        case '8':
                            return new WorstNumber("-2");
                        case '9':
                            return new WorstNumber("-3");
                    }
                    break;
                case '7':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("7");
                        case '1':
                            return new WorstNumber("6");
                        case '2':
                            return new WorstNumber("5");
                        case '3':
                            return new WorstNumber("4");
                        case '4':
                            return new WorstNumber("3");
                        case '5':
                            return new WorstNumber("2");
                        case '6':
                            return new WorstNumber("1");
                        case '7':
                            return new WorstNumber("0");
                        case '8':
                            return new WorstNumber("-1");
                        case '9':
                            return new WorstNumber("-2");
                    }
                    break;
                case '8':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("8");
                        case '1':
                            return new WorstNumber("7");
                        case '2':
                            return new WorstNumber("6");
                        case '3':
                            return new WorstNumber("5");
                        case '4':
                            return new WorstNumber("4");
                        case '5':
                            return new WorstNumber("3");
                        case '6':
                            return new WorstNumber("2");
                        case '7':
                            return new WorstNumber("1");
                        case '8':
                            return new WorstNumber("0");
                        case '9':
                            return new WorstNumber("-1");
                    }
                    break;
                case '9':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("9");
                        case '1':
                            return new WorstNumber("8");
                        case '2':
                            return new WorstNumber("7");
                        case '3':
                            return new WorstNumber("6");
                        case '4':
                            return new WorstNumber("5");
                        case '5':
                            return new WorstNumber("4");
                        case '6':
                            return new WorstNumber("3");
                        case '7':
                            return new WorstNumber("2");
                        case '8':
                            return new WorstNumber("1");
                        case '9':
                            return new WorstNumber("0");
                    }
                    break;
            }
            throw new InvalidOperationException("Single digit addition failed");
        }

        private static WorstNumber addSingleDigit(WorstNumber a, WorstNumber b)
        {
            checkSingleDigit(a, b);
            switch (a.value[0])
            {
                case '0':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("1");
                        case '2':
                            return new WorstNumber("2");
                        case '3':
                            return new WorstNumber("3");
                        case '4':
                            return new WorstNumber("4");
                        case '5':
                            return new WorstNumber("5");
                        case '6':
                            return new WorstNumber("6");
                        case '7':
                            return new WorstNumber("7");
                        case '8':
                            return new WorstNumber("8");
                        case '9':
                            return new WorstNumber("9");
                    }
                    break;
                case '1':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("1");
                        case '1':
                            return new WorstNumber("2");
                        case '2':
                            return new WorstNumber("3");
                        case '3':
                            return new WorstNumber("4");
                        case '4':
                            return new WorstNumber("5");
                        case '5':
                            return new WorstNumber("6");
                        case '6':
                            return new WorstNumber("7");
                        case '7':
                            return new WorstNumber("8");
                        case '8':
                            return new WorstNumber("9");
                        case '9':
                            return new WorstNumber("10");
                    }
                    break;
                case '2':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("2");
                        case '1':
                            return new WorstNumber("3");
                        case '2':
                            return new WorstNumber("4");
                        case '3':
                            return new WorstNumber("5");
                        case '4':
                            return new WorstNumber("6");
                        case '5':
                            return new WorstNumber("7");
                        case '6':
                            return new WorstNumber("8");
                        case '7':
                            return new WorstNumber("9");
                        case '8':
                            return new WorstNumber("10");
                        case '9':
                            return new WorstNumber("11");
                    }
                    break;
                case '3':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("3");
                        case '1':
                            return new WorstNumber("4");
                        case '2':
                            return new WorstNumber("5");
                        case '3':
                            return new WorstNumber("6");
                        case '4':
                            return new WorstNumber("7");
                        case '5':
                            return new WorstNumber("8");
                        case '6':
                            return new WorstNumber("9");
                        case '7':
                            return new WorstNumber("10");
                        case '8':
                            return new WorstNumber("11");
                        case '9':
                            return new WorstNumber("12");
                    }
                    break;
                case '4':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("4");
                        case '1':
                            return new WorstNumber("5");
                        case '2':
                            return new WorstNumber("6");
                        case '3':
                            return new WorstNumber("7");
                        case '4':
                            return new WorstNumber("8");
                        case '5':
                            return new WorstNumber("9");
                        case '6':
                            return new WorstNumber("10");
                        case '7':
                            return new WorstNumber("11");
                        case '8':
                            return new WorstNumber("12");
                        case '9':
                            return new WorstNumber("13");
                    }
                    break;
                case '5':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("5");
                        case '1':
                            return new WorstNumber("6");
                        case '2':
                            return new WorstNumber("7");
                        case '3':
                            return new WorstNumber("8");
                        case '4':
                            return new WorstNumber("9");
                        case '5':
                            return new WorstNumber("10");
                        case '6':
                            return new WorstNumber("11");
                        case '7':
                            return new WorstNumber("12");
                        case '8':
                            return new WorstNumber("13");
                        case '9':
                            return new WorstNumber("14");
                    }
                    break;
                case '6':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("6");
                        case '1':
                            return new WorstNumber("7");
                        case '2':
                            return new WorstNumber("8");
                        case '3':
                            return new WorstNumber("9");
                        case '4':
                            return new WorstNumber("10");
                        case '5':
                            return new WorstNumber("11");
                        case '6':
                            return new WorstNumber("12");
                        case '7':
                            return new WorstNumber("13");
                        case '8':
                            return new WorstNumber("14");
                        case '9':
                            return new WorstNumber("15");
                    }
                    break;
                case '7':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("7");
                        case '1':
                            return new WorstNumber("8");
                        case '2':
                            return new WorstNumber("9");
                        case '3':
                            return new WorstNumber("10");
                        case '4':
                            return new WorstNumber("11");
                        case '5':
                            return new WorstNumber("12");
                        case '6':
                            return new WorstNumber("13");
                        case '7':
                            return new WorstNumber("14");
                        case '8':
                            return new WorstNumber("15");
                        case '9':
                            return new WorstNumber("16");
                    }
                    break;
                case '8':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("8");
                        case '1':
                            return new WorstNumber("9");
                        case '2':
                            return new WorstNumber("10");
                        case '3':
                            return new WorstNumber("11");
                        case '4':
                            return new WorstNumber("12");
                        case '5':
                            return new WorstNumber("13");
                        case '6':
                            return new WorstNumber("14");
                        case '7':
                            return new WorstNumber("15");
                        case '8':
                            return new WorstNumber("16");
                        case '9':
                            return new WorstNumber("17");
                    }
                    break;
                case '9':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("9");
                        case '1':
                            return new WorstNumber("10");
                        case '2':
                            return new WorstNumber("11");
                        case '3':
                            return new WorstNumber("12");
                        case '4':
                            return new WorstNumber("13");
                        case '5':
                            return new WorstNumber("14");
                        case '6':
                            return new WorstNumber("15");
                        case '7':
                            return new WorstNumber("16");
                        case '8':
                            return new WorstNumber("17");
                        case '9':
                            return new WorstNumber("18");
                    }
                    break;
            }
            throw new InvalidOperationException("Single digit addition failed");
        }

        private static bool isSmallerSingleDigit(WorstNumber a, WorstNumber b)
        {
            checkSingleDigit(a, b);
            return !isLargerSingleDigit(a, b) && !isEqualSingleDigit(a, b);
        }

        private static bool isLargerSingleDigit(WorstNumber a, WorstNumber b)
        {
            checkSingleDigit(a, b);
            switch (a.value[0])
            {
                case '0':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return true;
                        case '2':
                            return true;
                        case '3':
                            return true;
                        case '4':
                            return true;
                        case '5':
                            return true;
                        case '6':
                            return true;
                        case '7':
                            return true;
                        case '8':
                            return true;
                        case '9':
                            return true;
                    }
                    break;
                case '1':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return true;
                        case '3':
                            return true;
                        case '4':
                            return true;
                        case '5':
                            return true;
                        case '6':
                            return true;
                        case '7':
                            return true;
                        case '8':
                            return true;
                        case '9':
                            return true;
                    }
                    break;
                case '2':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return true;
                        case '4':
                            return true;
                        case '5':
                            return true;
                        case '6':
                            return true;
                        case '7':
                            return true;
                        case '8':
                            return true;
                        case '9':
                            return true;
                    }
                    break;
                case '3':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return true;
                        case '5':
                            return true;
                        case '6':
                            return true;
                        case '7':
                            return true;
                        case '8':
                            return true;
                        case '9':
                            return true;
                    }
                    break;
                case '4':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return true;
                        case '6':
                            return true;
                        case '7':
                            return true;
                        case '8':
                            return true;
                        case '9':
                            return true;
                    }
                    break;
                case '5':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return true;
                        case '7':
                            return true;
                        case '8':
                            return true;
                        case '9':
                            return true;
                    }
                    break;
                case '6':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return true;
                        case '8':
                            return true;
                        case '9':
                            return true;
                    }
                    break;
                case '7':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return true;
                        case '9':
                            return true;
                    }
                    break;
                case '8':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return false;
                        case '9':
                            return true;
                    }
                    break;
                case '9':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return false;
                        case '9':
                            return false;
                    }
                    break;
            }
            throw new InvalidOperationException("Single digit addition failed");
        }

        private static bool isEqualSingleDigit(WorstNumber a, WorstNumber b)
        {
            checkSingleDigit(a, b);
            switch (a.value[0])
            {
                case '0':
                    switch (b.value[0])
                    {
                        case '0':
                            return true;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return false;
                        case '9':
                            return false;
                    }
                    break;
                case '1':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return true;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return false;
                        case '9':
                            return false;
                    }
                    break;
                case '2':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return true;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return false;
                        case '9':
                            return false;
                    }
                    break;
                case '3':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return true;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return false;
                        case '9':
                            return false;
                    }
                    break;
                case '4':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return true;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return false;
                        case '9':
                            return false;
                    }
                    break;
                case '5':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return true;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return false;
                        case '9':
                            return false;
                    }
                    break;
                case '6':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return true;
                        case '7':
                            return false;
                        case '8':
                            return false;
                        case '9':
                            return false;
                    }
                    break;
                case '7':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return true;
                        case '8':
                            return false;
                        case '9':
                            return false;
                    }
                    break;
                case '8':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return true;
                        case '9':
                            return false;
                    }
                    break;
                case '9':
                    switch (b.value[0])
                    {
                        case '0':
                            return false;
                        case '1':
                            return false;
                        case '2':
                            return false;
                        case '3':
                            return false;
                        case '4':
                            return false;
                        case '5':
                            return false;
                        case '6':
                            return false;
                        case '7':
                            return false;
                        case '8':
                            return false;
                        case '9':
                            return true;
                    }
                    break;
            }
            throw new InvalidOperationException("Single digit addition failed");
        }

        private static WorstNumber multiplySingleDigit(WorstNumber a, WorstNumber b)
        {
            checkSingleDigit(a, b);
            switch (a.value[0])
            {
                case '0':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("0");
                        case '2':
                            return new WorstNumber("0");
                        case '3':
                            return new WorstNumber("0");
                        case '4':
                            return new WorstNumber("0");
                        case '5':
                            return new WorstNumber("0");
                        case '6':
                            return new WorstNumber("0");
                        case '7':
                            return new WorstNumber("0");
                        case '8':
                            return new WorstNumber("0");
                        case '9':
                            return new WorstNumber("0");
                    }
                    break;
                case '1':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("1");
                        case '2':
                            return new WorstNumber("2");
                        case '3':
                            return new WorstNumber("3");
                        case '4':
                            return new WorstNumber("4");
                        case '5':
                            return new WorstNumber("5");
                        case '6':
                            return new WorstNumber("6");
                        case '7':
                            return new WorstNumber("7");
                        case '8':
                            return new WorstNumber("8");
                        case '9':
                            return new WorstNumber("9");
                    }
                    break;
                case '2':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("2");
                        case '2':
                            return new WorstNumber("4");
                        case '3':
                            return new WorstNumber("6");
                        case '4':
                            return new WorstNumber("8");
                        case '5':
                            return new WorstNumber("10");
                        case '6':
                            return new WorstNumber("12");
                        case '7':
                            return new WorstNumber("14");
                        case '8':
                            return new WorstNumber("16");
                        case '9':
                            return new WorstNumber("18");
                    }
                    break;
                case '3':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("3");
                        case '2':
                            return new WorstNumber("6");
                        case '3':
                            return new WorstNumber("9");
                        case '4':
                            return new WorstNumber("12");
                        case '5':
                            return new WorstNumber("15");
                        case '6':
                            return new WorstNumber("18");
                        case '7':
                            return new WorstNumber("21");
                        case '8':
                            return new WorstNumber("24");
                        case '9':
                            return new WorstNumber("27");
                    }
                    break;
                case '4':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("4");
                        case '2':
                            return new WorstNumber("8");
                        case '3':
                            return new WorstNumber("12");
                        case '4':
                            return new WorstNumber("16");
                        case '5':
                            return new WorstNumber("20");
                        case '6':
                            return new WorstNumber("24");
                        case '7':
                            return new WorstNumber("28");
                        case '8':
                            return new WorstNumber("32");
                        case '9':
                            return new WorstNumber("36");
                    }
                    break;
                case '5':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("5");
                        case '2':
                            return new WorstNumber("10");
                        case '3':
                            return new WorstNumber("15");
                        case '4':
                            return new WorstNumber("20");
                        case '5':
                            return new WorstNumber("25");
                        case '6':
                            return new WorstNumber("30");
                        case '7':
                            return new WorstNumber("35");
                        case '8':
                            return new WorstNumber("40");
                        case '9':
                            return new WorstNumber("45");
                    }
                    break;
                case '6':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("6");
                        case '2':
                            return new WorstNumber("12");
                        case '3':
                            return new WorstNumber("18");
                        case '4':
                            return new WorstNumber("24");
                        case '5':
                            return new WorstNumber("30");
                        case '6':
                            return new WorstNumber("36");
                        case '7':
                            return new WorstNumber("42");
                        case '8':
                            return new WorstNumber("48");
                        case '9':
                            return new WorstNumber("54");
                    }
                    break;
                case '7':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("7");
                        case '2':
                            return new WorstNumber("14");
                        case '3':
                            return new WorstNumber("21");
                        case '4':
                            return new WorstNumber("28");
                        case '5':
                            return new WorstNumber("35");
                        case '6':
                            return new WorstNumber("42");
                        case '7':
                            return new WorstNumber("49");
                        case '8':
                            return new WorstNumber("56");
                        case '9':
                            return new WorstNumber("63");
                    }
                    break;
                case '8':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("8");
                        case '2':
                            return new WorstNumber("16");
                        case '3':
                            return new WorstNumber("24");
                        case '4':
                            return new WorstNumber("32");
                        case '5':
                            return new WorstNumber("40");
                        case '6':
                            return new WorstNumber("48");
                        case '7':
                            return new WorstNumber("56");
                        case '8':
                            return new WorstNumber("64");
                        case '9':
                            return new WorstNumber("72");
                    }
                    break;
                case '9':
                    switch (b.value[0])
                    {
                        case '0':
                            return new WorstNumber("0");
                        case '1':
                            return new WorstNumber("9");
                        case '2':
                            return new WorstNumber("18");
                        case '3':
                            return new WorstNumber("27");
                        case '4':
                            return new WorstNumber("36");
                        case '5':
                            return new WorstNumber("45");
                        case '6':
                            return new WorstNumber("54");
                        case '7':
                            return new WorstNumber("63");
                        case '8':
                            return new WorstNumber("72");
                        case '9':
                            return new WorstNumber("81");
                    }
                    break;
            }
            throw new InvalidOperationException("Single digit multiplication failed");
        }
    }
}
