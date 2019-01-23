using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.SUM
{
    public static class SumSolution
    {
        /// <summary>
        /// This would be done now.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Sum(int x, int y)
        {
            if ((x < 0) || (100 < x)) { throw new System.ArgumentOutOfRangeException(nameof(x)); }
            if ((y < 0) || (100 < y)) { throw new System.ArgumentOutOfRangeException(nameof(y)); }

            return (x + y);
        }
    }
}


