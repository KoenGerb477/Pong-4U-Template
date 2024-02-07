/*
 * Description:     A basic PONG simulator
 * Author:           
 * Date:            
 */

#region libraries

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Diagnostics;

#endregion

namespace Pong
{
    public partial class Form1 : Form
    {
        #region global values

        //graphics objects for drawing
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Font drawFont = new Font("Courier New", 10);

        // Sounds for game
        SoundPlayer scoreSound = new SoundPlayer(Properties.Resources.score);
        SoundPlayer collisionSound = new SoundPlayer(Properties.Resources.collision);

        //determines whether a key is being pressed or not
        Boolean wKeyDown, sKeyDown, upKeyDown, downKeyDown, aKeyDown, dKeyDown, leftKeyDown, rightKeyDown;

        // check to see if a new game can be started
        Boolean newGameOk = true;

        //ball values
        Boolean ballMoveRight = true;
        Boolean ballMoveDown = true;
        const int BALL_SPEED = 5;
        const int BALL_WIDTH = 20;
        const int BALL_HEIGHT = 20;
        Rectangle ball;

        //player values
        const int PADDLE_SPEED = 5;
        const int PADDLE_EDGE = 20;  // buffer distance between screen edge and paddle            
        const int PADDLE_WIDTH = 10;
        const int PADDLE_HEIGHT = 40;
        Rectangle player1, player2;

        //blocker values
        const int BLOCKER_SPEED = 6;
        const int BLOCKER_WIDTH = 10;
        const int BLOCKER_HEIGHT = 100;
        Rectangle blocker;
        Boolean blockerMoveDown = true;

        //player and game scores
        int player1Score = 0;
        int player2Score = 0;
        int gameWinScore = 2;  // number of points needed to win game

        Stopwatch powerUpTiming = new Stopwatch();
        Boolean powerUpA = false;
        Boolean powerUpB = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //check to see if a key is pressed and set is KeyDown value to true if it has
            switch (e.KeyCode)
            {
                case Keys.W:
                    wKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;
                case Keys.A:
                    aKeyDown = true;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    break;
                case Keys.Up:
                    upKeyDown = true;
                    break;
                case Keys.Down:
                    downKeyDown = true;
                    break;
                case Keys.Left:
                    leftKeyDown = true;
                    break;
                case Keys.Right:
                    rightKeyDown = true;
                    break;
                case Keys.Y:
                case Keys.Space:
                    if (newGameOk)
                    {
                        SetParameters();
                    }
                    break;
                case Keys.Escape:
                    if (newGameOk)
                    {
                        Close();
                    }
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //check to see if a key has been released and set its KeyDown value to false if it has
            switch (e.KeyCode)
            {
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
                case Keys.Up:
                    upKeyDown = false;
                    break;
                case Keys.Down:
                    downKeyDown = false;
                    break;
                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.Left:
                    leftKeyDown = false;
                    break;
                case Keys.Right:
                    rightKeyDown = false;
                    break;
            }
        }

        /// <summary>
        /// sets the ball and paddle positions for game start
        /// </summary>
        private void SetParameters()
        {
            if (newGameOk)
            {
                player1Score = player2Score = 0;
                newGameOk = false;
                startLabel.Visible = false;
                gameUpdateLoop.Start();
                player1ScoreLabel.Text = Convert.ToString(player1Score);
                plaery2ScoreLabel.Text = Convert.ToString(player2Score);
            }

            //player start positions
            player1 = new Rectangle(PADDLE_EDGE, this.Height / 2 - PADDLE_HEIGHT / 2, PADDLE_WIDTH, PADDLE_HEIGHT);
            player2 = new Rectangle(this.Width - PADDLE_EDGE - PADDLE_WIDTH, this.Height / 2 - PADDLE_HEIGHT / 2, PADDLE_WIDTH, PADDLE_HEIGHT);

            // TODO create a ball rectangle in the middle of screen
            ball = new Rectangle(this.Width / 2 - BALL_WIDTH / 2, this.Height / 2 - BALL_HEIGHT / 2, BALL_WIDTH, BALL_HEIGHT);

            //blocker start positions
            blocker = new Rectangle(this.Width / 2 - BLOCKER_WIDTH / 2, 0, BLOCKER_WIDTH, BLOCKER_HEIGHT);
        }

        /// <summary>
        /// This method is the game engine loop that updates the position of all elements
        /// and checks for collisions.
        /// </summary>
        private void gameUpdateLoop_Tick(object sender, EventArgs e)
        {
            #region update ball position

            // TODO create code to move ball either left or right based on ballMoveRight and using BALL_SPEED
            if (ballMoveRight)
            {
                ball.X += BALL_SPEED;
            }
            else
            {
                ball.X -= BALL_SPEED;
            }
            // TODO create code move ball either down or up based on ballMoveDown and using BALL_SPEED
            if (ballMoveDown)
            {
                ball.Y += BALL_SPEED;
            }
            else
            {
                ball.Y -= BALL_SPEED;
            }
            #endregion

            #region update paddle positions

            if (wKeyDown == true && player1.Y > 0)
            {
                // TODO create code to move player 1 up
                player1.Y -= PADDLE_SPEED;
            }
            // TODO create an if statement and code to move player 1 down 
            if (sKeyDown == true && player1.Y < this.Height - PADDLE_HEIGHT)
            {
                player1.Y += PADDLE_SPEED;
            }
            // TODO create an if statement and code to move player 2 up
            if (upKeyDown == true && player2.Y > 0)
            {
                player2.Y -= PADDLE_SPEED;
            }
            // TODO create an if statement and code to move player 2 down
            if (downKeyDown == true && player2.Y < this.Height - PADDLE_HEIGHT)
            {
                player2.Y += PADDLE_SPEED;
            }
            #endregion

            #region ball collision with top and bottom lines

            if (ball.Y < 0) // if ball hits top line
            {
                // TODO use ballMoveDown boolean to change direction
                ballMoveDown = true;
                // TODO play a collision sound
                collisionSound.Play();
            }
            // TODO In an else if statement check for collision with bottom line
            // If true use ballMoveDown boolean to change direction
            else if (ball.Y > this.Height - BALL_HEIGHT)
            {
                ballMoveDown = false;

                collisionSound.Play();
            }

            #endregion

            #region ball collision with paddles

            // TODO create if statment that checks if player1 collides with ball and if it does
            // --- play a "paddle hit" sound and
            // --- use ballMoveRight boolean to change direction
            //if (player1.IntersectsWith(ball))
            //{
            //    ballMoveRight = true;
            //    collisionSound.Play();
            //}
            // TODO create if statment that checks if player2 collides with ball and if it does
            // --- play a "paddle hit" sound and
            // --- use ballMoveRight boolean to change direction
            //if (player2.IntersectsWith(ball))
            //{
            //    ballMoveRight = false;
            //    collisionSound.Play(); 
            //}
            /*  ENRICHMENT
             *  Instead of using two if statments as noted above see if you can create one
             *  if statement with multiple conditions to play a sound and change direction
             */
            if (player1.IntersectsWith(ball) || player2.IntersectsWith(ball))
            {
                collisionSound.Play();
                ballMoveRight = !ballMoveRight;
                if (ballMoveRight)
                {
                    ball.X = player1.X + PADDLE_WIDTH;
                }
                else
                {
                    ball.X = player2.X - BALL_WIDTH;
                }

            }

            #endregion

            #region ball collision with side walls (point scored)

            if (ball.X < 0)  // ball hits left wall logic
            {
                // TODO
                // --- play score sound
                // --- update player 2 score and display it to the label
                scoreSound.Play();
                player2Score++;
                plaery2ScoreLabel.Text = Convert.ToString(player2Score);
                // TODO use if statement to check to see if player 2 has won the game. If true run 
                // GameOver() method. Else change direction of ball and call SetParameters() method.
                if (player2Score > gameWinScore)
                {
                    GameOver("Player 2");
                }
                else
                {
                    ballMoveRight = true;
                    SetParameters();
                }
            }

            // TODO same as above but this time check for collision with the right wall
            if (ball.X > this.Width - BALL_WIDTH)  // ball hits right wall logic
            {
                // TODO
                // --- play score sound
                // --- update player 1 score and display it to the label
                scoreSound.Play();
                player1Score++;
                player1ScoreLabel.Text = Convert.ToString(player1Score);
                // TODO use if statement to check to see if player 1 has won the game. If true run 
                // GameOver() method. Else change direction of ball and call SetParameters() method.
                if (player1Score > gameWinScore)
                {
                    GameOver("Player 1");
                }
                else
                {
                    ballMoveRight = false;
                    SetParameters();
                }
            }
            #endregion

            #region blocker movement
            if (blockerMoveDown)
            {
                blocker.Y += BLOCKER_SPEED;
            }
            else
            {
                blocker.Y -= BLOCKER_SPEED;
            }
            #endregion

            #region blocker change direction
            if (blocker.Y > this.Height - BLOCKER_HEIGHT || blocker.Y < 0)
            {
                blockerMoveDown = !blockerMoveDown;     
            }
            #endregion

            #region ball collides with blocker
            if (ball.IntersectsWith(blocker))
            {
                ballMoveRight = !ballMoveRight;
            }
            #endregion

            #region cooldown on power ups
            if (powerUpTiming.ElapsedMilliseconds > 5000)
            {
                powerUpA1Label.Visible = true;
                powerUpA2Label.Visible = true;
                powerUpB1Label.Visible = true;
                powerUpB2Label.Visible = true;
            }
            #endregion

            #region using powerups
            if ((aKeyDown || leftKeyDown) && powerUpTiming.ElapsedMilliseconds > 5000 || powerUpTiming.ElapsedMilliseconds == 0)
            {
                powerUpTiming.Reset();
                powerUpTiming.Start();
                powerUpA = true;

                if (aKeyDown)
                {
                    powerUpA1Label.Visible = false;
                }
                else if (leftKeyDown)
                {
                    powerUpA2Label.Visible = false;
                }
            }
            if ((dKeyDown || rightKeyDown) && powerUpTiming.ElapsedMilliseconds > 5000 || powerUpTiming.ElapsedMilliseconds == 0)
            {
                powerUpTiming.Reset();
                powerUpTiming.Start();
                powerUpB = true;

                if (dKeyDown)
                {
                    powerUpB1Label.Visible = false;
                }
                else if (rightKeyDown)
                {
                    powerUpB2Label.Visible = false;
                }
            }

            if (powerUpA && powerUpTiming.ElapsedMilliseconds < 2000)
            {
                blocker.Height = this.Height;
                blocker.Y = 0;
            }
            else if (powerUpB && powerUpTiming.ElapsedMilliseconds < 2000)
            {
                blocker.Height = 0;
            }

            if(powerUpTiming.ElapsedMilliseconds > 2000)
            {
                blocker.Height = BLOCKER_HEIGHT;
                powerUpA = false;
                powerUpB = false;
            }
            #endregion
            //refresh the screen, which causes the Form1_Paint method to run
            this.Refresh();
        }

        /// <summary>
        /// Displays a message for the winner when the game is over and allows the user to either select
        /// to play again or end the program
        /// </summary>
        /// <param name="winner">The player name to be shown as the winner</param>
        private void GameOver(string winner)
        {
            newGameOk = true;

            // TODO create game over logic
            // --- stop the gameUpdateLoop
            gameUpdateLoop.Stop();
            // --- show a message on the startLabel to indicate a winner, (may need to Refresh).
            startLabel.Visible = true;
            startLabel.Text = $"{winner} Wins!!!\n";
            // --- use the startLabel to ask the user if they want to play again
            startLabel.Text += "Press Space to Start or Esc to Exit";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // TODO draw player2 using FillRectangle
            e.Graphics.FillRectangle(whiteBrush, player1);
            e.Graphics.FillRectangle(whiteBrush, player2);

            // TODO draw ball using FillRectangle
            e.Graphics.FillRectangle(whiteBrush, ball);

            //draw blocker
            e.Graphics.FillRectangle(whiteBrush, blocker);
        }

    }
}
