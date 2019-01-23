using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            // Default to using the number.
            string result = number.ToString();

            bool isFizz = (0 == (number % 3));
            bool isBuzz = (0 == (number % 5));
            if(isFizz)
            {
                result = "fizz";
            }
            if(isBuzz)
            {
                if (isFizz)
                {
                    result += " ";
                }
                else
                {
                    result = string.Empty;
                }

                result += "buzz";
            }

            return result;
        }
    }
}

