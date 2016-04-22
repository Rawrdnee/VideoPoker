using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace VideoPoker
{
    public class Hand
    {

        #region Private Members
        List<Card> _Cards = null;
        List<Card> _S = null;

        #endregion
       
        #region Public Properties
        public Card Deal
        {
            set
            {
                value.Bouncable = false;
                value.Holdable = true;
                _Cards.Add(value);
                _S.Add(value);
            }
        }
        #endregion
       
        #region  Private Methods
         
        private void Sort()
        {
            bool swapped = true;

            do
            {
                swapped = false;
                for (int i = 0; i < _S.Count - 1; i++)
                {
                    if (_S[i].Value > _S[i + 1].Value)
                    {
                        swapped = true;
                        Card temp = _S[i];
                        _S[i] = _S[i + 1];
                        _S[i + 1] = temp;

                    }
                }
            }while (swapped == true); 
        }
        public bool RoyalFlush()
        {
            
            {
                bool result = false;
                if ((_S[0].Value == 1) && (_S[1].Value == 10) && (_S[2].Value == 11) && (_S[3].Value == 12)
                    && (_S[4].Value == 13)
                    && (_S[0].Suit == _S[1].Suit) && (_S[1].Suit == _S[2].Suit)
                    && (_S[2].Suit == _S[3].Suit) && (_S[3].Suit == _S[4].Suit))
                {
                    result = true;
                }
                return result;
            }
            
        }
        public bool StraightFlush()
        {
            bool result = false;
            if (Straight() == true && Flush() == true)  
            {
                result = true;
            }
                return result;
        }
        public bool FourKind()
        {
            bool result = false;
            if (_S[0].Value == _S[1].Value && _S[1].Value == _S[2].Value && _S[2].Value == _S[3].Value)
            {
                result = true;
            }
            else if (_S[1].Value == _S[2].Value && _S[2].Value == _S[3].Value && _S[3].Value == _S[4].Value)
            {
                result = true;
            }
            return result;
        }
        public bool FullHouse()
        {
            bool result = false;
            if (_S[0].Value == _S[1].Value && _S[1].Value == _S[2].Value && (_S[3].Value == _S[4].Value))
            {
                result = true;
            }
            else if (_S[2].Value == _S[3].Value && _S[3].Value == _S[4].Value && (_S[0].Value == _S[1].Value))
            {
                result = true;
            }
            return result;
        }
        public bool Flush()
        {
            bool result = false;
            if (_S[0].Suit  == _S[1].Suit && _S[1].Suit  == _S[2].Suit && _S[2].Suit == _S[3].Suit &&
                _S[3].Suit == _S[4].Suit)
            {
                result = true;
            }
                return result;

        }
        public bool Straight()
        {
            bool result = false;
            if (_S[0].Value +1 == _S[1].Value  &&  _S[1].Value +1 == _S[2].Value && _S[2].Value + 1 == _S[3].Value &&
                _S[3].Value + 1 == _S[4].Value)
            {
                result = true;
            }
            return result;
        }
        public bool ThreeKind()
        {
            bool result = false;
            if (_S[0].Value == _S[1].Value &&  _S[1].Value== _S[2].Value)
            {
                result = true;
            }
            else if (_S[1].Value == _S[2].Value && _S[2].Value == _S[3].Value)
            {
                result = true;
            }
            else if (_S[2].Value == _S[3].Value && _S[3].Value == _S[4].Value)
            {
                result = true;
            }

            return result;
        }
        public bool TwoPair()
        {
            bool result = false;
            if (_S[0].Value == _S[1].Value && _S[2].Value == _S[3].Value)
            {
                result = true;
            }
            else if (_S[1].Value == _S[2].Value && _S[3].Value == _S[4].Value)
            {
                result = true;
            }
            else if (_S[0].Value == _S[1].Value && _S[3].Value == _S[4].Value)
            {
                result = true;
            }
            return result;
        }
        public bool Pair()
        {
            bool result = false;
            if (_S[0].Value == _S [1].Value)
            {
                result = true;
            }
            else if (_S[1].Value == _S[2].Value)
            {
                result = true;
            }
            else if (_S[2].Value == _S[3].Value)
            {
                result = true;
            }
            else if (_S[3].Value == _S[4].Value)
            {
                result = true;
            }
            return result;
        }

        #endregion
        
        #region  Public Methods 
        public void Show()
        {
            int x = 100;
            int y = 200;
            foreach(Card card in _Cards)
            {
                card.Flip();
                Point location = new Point(x, y);
                card.CARD.Location = location;
                x += card.CARD.Width + 2;

                
            }
        }
        public void Draw(Deck deck)
        {
            for(int i = 0; i < _Cards.Count; i++)
            {
                if(_Cards[i].IsHeld == false)
                {
                    _Cards[i].Dispose();
                    _Cards[i] = deck.Deal();
             


                }
                _Cards[i].Holdable = false;
                _Cards[i].Bouncable = false;
            }
            
            _S.Clear();
            foreach(Card card in _Cards)
            {
                _S.Add(card);
            }
        }
        public void Dispose()
        {
            foreach (Card card in _Cards)
            {
                card.Dispose();
                Application.DoEvents();
            }
        }
        public HandValue Evaluate()
        {
            Sort();

            HandValue result = new HandValue();
            if (RoyalFlush() == true)
            {
                result.Multiplier = Values.RoyalFlush;
                result.Description = "Royal Flush";
            }
            else if (StraightFlush()==true)
            {
                result.Multiplier = Values.StraightFlush;
                result.Description = "Straight Flush";
            }
            else if (FourKind()==true)
            {
                result.Multiplier = Values.FourOfAKind;
                result.Description = "Four of a Kind";
            }
            else if (FullHouse()==true)
            {
                result.Multiplier = Values.FullHouse;
                result.Description = "Full House";
            }
            else if (Flush()==true)
            {
                result.Multiplier = Values.Flush;
                result.Description = "Flush";
            }
            else if (Straight()==true)
            {
                result.Multiplier = Values.Straight;
                result.Description = "Straight";
            }
            else if(ThreeKind ()==true)
            {
                result.Multiplier = Values.ThreeOfAKind;
                result.Description = "Three of a Kind";
            }
            else if(TwoPair()==true)
            {
                result.Multiplier = Values.TwoPairs;
                result.Description = "Two Pairs";
            }
            else if(Pair()==true)
            {
                result.Multiplier = Values.Pair;
                result.Description = "Pair";
            }
            else
            {
                result.Multiplier = Values.HighCard;
                result.Description = "High Card!";
            }
            return result;
        }
        public void Add(Card card)
        {
            _S.Add(card);
        }


        #endregion
        
        #region  Public Events 

        #endregion
        
        #region  Public Event Handlers 

        #endregion
        
#region Construction 
        public Hand()
        {
            _Cards = new List<Card>();
            _S = new List<Card>();
        }

        #endregion

    }
}
