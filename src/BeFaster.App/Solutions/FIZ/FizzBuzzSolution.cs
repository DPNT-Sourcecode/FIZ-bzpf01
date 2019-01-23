using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            // Default to using the number.
            string result = number.ToString();

            bool isFizz = ((0 == (number % 3)) || result.Contains("3"));
            bool isBuzz = ((0 == (number % 5)) || result.Contains("5"));
            bool isDeluxe = ((2 <= result.Length) && (result == (new string(result[0], result.Length))));
            if (isFizz)
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
            if (isDeluxe)
            {
                if (isFizz || isBuzz)
                {
                    result += " ";
                }
                else
                {
                    result = string.Empty;
                }

                result += "deluxe";
            }

            return result;
        }
    }
}
