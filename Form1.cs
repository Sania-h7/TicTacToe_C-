using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        //static string player1, player2;
        public Form1()
        {
            InitializeComponent();
        }
        /* public static void setplayername(string n1 , string n2)
        {
            player1 = n1;
            player2 = n2;
        }

        */
        private void Form1_Load(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.ShowDialog();
            //label1.Text = player1;
                //label5.Text = player2;
        } 

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Simple TicTacToe Game With Two Players" ,"TIC TAC TOE ABOUT");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.Yellow;

            if (turn)

                b.Text = "o";
            else 
                
                     b.Text = "x";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforwinner();

        }
        private void checkforwinner()
        {
            bool there_is_a_winner = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)  &&(!A1.Enabled))
                there_is_a_winner = true;
            else  if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else  if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;



            if (there_is_a_winner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    winner = p2.Text;
                   
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();


                }

                else
                {
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                    winner = p1.Text;
            }
                MessageBox.Show(winner  + "congratulation you win! 🎉🎉");
            }
            else
            {
                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();

                    MessageBox.Show( " draw  you lose the game play again 🙃🙃");
                }
            }
        }
        

        private  void disableButtons() 
        {

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }

                catch
                {

                }
            }
            
            }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count= 0;
           
                foreach (Control c in Controls)
                {
                    try
                    {

                        Button b = (Button)c;
                    b.Enabled = true;
                    b.UseVisualStyleBackColor = true;
                    b.Text = "";
                }

                catch
                {

                }
            }
            

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_enter(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (true)
                    b.Text = "x";
                else
                    b.Text = "0";
            }
        }
        


        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
             o_win_count.Text = "0";
               x_win_count.Text = "0";
            draw_count.Text = "0"; 
        }

        private void p1_TextChanged(object sender, EventArgs e)
        {

        }
    }



    } 

