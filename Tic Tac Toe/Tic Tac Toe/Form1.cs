using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            winLabel.Text = "Click New Game to play!";
                
        }
        int[,] game = new int[3, 3];
        int gameState = 1;

        String turn = "X";

        private void button1_Click(object sender, EventArgs e)
        {
            gameState = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    game[i, j] = 2;
            turn = "X";
            winLabel.Text = "X Turn!"; 
                
            //            Random rand = new Random();
            //            int[,] game = new int[3, 3];
            //            for (int row = 0; row < 3; row++)
            //            {
            //                for (int col = 0; col < 3; col++)
            //                {
            //                    game[row, col] = (int)rand.Next(0, 2);
            //                }

            //                if (game[0, 0] == 1)
            //                    label1.Text = "X";
            //                else label1.Text = "O";

            //                if (game[0, 1] == 1)
            //                    label2.Text = "X";
            //                else label2.Text = "O";

            //                if (game[0, 2] == 1)
            //                    label3.Text = "X";
            //                else label3.Text = "O";

            //                if (game[1, 0] == 1)
            //                    label4.Text = "X";
            //                else label4.Text = "O";

            //                if (game[1, 1] == 1)
            //                    label5.Text = "X";
            //                else label5.Text = "O";

            //                if (game[1, 2] == 1)
            //                    label6.Text = "X";
            //                else label6.Text = "O";

            //                if (game[2, 0] == 1)
            //                    label7.Text = "X";
            //                else label7.Text = "O";

            //                if (game[2, 1] == 1)
            //                    label8.Text = "X";
            //                else label8.Text = "O";
            //
            //                if (game[2, 2] == 1)
            //                    label9.Text = "X";
            //                else label9.Text = "O";

            //                if ((game[0, 0] == 0) && (game[0, 1] == 0) && (game[0, 2] == 0))
            //                {
            //                    winLabel.Text = "O Player Wins!";
            //                }
            //
            //                else if ((game[1, 0] == 0) && (game[1, 1] == 0) && (game[1, 2] == 0))
            //                {
            //                    winLabel.Text = "O Player Wins!";
            //                }
            //
            //                else if ((game[2, 0] == 0) && (game[2, 1] == 0) && (game[2, 2] == 0))
            //                {
            //                    winLabel.Text = "O Player Wins!";
            //                }
            //
            //                else if ((game[0, 0] == 0) && (game[1, 0] == 0) && (game[2, 0] == 0))
            //                {
            //                    winLabel.Text = "O Player Wins!";
            //                }
            //
            //                else if ((game[0, 1] == 0) && (game[1, 1] == 0) && (game[2, 1] == 0))
            //                {
            //                    winLabel.Text = "O Player Wins!";
            //                }
            //
            //                else if ((game[0, 2] == 0) && (game[1, 2] == 0) && (game[2, 2] == 0))
            //                {
            //                    winLabel.Text = "O Player Wins!";
            //                }
            //
            //                else if ((game[0, 0] == 0) && (game[1, 1] == 0) && (game[2, 2] == 0))
            //                {
            //                    winLabel.Text = "O Player Wins!";
            //                }
            //
            //              else if ((game[0, 2] == 0) && (game[1, 1] == 0) && (game[2, 0] == 0))
            //                {
            //                    winLabel.Text = "O Player Wins!";
            //                }
            //
            //                else if ((game[0, 0] == 1) && (game[0, 1] == 1) && (game[0, 2] == 1))
            //                {
            //                    winLabel.Text = "X Player Wins!";
            //                }
            //
            //                else if ((game[1, 0] == 1) && (game[1, 1] == 1) && (game[1, 2] == 1))
            //                {
            //                    winLabel.Text = "X Player Wins!";
            //                }
            //
            //                else if ((game[2, 0] == 1) && (game[2, 1] == 1) && (game[2, 2] == 1))
            //                {
            //                    winLabel.Text = "X Player Wins!";
            //                }
            //
            //                else if ((game[0, 0] == 1) && (game[1, 0] == 1) && (game[2, 0] == 1))
            //                {
            //                    winLabel.Text = "X Player Wins!";
            //                }
            //
            //                else if ((game[0, 1] == 1) && (game[1, 1] == 1) && (game[2, 1] == 1))
            //                {
            //                    winLabel.Text = "X Player Wins!";
            //                }
            //
            //                else if ((game[0, 2] == 1) && (game[1, 2] == 1) && (game[2, 2] == 1))
            //                {
            //                    winLabel.Text = "X Player Wins!";
            //                }
            //
            //                else if ((game[0, 0] == 1) && (game[1, 1] == 1) && (game[2, 2] == 1))
            //                {
            //                    winLabel.Text = "X Player Wins!";
            //                }
            //
            //                else if ((game[0, 2] == 1) && (game[1, 1] == 1) && (game[2, 0] == 1))
            //                {
            //                    winLabel.Text = "X Player Wins!";
            //                }
            //
            //                else winLabel.Text = "It's a tie!";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (gameState == 0)
            {
                if (label1.Text == "")
                {
                    if (turn == "X")
                    {
                        game[0, 0] = 1;
                        label1.Text = "X";
                        turn = "O";
                        winLabel.Text = "O turn!";
                    }
                    else
                    {
                        game[0, 0] = 0;
                        label1.Text = "O";
                        turn = "X";
                        winLabel.Text = "X turn!";
                    }
                }

                if ((game[0, 0] == 0) && (game[0, 1] == 0) && (game[0, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 0) && (game[1, 1] == 0) && (game[1, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 0) && (game[2, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 0] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 0) && (game[1, 1] == 0) && (game[2, 1] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 2] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 1] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[0, 1] == 1) && (game[0, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 1) && (game[1, 1] == 1) && (game[1, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 1) && (game[2, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 0] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 1) && (game[1, 1] == 1) && (game[2, 1] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 2] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 1] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (gameState == 0)
            {
                if (label2.Text == "")
                {
                    if (turn == "X")
                    {
                        game[0, 1] = 1;
                        label2.Text = "X";
                        turn = "O";
                        winLabel.Text = "O turn!";
                    }
                    else
                    {
                        game[0, 1] = 0;
                        label2.Text = "O";
                        turn = "X";
                        winLabel.Text = "X turn!";
                    }
                }

                if ((game[0, 0] == 0) && (game[0, 1] == 0) && (game[0, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 0) && (game[1, 1] == 0) && (game[1, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 0) && (game[2, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 0] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 0) && (game[1, 1] == 0) && (game[2, 1] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 2] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 1] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[0, 1] == 1) && (game[0, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 1) && (game[1, 1] == 1) && (game[1, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 1) && (game[2, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 0] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 1) && (game[1, 1] == 1) && (game[2, 1] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 2] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 1] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (gameState == 0)
            {
                if (label3.Text == "")
                {
                    if (turn == "X")
                    {
                        game[0, 2] = 1;
                        label3.Text = "X";
                        turn = "O";
                        winLabel.Text = "O turn!";
                    }
                    else
                    {
                        game[0, 2] = 0;
                        label3.Text = "O";
                        turn = "X";
                        winLabel.Text = "X turn!";
                    }
                }

                if ((game[0, 0] == 0) && (game[0, 1] == 0) && (game[0, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 0) && (game[1, 1] == 0) && (game[1, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 0) && (game[2, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 0] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 0) && (game[1, 1] == 0) && (game[2, 1] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 2] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 1] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[0, 1] == 1) && (game[0, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 1) && (game[1, 1] == 1) && (game[1, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 1) && (game[2, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 0] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 1) && (game[1, 1] == 1) && (game[2, 1] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 2] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 1] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (gameState == 0)
            {
                if (label4.Text == "")
                {
                    if (turn == "X")
                    {
                        game[1, 0] = 1;
                        label4.Text = "X";
                        turn = "O";
                        winLabel.Text = "O turn!";
                    }
                    else
                    {
                        game[1, 0] = 0;
                        label4.Text = "O";
                        turn = "X";
                        winLabel.Text = "X turn!";
                    }
                }

                if ((game[0, 0] == 0) && (game[0, 1] == 0) && (game[0, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 0) && (game[1, 1] == 0) && (game[1, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 0) && (game[2, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 0] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 0) && (game[1, 1] == 0) && (game[2, 1] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 2] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 1] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[0, 1] == 1) && (game[0, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 1) && (game[1, 1] == 1) && (game[1, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 1) && (game[2, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 0] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 1) && (game[1, 1] == 1) && (game[2, 1] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 2] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 1] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (gameState == 0)
            {
                if (label5.Text == "")
                {
                    if (turn == "X")
                    {
                        game[1, 1] = 1;
                        label5.Text = "X";
                        turn = "O";
                        winLabel.Text = "O turn!";
                    }
                    else
                    {
                        game[1, 1] = 0;
                        label5.Text = "O";
                        turn = "X";
                        winLabel.Text = "X turn!";
                    }
                }

                if ((game[0, 0] == 0) && (game[0, 1] == 0) && (game[0, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 0) && (game[1, 1] == 0) && (game[1, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 0) && (game[2, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 0] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 0) && (game[1, 1] == 0) && (game[2, 1] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 2] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 1] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[0, 1] == 1) && (game[0, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 1) && (game[1, 1] == 1) && (game[1, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 1) && (game[2, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 0] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 1) && (game[1, 1] == 1) && (game[2, 1] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 2] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 1] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (gameState == 0)
            {
                if (label6.Text == "")
                {
                    if (turn == "X")
                    {
                        game[1, 2] = 1;
                        label6.Text = "X";
                        turn = "O";
                        winLabel.Text = "O turn!";
                    }
                    else
                    {
                        game[1, 2] = 0;
                        label6.Text = "O";
                        turn = "X";
                        winLabel.Text = "X turn!";
                    }
                }

                if ((game[0, 0] == 0) && (game[0, 1] == 0) && (game[0, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 0) && (game[1, 1] == 0) && (game[1, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 0) && (game[2, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 0] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 0) && (game[1, 1] == 0) && (game[2, 1] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 2] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 1] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[0, 1] == 1) && (game[0, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 1) && (game[1, 1] == 1) && (game[1, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 1) && (game[2, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 0] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 1) && (game[1, 1] == 1) && (game[2, 1] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 2] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 1] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (gameState == 0)
            {
                if (label7.Text == "")
                {
                    if (turn == "X")
                    {
                        game[2, 0] = 1;
                        label7.Text = "X";
                        turn = "O";
                        winLabel.Text = "O turn!";
                    }
                    else
                    {
                        game[2, 0] = 0;
                        label7.Text = "O";
                        turn = "X";
                        winLabel.Text = "X turn!";
                    }
                }

                if ((game[0, 0] == 0) && (game[0, 1] == 0) && (game[0, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 0) && (game[1, 1] == 0) && (game[1, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 0) && (game[2, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 0] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 0) && (game[1, 1] == 0) && (game[2, 1] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 2] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 1] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[0, 1] == 1) && (game[0, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 1) && (game[1, 1] == 1) && (game[1, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 1) && (game[2, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 0] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 1) && (game[1, 1] == 1) && (game[2, 1] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 2] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 1] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (gameState == 0)
            {
                if (label8.Text == "")
                {
                    if (turn == "X")
                    {
                        game[2, 1] = 1;
                        label8.Text = "X";
                        turn = "O";
                        winLabel.Text = "O turn!";
                    }
                    else
                    {
                        game[2, 1] = 0;
                        label8.Text = "O";
                        turn = "X";
                        winLabel.Text = "X turn!";
                    }
                }

                if ((game[0, 0] == 0) && (game[0, 1] == 0) && (game[0, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 0) && (game[1, 1] == 0) && (game[1, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 0) && (game[2, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 0] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 0) && (game[1, 1] == 0) && (game[2, 1] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 2] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 1] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[0, 1] == 1) && (game[0, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 1) && (game[1, 1] == 1) && (game[1, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 1) && (game[2, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 0] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 1) && (game[1, 1] == 1) && (game[2, 1] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 2] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 1] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (gameState == 0)
            {
                if (label9.Text == "")
                {
                    if (turn == "X")
                    {
                        game[2, 2] = 1;
                        label9.Text = "X";
                        turn = "O";
                        winLabel.Text = "O turn!";
                    }
                    else
                    {
                        game[2, 2] = 0;
                        label9.Text = "O";
                        turn = "X";
                        winLabel.Text = "X turn!";
                    }
                }

                if ((game[0, 0] == 0) && (game[0, 1] == 0) && (game[0, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 0) && (game[1, 1] == 0) && (game[1, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 0) && (game[2, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 0] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 0) && (game[1, 1] == 0) && (game[2, 1] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 2] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 0) && (game[1, 1] == 0) && (game[2, 2] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 0) && (game[1, 1] == 0) && (game[2, 0] == 0))
                {
                    winLabel.Text = "O Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[0, 1] == 1) && (game[0, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[1, 0] == 1) && (game[1, 1] == 1) && (game[1, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[2, 0] == 1) && (game[2, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 0] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 1] == 1) && (game[1, 1] == 1) && (game[2, 1] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 2] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 0] == 1) && (game[1, 1] == 1) && (game[2, 2] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }

                else if ((game[0, 2] == 1) && (game[1, 1] == 1) && (game[2, 0] == 1))
                {
                    winLabel.Text = "X Player Wins!";
                    gameState = 1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
