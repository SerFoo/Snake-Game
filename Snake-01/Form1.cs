using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Snake_01
{
    public partial class Form1 : Form
    {
        bool  p1_w,p1_s,p2_w, p2_s, winner;// boolean to be used to detect player position
        int speed = 10; 
        int ballx = 8, bally = 8; // horizontal and vertical speed value for the ball object  
        int p1score = 0, p2score = 0, maxscore = 5;
        string endmessage = "Would you to play again?";
        string title = "Restart?";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Init
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void keydown(object sender, KeyEventArgs e)
        {

            //Player 1 Movement Booleans
            if (e.KeyCode == Keys.W)
                p1_w = true;
            if (e.KeyCode == Keys.S)
                p1_s = true;
            //Player 2 Movement Booleans
            if (e.KeyCode == Keys.Up)
                p2_w = true;
            if (e.KeyCode == Keys.Down)
                p2_s = true;

            //End Program on ESC Key
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            //Player 1 Movement Booleans
            if (e.KeyCode == Keys.W)
                p1_w = false;
            if (e.KeyCode == Keys.S)
                p1_s = false;

            //Player 2 Movement Booleans
            if (e.KeyCode == Keys.Up)
                p2_w = false;
            if (e.KeyCode == Keys.Down)
                p2_s = false;
        }
        //Game Loop
        private void timerTick(object sender, EventArgs e)
         {
            Player1Score.Text = "" + p1score;
            Player2Score.Text = "" + p2score;

            Ball.Top -= bally;
            Ball.Left -= ballx;


            if(p1score < maxscore)
            {
                if(p2score < maxscore)
                {
                    //If player two scores
                    if(Ball.Left < 0) //If Ball Went past player 1(left)
                    {
                        Ball.Left = 434;//Set Ball To Center of the screen
                        ballx = -ballx;
                        ballx += 2;
                        p2score++;
                    }
                    //If player one scores
                    if (Ball.Left + Ball.Width > ClientSize.Width) //If Ball Went past player 1(left)
                    {
                        Ball.Left = 434;//Set Ball To Center of the screen
                        ballx = -ballx;
                        ballx += 3;
                        p1score++;
                    }

                    if (Ball.Top < 0 || Ball.Top + Ball.Height > ClientSize.Height)
                    {
                        bally = -bally;
                    }


                    //Player Movement
                    if (p1_w == true && Player1.Top > 0)
                        Player1.Top -= speed;
                    if (p1_s == true && Player1.Top < 455)
                        Player1.Top += speed;

                    if (p2_w == true && Player2.Top > 0)
                        Player2.Top -= speed;
                    if (p2_s == true && Player2.Top < 455)
                        Player2.Top += speed;

                    //Boundary Check
                    if (Ball.Bounds.IntersectsWith(Player1.Bounds) || Ball.Bounds.IntersectsWith(Player2.Bounds))
                        ballx = -ballx;
                }
            }
            if(p1score == maxscore || p2score == maxscore)
            {
                if (p1score > p2score)
                    winner = true;
                else
                    winner = false;

                GameTimer.Stop();
                if (winner)
                    MessageBox.Show("Congrats Player 1!");
                else
                    MessageBox.Show("Congrats Player 2!");
                DialogResult result = MessageBox.Show(endmessage, title, buttons);
                if (result == DialogResult.No)
                    this.Close();
                else
                    RestartGame();
            }
        }

        private void RestartGame()
        {
            p1score = 0;
            p2score = 0;
            Ball.Left = 434;//Set Ball To Center of the screen
            ballx = -ballx;
            ballx += 3;
            GameTimer.Start();
        }
    }
}
