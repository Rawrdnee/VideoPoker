using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VideoPoker
{
    public class Deck
    {
        #region Private Members
        private string[] _suits = { "C", "D", "S", "H" };
        private uint[] _values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        private List<Card> _Cards;
        private Queue<Card> _Shoe;
        private Form _form = null;
        private Random _rnd;
        #endregion
        
        #region Public Properties

        #endregion
        
        #region  Private Methods 
        private void CreateDeck()
        {
            foreach(string suit in _suits)
            { 
                foreach(uint value in _values)
                {
                    string cardname = suit + value.ToString() + ".gif";
                    Bitmap bmp = new Bitmap("Images/" + cardname);

                    Card card = new Card(_form);

                    card.CARD.Height = bmp.Height;
                    card.CARD.Width = bmp.Width;
                    card.FrontImage = bmp;
                    card.Value = value;
                    card.Suit = suit;

                    bmp = new Bitmap("Images/b2fv.gif");
                    card.BackImage = bmp;

                    card.CARD.Image = bmp;

                    bmp = new Bitmap("Images/hold" + cardname);
                    card.HoldImage = bmp;
                    

                    _Cards.Add(card);

                }
            }
        }

        private void Shuffle()
        {
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < _Cards.Count; i++)
            {
                int position = _rnd.Next(0, 52);
                Card temp = new Card(_form);
                temp = _Cards[i];
                _Cards[i] = _Cards[position];
                _Cards[position] = temp;

             }
             }
        }

        private void LoadShoe()
        {
            foreach(Card card in _Cards)
            {
                _Shoe.Enqueue(card);
            }
        }

      
        #endregion
        
        #region  Public Methods 
        public Card Deal()
        {
            Card card = _Shoe.Dequeue();
            return card;
                 
        }
        public void Show()
        {
            int x = 600;
            int y = 350;
            foreach(Card card in _Cards)
            {
                
                card.CARD.Location = new Point(x, y);
                card.Bouncable = true;
                _form.Controls.Add(card.CARD);
                x += 2;
                y -= 2;
            

            }

        }
        public void Dispose()
        {
            foreach (Card card in _Cards)
            {
                card.Dispose();
                Application.DoEvents();
            }
            _Cards.Clear();
        }
        #endregion
        
        #region  Public Events 

        #endregion
        
        #region  Public Event Handlers 

        #endregion
        
        #region Construction 
        public Deck(Form f, Random r)
        {
            _rnd = r;
            _form = f;
            _Cards = new List<Card>();
            _Shoe = new Queue<Card>();
            CreateDeck();
            Shuffle();
            LoadShoe();
            
        }
        #endregion
    }
}
