using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Tractor.Card;
using Medallion;

namespace Tractor
{
    public class Card
    {
        public SuitEnum Suit { get; set; } 
        public RankEnum Rank { get; set; }
        public enum SuitEnum { SPADES, HEARTS, CLUBS, DIAMONDS, TRUMPS }
        public enum RankEnum { TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, ELEVEN, TWELVE, ACE, BLACKJOKER, REDJOKER }
        
    }
    public class Deck
    {
        public  List<Card> Cards { get; set; }
        public Deck(RankEnum trumpRank)
        {
            foreach(SuitEnum suit in Enum.GetValues(typeof(SuitEnum)))
            {
                if (suit == SuitEnum.TRUMPS)
                {
                    Cards.Add(new Card { Suit = suit, Rank = RankEnum.BLACKJOKER });
                    Cards.Add(new Card { Suit = suit, Rank = RankEnum.REDJOKER });
                    Cards.Add(new Card { Suit = suit, Rank = RankEnum.BLACKJOKER });
                    Cards.Add(new Card { Suit = suit, Rank = RankEnum.REDJOKER });
                }
                foreach(RankEnum rank in Enum.GetValues(typeof(RankEnum)))
                {
                    if (rank == RankEnum.REDJOKER || rank == RankEnum.BLACKJOKER) break;
                    if(rank == trumpRank)
                    {
                        Cards.Add(new Card { Suit = SuitEnum.TRUMPS, Rank = rank });
                    }
                    else
                    {
                        Cards.Add(new Card { Suit = suit, Rank = rank });
                        Cards.Add(new Card { Suit = suit, Rank = rank });
                    }
                }
            }
            Cards.Shuffle();
        }
        public Boolean isEmpty()
        {
            return !(Cards.Count() > 0);
        }
        public Card draw()
        {
            Card card = Cards.FirstOrDefault();
            Cards.Remove(card);
            return card;
        }

    }
    public class Player
    {
        public List<Card> Hand { get; set; }
        public bool Bottom { get; set; }
        public Player Partner { get; set; }
        public int Score { get; set; }
        public RankEnum Level { get; set; }
        public List<Card> add(Card card)
        {
            Hand.Add(card);
            Hand.OrderBy(c => c.Suit).ThenBy(c => c.Rank);
            return Hand;
        }
        public List<Card> play(Card card)
        {
            Hand.Remove(card);
            return Hand;
        }
    }
}
