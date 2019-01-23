using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            // Default to using the number.
            string result = number.ToString();

            bool divisibleBy3 = (0 == (number % 3));
            bool contains3 = result.Contains("3");
            bool isFizz = (divisibleBy3 || contains3);
            bool divisibleBy5 = (0 == (number % 5));
            bool contains5 = result.Contains("5");
            bool isBuzz = (divisibleBy5 || contains5);
            bool isDeluxe = ((divisibleBy3 && contains3) || (divisibleBy5 && contains5));
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
                if (1 == (number % 2))
                {
                    result += "fake ";
                }
                result += "deluxe";
            }

            return result;
        }
    }
}
