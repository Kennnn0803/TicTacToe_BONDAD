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
            if (ticbutton1.Text == "X" && ticbutton5.Text == "X" && ticbutton9.Text == "X")
            {
                ticbutton1.BackColor = Color.Aquamarine;
                ticbutton5.BackColor = Color.Aquamarine;
                ticbutton9.BackColor = Color.Aquamarine;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton1.Text == "X" && ticbutton2.Text == "X" && ticbutton3.Text == "X" )
            {
                ticbutton1.BackColor = Color.Aquamarine;
                ticbutton2.BackColor = Color.Aquamarine;
                ticbutton3.BackColor = Color.Aquamarine;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus +1);
                Enable_False();
            }

            if (ticbutton4.Text == "X" && ticbutton5.Text == "X" && ticbutton6.Text == "X")
            {
                ticbutton4.BackColor = Color.Aquamarine;
                ticbutton5.BackColor = Color.Aquamarine;
                ticbutton6.BackColor = Color.Aquamarine;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus +1);
                Enable_False();
            }

            if (ticbutton7.Text == "X" && ticbutton8.Text == "X" && ticbutton9.Text == "X")
            {
                ticbutton7.BackColor = Color.Aquamarine;
                ticbutton8.BackColor = Color.Aquamarine;
                ticbutton9.BackColor = Color.Aquamarine;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus +1);
                Enable_False();
            }

            if (ticbutton1.Text == "X" && ticbutton4.Text == "X" && ticbutton7.Text == "X")
            {
                ticbutton1.BackColor = Color.Aquamarine;
                ticbutton4.BackColor = Color.Aquamarine;
                ticbutton7.BackColor = Color.Aquamarine;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton3.Text == "X" && ticbutton5.Text == "X" && ticbutton7.Text == "X")
            {
                ticbutton3.BackColor = Color.Aquamarine;
                ticbutton5.BackColor = Color.Aquamarine;
                ticbutton7.BackColor = Color.Aquamarine;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton2.Text == "X" && ticbutton5.Text == "X" && ticbutton8.Text == "X")
            {
                ticbutton2.BackColor = Color.Aquamarine;
                ticbutton5.BackColor = Color.Aquamarine;
                ticbutton8.BackColor = Color.Aquamarine;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            if (ticbutton3.Text == "X" && ticbutton6.Text == "X" && ticbutton9.Text == "X")
            {
                ticbutton3.BackColor = Color.Aquamarine;
                ticbutton6.BackColor = Color.Aquamarine;
                ticbutton9.BackColor = Color.Aquamarine;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }

            // eto yung sa "O"

            if (ticbutton1.Text == "O" && ticbutton5.Text == "O" && ticbutton9.Text == "O")
            {
                ticbutton1.BackColor = Color.Aquamarine;
                ticbutton5.BackColor = Color.Aquamarine;
                ticbutton9.BackColor = Color.Aquamarine;

                MessageBox.Show("Player 1 wins!", "Tic Tac Toe!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plus = int.Parse(score1.Text);
                score1.Text = Convert.ToString(plus + 1);
                Enable_False();
            }


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

        private void buttonclick(object sender, EventArgs e)
        {
            if (checker == false)
            {
                ticbutton1.Text = "X";
                checker = true;

            }

            else
            {
                ticbutton1.Text = "O";
                checker = false;
            }
            score();
            ticbutton1.Enabled = false;

        }

        private void buttonclick2(object sender, EventArgs e)
        {
            if (checker == false)
            {
                ticbutton2.Text = "X";
                checker = true;

            }

            else
            {
                ticbutton2.Text = "O";
                checker = false;
            }
            score();
            ticbutton2.Enabled = false;
        }

        private void buttonclick3(object sender, EventArgs e)
        {
            if (checker == false)
            {
                ticbutton3.Text = "X";
                checker = true;

            }

            else
            {
                ticbutton3.Text = "O";
                checker = false;
            }
            score();
            ticbutton3.Enabled = false;
        }

        private void buttonclick4(object sender, EventArgs e)
        {
            if (checker == false)
            {
                ticbutton4.Text = "X";
                checker = true;

            }

            else
            {
                ticbutton4.Text = "O";
                checker = false;
            }
            score();
            ticbutton4.Enabled = false;
        }

        private void buttonclick5(object sender, EventArgs e)
        {
            if (checker == false)
            {
                ticbutton5.Text = "X";
                checker = true;

            }

            else
            {
                ticbutton5.Text = "O";
                checker = false;
            }
            score();
            ticbutton5.Enabled = false;
        }

        private void buttonclick6(object sender, EventArgs e)
        {
            if (checker == false)
            {
                ticbutton6.Text = "X";
                checker = true;

            }

            else
            {
                ticbutton6.Text = "O";
                checker = false;
            }
            score();
            ticbutton6.Enabled = false;
        }

        private void buttonclick7(object sender, EventArgs e)
        {
            if (checker == false)
            {
                ticbutton7.Text = "X";
                checker = true;

            }

            else
            {
                ticbutton7.Text = "O";
                checker = false;
            }
            score();
            ticbutton7.Enabled = false;
        }

        private void buttonclick8(object sender, EventArgs e)
        {
            if (checker == false)
            {
                ticbutton8.Text = "X";
                checker = true;

            }

            else
            {
                ticbutton8.Text = "O";
                checker = false;
            }
            score();
            ticbutton8.Enabled = false;
        }

        private void buttonclick9(object sender, EventArgs e)
        {
            if (checker == false)
            {
                ticbutton9.Text = "X";
                checker = true;

            }

            else
            {
                ticbutton9.Text = "O";
                checker = false;
            }
            score();
            ticbutton9.Enabled = false;
        }
// newgame
        private void newgameb_Click(object sender, EventArgs e)
        {
            try
            {


                ticbutton1.Enabled = true;
                ticbutton2.Enabled = true;
                ticbutton3.Enabled = true;
                ticbutton4.Enabled = true;
                ticbutton5.Enabled = true;
                ticbutton6.Enabled = true;
                ticbutton7.Enabled = true;
                ticbutton8.Enabled = true;
                ticbutton9.Enabled = true;

                ticbutton1.Text = "";
                ticbutton2.Text = "";
                ticbutton3.Text = "";
                ticbutton4.Text = "";
                ticbutton5.Text = "";
                ticbutton6.Text = "";
                ticbutton7.Text = "";
                ticbutton8.Text = "";
                ticbutton9.Text = "";

                score1.Text = "0";
                score2.Text = "0";

                ticbutton1.BackColor = Color.Azure;
                ticbutton2.BackColor = Color.Azure;
                ticbutton3.BackColor = Color.Azure;
                ticbutton4.BackColor = Color.Azure;
                ticbutton5.BackColor = Color.Azure;
                ticbutton6.BackColor = Color.Azure;
                ticbutton7.BackColor = Color.Azure;
                ticbutton8.BackColor = Color.Azure;
                ticbutton9.BackColor = Color.Azure;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        // reset button nakatanggal na yung sa scores, di dapat magagalaw
        private void resetb_Click(object sender, EventArgs e)
        {
            try
            {
                ticbutton1.Enabled = true;
                ticbutton2.Enabled = true;
                ticbutton3.Enabled = true;
                ticbutton4.Enabled = true;
                ticbutton5.Enabled = true;
                ticbutton6.Enabled = true;
                ticbutton7.Enabled = true;
                ticbutton8.Enabled = true;
                ticbutton9.Enabled = true;

                newgameb.Enabled = true;

                ticbutton1.Text = "";
                ticbutton2.Text = "";
                ticbutton3.Text = "";
                ticbutton4.Text = "";
                ticbutton5.Text = "";
                ticbutton6.Text = "";
                ticbutton7.Text = "";
                ticbutton8.Text = "";
                ticbutton9.Text = "";

                ticbutton1.BackColor = Color.Azure;
                ticbutton2.BackColor = Color.Azure;
                ticbutton3.BackColor = Color.Azure;
                ticbutton4.BackColor = Color.Azure;
                ticbutton5.BackColor = Color.Azure;
                ticbutton6.BackColor = Color.Azure;
                ticbutton7.BackColor = Color.Azure;
                ticbutton8.BackColor = Color.Azure;
                ticbutton9.BackColor = Color.Azure;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void exitb_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult end;
                end = MessageBox.Show("End the game?", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (end == DialogResult.OK)
                {
                    Application.Exit();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
