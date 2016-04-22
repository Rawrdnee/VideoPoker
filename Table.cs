using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VideoPoker42
{
    public partial class frmTable : Form
    {
        Random rnd = new Random();
        Deck deck;
        Hand hand = new Hand();
        List<Button> buttons;
        public frmTable()
        {

            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit? Are you sure?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ChangeButtonStatus(bool status)
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = status;
            }
        }
        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            mnuNewGame.Enabled = false;
            mnuDraw.Enabled = true;

            if (deck != null)
            {
                deck.Dispose();
            }

            deck = new Deck(this, rnd);
            deck.Show();

            if (hand != null)
            {
                hand.Dispose();
            }
            hand = new Hand();
            for (int i = 0; i < 4; i++)
            {
                hand.Deal = deck.Deal();
            }
            hand.Deal = deck.Deal();
            hand.Show();
            HandValue result = hand.Evaluate();
            this.lblHand.Text = result.Description;
        }
        private void Calculate(Values Multiplier)
        {
            double bet = double.Parse(this.lblBet.Text);
            double cash = bet * (double)Multiplier;
            double credit = double.Parse(lblbank.Text);
            credit += cash;
            lblbank.Text = string.Format("{0:F}", credit);
            lblWinnings.Text = string.Format("{0:F}", cash);
        }

        private void frmTable_Load(object sender, EventArgs e)
        {

            mnuNewGame.Enabled = true;
            mnuDraw.Enabled = false;
            buttons = new List<Button>();
            buttons.Add(btn25);
            buttons.Add(btn50);
            buttons.Add(btn75);
            buttons.Add(btn100);

            decimal bank = decimal.Parse(lblbank.Text);
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
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {
            mnuDraw.Enabled = false;
            hand.Draw(deck);
            hand.Show();
            HandValue result = hand.Evaluate();
            this.lblHand.Text = result.Description;
            Calculate(result.Multiplier);
            mnuNewGame.Enabled = false;
            ChangeButtonStatus(true);
            lblBet.Text = string.Format("{0:F}", 0);
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            double credit = Convert.ToDouble(lblbank.Text);
            Button btn = (Button)sender;
            Double value = Convert.ToDouble(btn.Tag.ToString());


            if (credit - value >= 0)
            {
                credit -= value;
                lblbank.Text = credit.ToString();
                double bet = Convert.ToDouble(lblBet.Text);
                bet = value;
                lblBet.Text = string.Format("{0:F}", bet);

            }
            this.ChangeButtonStatus(false);
            mnuNewGame.Enabled = true;


        }

        private void mnuPurchase_Click(object sender, EventArgs e)
        {
            double Credit = Convert.ToDouble(lblbank.Text);
            Credit += 1.00;
            lblbank.Text = string.Format("{0:F}", Credit);
            double bank = double.Parse(lblbank.Text);
            if (bank > 0)
            {
                this.mnuNewGame.Enabled = true;
                this.ChangeButtonStatus(true);
            }
        }


    } 
}
