using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public static class Garmonic
    {
        public static int CountNumbersLessOf(int n, int matrixSize)
        {
            int sq = Convert.ToInt32(Math.Sqrt((double) n));
            int result = n - sq;
            for (int i = 0; i <= sq; i++) result += n / i;
            return result;
        }
    }
}
