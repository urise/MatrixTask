using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Joker
    {
        private class Card
        {
            public long CardType { get; set; }
            public long Count { get; set; }
        }

        public static long GetNumberOfDecks(long jokersInitialCount, IEnumerable<long> cardsCounts)
        {
            var cardType = 1;
            var cards = cardsCounts.Select(cnt => new Card { CardType = cardType++, Count = cnt }).ToList();
            cards.Sort((card1, card2) => card1.Count.CompareTo(card2.Count));
            long result = 0, jokersCount = jokersInitialCount;
            if (cards.Count == 1)
            {
                return jokersInitialCount + cards[0].Count;
            }

            long diff = Math.Min(jokersInitialCount, cards[1].Count - cards[0].Count);
            if (diff > 0)
            {
                result += diff;
                for (int i = 1; i < cards.Count; i++) cards[i].Count -= diff;
                jokersCount -= diff;
            }

            if (jokersCount == 0) return result + cards[0].Count;

            int equals = 1;
            for (int i = 1; i < cards.Count; i++)
            {
                if (cards[i].Count != cards[0].Count) break;
                equals++;
            }

            long n = Math.Min(jokersCount, cards[0].Count*equals);
            return result + n + cards[0].Count - n/equals;
        }
    }
}
