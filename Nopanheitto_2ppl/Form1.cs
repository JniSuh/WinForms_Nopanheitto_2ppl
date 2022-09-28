using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Nopanheitto_2ppl
{
    public partial class Form1 : Form
    {
        Dice player1 = new Dice();
        Dice player2 = new Dice();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player1.Value == 0)
            {
                rollDice(picBoxDice1, player1, -4);

                picBoxDice2.Show();
            } 
            else if (player2.Value == 0)
            {
                rollDice(picBoxDice2, player2, 4);

                btnThrow.Enabled = false;

                diceElimination();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            player1.Value = player2.Value = 0;

            lblWinner.Hide();
            picBoxDice2.Hide();

            picBoxDice1.Show();

            picBoxDice1.Location = picBoxDice2.Location = new Point(240, 170);

            btnThrow.Enabled = true;
        }

        void rollDice(PictureBox dice, Dice player, int incr_X)
        {
            for (int i = 0; i < 10; i++)
            {
                Dice.Roll(dice);
                Thread.Sleep(150);
                this.Refresh();
            }

            player.Value = Dice.Roll(dice);

            this.Refresh();
            Thread.Sleep(1000);

            while (dice.Location.Y > 60)
            {
                Dice.diceAnimation(dice, incr_X, -2);
                Thread.Sleep(1);
                this.Refresh();
            }
        }

        void diceElimination()
        {
            Thread.Sleep(500);
            while (picBoxDice2.Location.X >= picBoxDice1.Location.X + 60)
            {
                Dice.diceAnimation(picBoxDice1, 4, 0);
                Dice.diceAnimation(picBoxDice2, -4, 0);
                Thread.Sleep(1);
                this.Refresh();
            }
            Thread.Sleep(50);

            if (player1.Value > player2.Value)
            {
                //picBoxDice1.Image = Dice.GetImage("_" + (player1.Value - player2.Value));
                lblWinner.Text = "Voittaja: Pelaaja1";
                picBoxDice2.Hide();
            } else if (player2.Value > player1.Value)
            {
                //picBoxDice2.Image = Dice.GetImage("_" + (player2.Value - player1.Value));
                lblWinner.Text = "Voittaja: Pelaaja2";
                picBoxDice1.Hide();
            } else
            {
                lblWinner.Text = "Tasapeli";
            }
            lblWinner.Show();
        }
    }
}
