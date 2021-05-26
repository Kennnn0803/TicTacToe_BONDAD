using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class body : Form
    {
        Boolean checker;
        int plus;

        void Enable_False()
        {
            ticbutton1.Enabled = false;
            ticbutton2.Enabled = false;
            ticbutton3.Enabled = false;
            ticbutton4.Enabled = false;
            ticbutton5.Enabled = false;
            ticbutton6.Enabled = false;
            ticbutton7.Enabled = false;
            ticbutton8.Enabled = false;
            ticbutton9.Enabled = false;

        }

        void score()
        {
            // eto yung sa "X"
            if(ticbutton1.Text == "X" && ticbutton2.Text == "X" && ticbutton3.Text == "X" )
            {
                ticbutton1.BackColor = Color.AliceBlue;
                ticbutton2.BackColor = Color.AliceBlue;
                ticbutton3.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus +1);
                Enable_False();
            }

            if (ticbutton4.Text == "X" && ticbutton5.Text == "X" && ticbutton6.Text == "X")
            {
                ticbutton4.BackColor = Color.AliceBlue;
                ticbutton5.BackColor = Color.AliceBlue;
                ticbutton6.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus +1);
                Enable_False();
            }

            if (ticbutton7.Text == "X" && ticbutton8.Text == "X" && ticbutton9.Text == "X")
            {
                ticbutton7.BackColor = Color.AliceBlue;
                ticbutton8.BackColor = Color.AliceBlue;
                ticbutton9.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus +1);
                Enable_False();
            }

            if (ticbutton1.Text == "X" && ticbutton4.Text == "X" && ticbutton7.Text == "X")
            {
                ticbutton1.BackColor = Color.AliceBlue;
                ticbutton4.BackColor = Color.AliceBlue;
                ticbutton7.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton3.Text == "X" && ticbutton5.Text == "X" && ticbutton7.Text == "X")
            {
                ticbutton3.BackColor = Color.AliceBlue;
                ticbutton5.BackColor = Color.AliceBlue;
                ticbutton7.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton2.Text == "X" && ticbutton5.Text == "X" && ticbutton8.Text == "X")
            {
                ticbutton2.BackColor = Color.AliceBlue;
                ticbutton5.BackColor = Color.AliceBlue;
                ticbutton8.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton1.Text == "X" && ticbutton4.Text == "X" && ticbutton7.Text == "X")
            {
                ticbutton1.BackColor = Color.AliceBlue;
                ticbutton4.BackColor = Color.AliceBlue;
                ticbutton7.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton3.Text == "X" && ticbutton6.Text == "X" && ticbutton9.Text == "X")
            {
                ticbutton3.BackColor = Color.AliceBlue;
                ticbutton6.BackColor = Color.AliceBlue;
                ticbutton9.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            // eto yung sa "O"

            if (ticbutton1.Text == "O" && ticbutton2.Text == "O" && ticbutton3.Text == "O")
            {
                ticbutton1.BackColor = Color.AliceBlue;
                ticbutton2.BackColor = Color.AliceBlue;
                ticbutton3.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 2 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton4.Text == "O" && ticbutton5.Text == "O" && ticbutton6.Text == "O")
            {
                ticbutton4.BackColor = Color.AliceBlue;
                ticbutton5.BackColor = Color.AliceBlue;
                ticbutton6.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 2 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton7.Text == "O" && ticbutton8.Text == "O" && ticbutton9.Text == "O")
            {
                ticbutton7.BackColor = Color.AliceBlue;
                ticbutton8.BackColor = Color.AliceBlue;
                ticbutton9.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 2 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton1.Text == "O" && ticbutton4.Text == "O" && ticbutton7.Text == "O")
            {
                ticbutton1.BackColor = Color.AliceBlue;
                ticbutton4.BackColor = Color.AliceBlue;
                ticbutton7.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 2 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton3.Text == "O" && ticbutton5.Text == "O" && ticbutton7.Text == "O")
            {
                ticbutton3.BackColor = Color.AliceBlue;
                ticbutton5.BackColor = Color.AliceBlue;
                ticbutton7.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 2 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton2.Text == "O" && ticbutton5.Text == "O" && ticbutton8.Text == "O")
            {
                ticbutton2.BackColor = Color.AliceBlue;
                ticbutton5.BackColor = Color.AliceBlue;
                ticbutton8.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 2 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton1.Text == "O" && ticbutton4.Text == "O" && ticbutton7.Text == "O")
            {
                ticbutton1.BackColor = Color.AliceBlue;
                ticbutton4.BackColor = Color.AliceBlue;
                ticbutton7.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 2 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton3.Text == "O" && ticbutton6.Text == "O" && ticbutton9.Text == "O")
            {
                ticbutton3.BackColor = Color.AliceBlue;
                ticbutton6.BackColor = Color.AliceBlue;
                ticbutton9.BackColor = Color.AliceBlue;

                MessageBox.Show("Player 2 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }


        }
        public body()
        {
            InitializeComponent();
        }

        private void body_Load(object sender, EventArgs e)
        {

        }
    }
}
