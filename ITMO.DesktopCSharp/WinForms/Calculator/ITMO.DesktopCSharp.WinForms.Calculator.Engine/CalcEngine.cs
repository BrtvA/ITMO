using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.DesktopCSharp.WinForms.Calculator.Engine
{
    public class CalcEngine
    {
        //
        // Operation Constants.
        //
        public enum Operator : int
        {
            eUnknown = 0,
            eAdd = 1,
            eSubtract = 2,
            eMultiply = 3,
            eDivide = 4,
            eExponentiation = 5,
            eSquare = 6,
            eSqrt = 7,
            eCubrt = 8,
            eInverse = 9,
            eFactorial = 10
        }

        //
        // Module-Level Constants
        //

        private static double negativeConverter = -1;
        // TODO: Upgrade the version number to 3.0.1.1
        private static string versionInfo = "Calculator v3.0.1.1";

        //
        // Module-level Variables.
        //

        private static double numericAnswer;
        private static string stringAnswer;
        private static Operator calcOperation;
        private static double firstNumber;
        private static double secondNumber;
        private static bool secondNumberAdded;
        private static bool decimalAdded;
        ///private static bool simpleAction; //one variable

        //
        // Class Constructor.
        //

        public CalcEngine()
        {
            decimalAdded = false;
            secondNumberAdded = false;
        }

        //
        // Returns the custom version string to the caller.
        //

        public static string GetVersion()
        {
            return (versionInfo);
        }
        //
        // Called when the Date key is pressed.
        //

        public static string GetDate()
        {
            DateTime curDate = new DateTime();
            curDate = DateTime.Now;

            stringAnswer = String.Concat(curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

            return (stringAnswer);
        }

        //
        // Called when a number key is pressed on the keypad.
        //

        public static string CalcNumber(string KeyNumber)
        {
            stringAnswer = stringAnswer + KeyNumber;
            return (stringAnswer);
        }

        //
        // Called when an operator is selected (+, -, *, /, ^)
        //

        public static void CalcOperation(Operator calcOper)
        {
            if (stringAnswer != "" && !secondNumberAdded)
            {
                firstNumber = System.Convert.ToDouble(stringAnswer);
                calcOperation = calcOper;
                //stringAnswer = "";
                decimalAdded = false;
                if (((int)calcOper) <= 5)
                    stringAnswer = "";

            }
        }

        //
        // Called when the +/- key is pressed.
        //

        public static string CalcSign()
        {
            double numHold;

            if (stringAnswer != "")
            {
                numHold = System.Convert.ToDouble(stringAnswer);
                stringAnswer = System.Convert.ToString(numHold * negativeConverter);
            }

            return (stringAnswer);
        }

        //
        // Called when the . key is pressed.
        //

        public static string CalcDecimal()
        {
            if (!decimalAdded && !secondNumberAdded)
            {
                if (stringAnswer != "")
                    stringAnswer = stringAnswer + ",";
                else
                    stringAnswer = "0,";

                decimalAdded = true;
            }

            return (stringAnswer);
        }

        //
        // Called when = is pressed.
        //

        public static string CalcEqual()
        {
            bool validEquation = false;

            if (stringAnswer != "")
            {
                secondNumber = System.Convert.ToDouble(stringAnswer);
                secondNumberAdded = true;

                switch (calcOperation)
                {
                    case Operator.eUnknown:
                        validEquation = false;
                        break;

                    case Operator.eAdd:
                        numericAnswer = firstNumber + secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eSubtract:
                        numericAnswer = firstNumber - secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eMultiply:
                        numericAnswer = firstNumber * secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eDivide:
                        numericAnswer = firstNumber / secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eExponentiation:
                        numericAnswer = Math.Pow(firstNumber, secondNumber);
                        validEquation = true;
                        break;

                    case Operator.eSquare:
                        numericAnswer = Math.Pow(firstNumber, 2);
                        validEquation = true;
                        break;

                    case Operator.eSqrt:
                        numericAnswer = Math.Sqrt(firstNumber);
                        validEquation = true;
                        break;

                    case Operator.eCubrt:
                        numericAnswer = Math.Cbrt(firstNumber);
                        validEquation = true;
                        break;

                    case Operator.eInverse:
                        numericAnswer = 1 / firstNumber;
                        validEquation = true;
                        break;

                    case Operator.eFactorial:
                        numericAnswer = 1;
                        if (firstNumber != 0)
                            for (int i = 1; i <= firstNumber; i++)
                                numericAnswer *= i;
                        validEquation = true;
                        break;

                    default:
                        validEquation = false;
                        break;
                }

                if (validEquation)
                    stringAnswer = System.Convert.ToString(numericAnswer);
            }

            return (stringAnswer);
        }

        //
        //
        //

        public static string CalcQuadraticEquation(double a, double b, double c)
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return $"x1 = {Math.Round(x1, 3)} \n x2 = {Math.Round(x2,3)}";
        }

        //
        // Resets the various module-level variables for the next calculation.
        //

        public static void CalcReset()
        {
            numericAnswer = 0;
            firstNumber = 0;
            secondNumber = 0;
            stringAnswer = "";
            calcOperation = Operator.eUnknown;
            decimalAdded = false;
            secondNumberAdded = false;
        }
    }
}
