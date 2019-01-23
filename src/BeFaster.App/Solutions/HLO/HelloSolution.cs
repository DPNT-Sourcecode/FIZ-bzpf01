using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.HLO
{
    public static class HelloSolution
    {
        public static string Hello(string friendName)
        {
            if (string.IsNullOrWhiteSpace(friendName)) { throw new System.ArgumentNullException(nameof(friendName)); }

            return string.Format("Hello, {0}!", friendName);
        }
    }
}



