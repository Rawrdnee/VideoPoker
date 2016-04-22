using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPoker
{
   public class HandValue
    {
        #region Private members
        private string _Description = string.Empty;
        private Values _Multiplier = 0;
        #endregion
        
        #region Public Properties
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
            public Values  Multiplier
        {
            get
            {
                return _Multiplier;
            }
            set
            {
                _Multiplier = value;
            }
        }
      
        }
        #endregion

       public enum Values
    {
        HighCard = 0,
        Pair = 1,
        TwoPairs = 2,
        ThreeOfAKind = 3,
        Straight = 4,
        Flush = 5,
        FullHouse = 6,
        FourOfAKind = 7,
        StraightFlush = 8,
        RoyalFlush = 9

    }
    }
