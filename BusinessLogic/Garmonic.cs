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

        public static Int64 Search(int n, int matrixSize)
        {
            var fullSize = matrixSize*matrixSize;
            if (n >= fullSize) return fullSize;
            Int64 a = 1, b = fullSize;
            while (b - a > 1)
            {
                Int64 middle = a + (b - a)/2;
                if (middle == a) middle = a + 1;
                Int64 cnt = CountNumbersLessOrEqualThan(middle, matrixSize);
                if (cnt == n) return middle;
                if (cnt < n)
                {
                    a = middle;
                }
                else
                {
                    b = middle;
                }
            }
            return a;
        }
    }
}
