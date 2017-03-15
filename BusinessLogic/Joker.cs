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

        private static bool IsOver(long jokersCount, List<Card> cards)
        {
            if (cards.Count == 0) return true;
            if (cards.Count == 1) return cards[0].Count == 0 && jokersCount == 0;
            if (cards[0].Count == 0 && (cards[1].Count == 0 || jokersCount == 0)) return true;
            return false;
        }

        public static long GetNumberOfDecks(long jokersInitialCount, IEnumerable<long> cardsCounts)
        {
            var cardType = 1;
            var cards = cardsCounts.Select(cnt => new Card {CardType = cardType++, Count = cnt}).ToList();
            cards.Sort((card1, card2) => card1.Count.CompareTo(card2.Count));
            long result = 0, jokersCount = jokersInitialCount;
            while (!IsOver(jokersCount, cards))
            {
                result++;
                if (cards.Count == 1)
                {
                    if (cards[0].Count == 0) jokersCount--;
                    else cards[0].Count--;
                }
                else
                {
                    if (jokersCount > 0)
                    {
                        for (int i = 1; i < cards.Count; i++)
                        {
                            cards[i].Count--;
                        }
                        jokersCount--;
                        if (cards[0].Count > cards[1].Count)
                        {
                            var card = cards[0];
                            cards[0] = cards[1];
                            cards[1] = card;
                        }
                    }
                    else
                    {
                        foreach (var card in cards) card.Count--;
                    }
                }
            }
            return result;
        }
    }
}
