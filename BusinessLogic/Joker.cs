using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Joker
    {
        public static long GetNumberOfDecks(long jokersInitialCount, long[] cards)
        {
            if (cards.Length == 1)
            {
                return jokersInitialCount + cards[0];
            }

            long min = Math.Min(cards[0], cards[1]);
            long min2 = Math.Max(cards[0], cards[1]);
            int min2quantity = 1;

            for (int i = 2; i < cards.Length; i++)
            {
                if (cards[i] < min) min = cards[i];
                else if (cards[i] == min2) min2quantity++;
                else if (cards[i] < min2)
                {
                    min2 = cards[i];
                    min2quantity = 1;
                }
            }
            long result = 0, jokersCount = jokersInitialCount;

            long diff = Math.Min(jokersCount, min2 - min);
            if (diff > 0)
            {
                result += diff;
                jokersCount -= diff;
            }

            if (jokersCount == 0) return result + min;

            long n = Math.Min(jokersCount, min*(min2quantity+1));
            return result + n + min - 1 - (n-1)/(min2quantity+1);
        }
    }
}
