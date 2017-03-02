using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Garmonic
    {
        public static Int64 CountNumbersLessOrEqualThan(Int64 n, int matrixSize)
        {
            Int64 half = Math.Min(n/2, matrixSize);
            Int64 result = Math.Min(n, matrixSize) - half;
            for (int i = 1; i <= half; i++) result += Math.Min(n / i, matrixSize);
            return result;
        }

        public static Int64 CorrectNumber(Int64 n, int matrixSize)
        {
            Int64 correctedResult = 0;
            for (Int64 i = 1; i <= matrixSize; i++)
            {
                if (n/i > matrixSize) continue;
                if (n%i == 0)  return n;
                correctedResult = Math.Max(correctedResult, n/i*i);
            }
            return correctedResult;
        }

        public static Int64 Search(int n, int matrixSize)
        {
            var fullSize = matrixSize*matrixSize;
            if (n == 1) return 1;
            if (n >= fullSize) return fullSize;
            Int64 a = 1, b = fullSize;
            while (b - a > 1)
            {
                Int64 middle = a + (b - a)/2;
                if (middle == a) middle = a + 1;
                Int64 cnt = CountNumbersLessOrEqualThan(middle, matrixSize);
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
