using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPoker
{
    public partial class pokerpoker : Form
    {
        private Random rnd = new Random();
        private Deck deck;
        private Hand hand;
        private List<Button> buttons;
        private Double wins;

        public pokerpoker()
        {
            InitializeComponent();
            KeyDown += FrmTable_KeyDown;
        }

        #region Event Handlers
        private void FrmTable_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    Exit();
                    break;
                case Keys.M:
                    Purchase();
                    break;
                case Keys.N:
                    if (mnuNewGame.Enabled)
                    {
                        NewGame();
                    }
                    break;
                case Keys.P:
                    // make label visible
                    break;
                case Keys.D:
                    if (mnuDraw.Enabled)
                    {
                        Draw();
                    }
                    break;
                default:
                    break;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            wins = 0.0;
            deck = new Deck(this, rnd);
            deck.Show();
            mnuDraw.Enabled = false;
            mnuNewGame.Enabled = true;
            buttons = new List<Button>();
            buttons.Add(btn25);
            buttons.Add(btn50);
            buttons.Add(btn75);
            buttons.Add(btn100);

            Decimal bank = Decimal.Parse(lblCredit.Text);
            if (bank == 0)
            {
                ChangeButtonStatus(false);
                mnuNewGame.Enabled = false;
            }
            else
            {
                ChangeButtonStatus(true);
                mnuNewGame.Enabled = true;
            }
            this.Focus();
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            Bet(sender, e);
        }

        private void mnuPurchase_Click(object sender, EventArgs e)
        {
            Purchase();
        }
        #endregion

        #region Private Methods
        private void Bet(object sender, EventArgs e)
        {
            Double credit = Convert.ToDouble(lblCredit.Text);
            Button btn = (Button)sender;
            Double value = Convert.ToDouble(btn.Tag.ToString());

            if ((credit - value) >= 0)
            {
                credit -= value;
                lblCredit.Text = credit.ToString();

                Double bet = Convert.ToDouble(lblBet.Text);
                bet = value;
                lblBet.Text = bet.ToString();
            }
            this.ChangeButtonStatus(false);
            this.mnuNewGame.Enabled = true;
        }

        private void CenterFormLabel(object sender)
        {
            Label l = (Label)sender;
            Point labelLocation = l.Location;


        }

        private void Calculate(Values multiplier)
        {
            Double bet = Double.Parse(this.lblBet.Text);
            Double cash = bet * (Double)multiplier;
            Double credit = Double.Parse(lblCredit.Text);
            credit += cash;
            lblCredit.Text = credit.ToString();
            lblWin.Text = cash.ToString();
        }

        private void ChangeButtonStatus(Boolean status)
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = status;
            }
        }

        private void NewGame()
        {
            if (deck != null)
            {
                deck.Dispose();
            }
            // give the game a new deck each new game
            deck = new Deck(this, rnd);
            deck.Show();

            if (hand != null)
            {
                hand.Dispose();
            }

            hand = new Hand();
            for (Int32 i = 0; i < 5; i++)
            {
                hand.Deal = deck.Deal();
            }

            hand.Show();

            mnuNewGame.Enabled = false;
            mnuDraw.Enabled = true;
            HandValue result = hand.Evaluate();
            this.lblHand.Text = result.Description;
        }

        private void Pause()
        {

        }

        private void Purchase()
        {
            Double credit = Convert.ToDouble(lblCredit.Text);
            credit += 1.00;
            lblCredit.Text = String.Format("{0:F}", credit);
            Double bank = Double.Parse(lblCredit.Text);

            if (bank > 0)
            {
                this.ChangeButtonStatus(true);
            }
        }

        private void Draw()
        {
            this.ChangeButtonStatus(false);
            hand.Draw(deck);
            hand.Show();
            mnuDraw.Enabled = false;
            mnuNewGame.Enabled = true;
            HandValue result = hand.Evaluate();
            this.lblHand.Text = result.Description;
            Calculate(result.Multiplier);
            ChangeButtonStatus(true);
        }

        private void Exit()
        {
            DialogResult result = MessageBox.Show("Exit? Are you sure?", "Poker", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
        #endregion


    }
}
