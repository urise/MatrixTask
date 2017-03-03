using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Garmonic
    {
        public static long CountNumbersLessOrEqualThan(long n, long matrixSize)
        {
            long half = Math.Min(n/2, matrixSize);
            long result = Math.Min(n, matrixSize) - half;
            for (long i = 1; i <= half; i++) result += Math.Min(n / i, matrixSize);
            return result;
        }

        public static long CorrectNumber(long n, long matrixSize)
        {
            long correctedResult = 0;
            for (long i = 1; i <= matrixSize; i++)
            {
                if (n/i > matrixSize) continue;
                if (n%i == 0)  return n;
                correctedResult = Math.Max(correctedResult, n/i*i);
            }
            return correctedResult;
        }

        public static long Search(long n, long matrixSize)
        {
            var fullSize = matrixSize*matrixSize;
            if (n == 1) return 1;
            if (n >= fullSize) return fullSize;
            long a = 1, b = fullSize;
            while (b - a > 1)
            {
                long middle = a + (b - a)/2;
                if (middle == a) middle = a + 1;
                long cnt = CountNumbersLessOrEqualThan(middle, matrixSize);
                if (cnt == n) return CorrectNumber(middle, matrixSize);
                if (cnt < n)
                {
                    a = middle;
                }
                else
                {
                    b = middle;
                }
            }
            return CorrectNumber(b, matrixSize);
        }
    }
}
