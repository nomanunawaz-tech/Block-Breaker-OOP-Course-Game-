using EZInput;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.AxHost;

namespace oop_final_game
{
    internal class Game
    {
        public bool isOver = false;
        public bool isGameLost = false;
        public int screenWidth;
        public int screenHeight;
        public int timmer = 1000;

        private int totalBalls = 3;
        private List<Ball> scoreBalls = new List<Ball>();
        public int scores;

        private List<Brick> bricks = new List<Brick>();
        private List<PowerUp> powerUps = new List<PowerUp>();
        private Paddle paddle;
        List<Ball> balls;
        //GameObject star;

        public Game(int screenWidth, int screenHeight)
        {
            SoundManager.Initialize();
            scores=0;
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
            paddle = new Paddle(screenWidth / 2 - Paddle.WIDTH / 2, screenHeight - 50, screenWidth, screenHeight);

            balls = new List<Ball>();
            addPaddleBall();
            addScoreBalls();
            //addBricks(50);

            
        }

        void addPaddleBall()
        {
            if(balls.Count == 0)
            {
                Ball ball = new Ball(paddle.X + Paddle.WIDTH / 2 - 12.5f, paddle.Y - 25, System.Drawing.Color.White);
                ball.isStuck = true;
                balls.Add(ball);
            }
        }
        void addScoreBalls()
        {
             for(int i = 1; i <= totalBalls; i++)
            {
                Ball ball = new Ball(screenWidth-(Ball.WIDTH+7)*i,10, System.Drawing.Color.White);
                ball.isStuck = true;
                ball.speY = 0;
                ball.speX = 0; 
                scoreBalls.Add(ball);
            }

        }
        public void update()
        {
            checkKeyPressed();  
            checkBricksCollision();
            checkCollisionWithPaddle();
            clearLists();
            timmer -= 1;

            if (bricks.Count <= 0 || timmer < 0)
            {
                //addBricks(-160);
                bricks.AddRange(LevelGenerator.GenerateRandomLayout(40));
                timmer = 2700;
            }

            if (balls.Count <= 0)
            {
                if(scoreBalls.Count <= 0)
                {
                    // Game Over logic 
                    isOver = true;
                    isGameLost = true;
                    return;
                }
                addPaddleBall();
                scoreBalls.RemoveAt(0);
                totalBalls -= 1;

            }

            foreach (var brick in bricks)
            {
                brick.Update();
            }

            foreach (Ball ball in balls)
            {

                if (ball.isStuck)
                {

                    ball.X = paddle.X + (paddle.Width / 2f) - (ball.Width / 2f);
                    ball.Y = paddle.Y - ball.Height - 1;
                }

                else
                {
                    ball.Y += ball.speY;
                    ball.X += ball.speX;
                }
            }



        }
        void checkCollisionWithPaddle()
        {
            foreach (Ball ball in balls)
            {
                if (ball.isStuck) continue;

                if (ball.X < 0 || ball.X + ball.Width > screenWidth)
                {
                    ball.speX = -ball.speX;
                }
                    if (ball.Y <= 0)
                    {
                        ball.speY = -ball.speY;
                }
                if (ball.Y > screenHeight)
                {
                    ball.isAlive = false;

                }

                if (ball.GetBounds().IntersectsWith(paddle.GetBounds()) && ball.Y <= paddle.Y)
                {
                    setBallDirection(ball);
                }


            }
        }
        void setBallDirection(Ball ball)
        {
                    float paddleCenter = paddle.X + (paddle.Width / 2f);
                    float ballCenter = ball.X + (ball.Width / 2f);

                    float relativeHitPoint = ballCenter - paddleCenter;

                    float normalizedHit = relativeHitPoint / (paddle.Width / 2f);

                    float maxHorizontalSpeed = 10f;

                    ball.speX = normalizedHit * maxHorizontalSpeed;

                    ball.speY = -Math.Abs(ball.speY);
                
            
        }

        void checkBricksCollision()
        {
            List<Ball> ballsToAdd = new List<Ball>();

            foreach (Ball ball in balls)
            {
                foreach (Brick brick in bricks)
                {
                    if (!brick.isAlive) continue;

                    if (ball.GetBounds().IntersectsWith(brick.GetBounds()))
                    {
                        var bBounds = ball.GetBounds();
                        var rBounds = brick.GetBounds();

                        float ballCenterX = bBounds.X + (bBounds.Width / 2f);

                        if (ballCenterX >= rBounds.Left && ballCenterX <= rBounds.Right)
                        {
                            ball.speY = -ball.speY; 
                        }
                        else
                        {
                            ball.speX = -ball.speX; // Bounce horizontally
                        }

                        // Destroy the brick and handle scoring
                        brick.isAlive = false;
                        scores += 1;

                        if (brick.isItSpecial)
                        {
                            Random ran = new Random();
                            PowerUpType randomType = (PowerUpType)ran.Next(0, Enum.GetValues(typeof(PowerUpType)).Length);
                            powerUps.Add(new PowerUp(brick.X, brick.Y, randomType));
                            SoundManager.PlayPaddleHit();

                            Ball newBall = new Ball(brick.X, brick.Y, brick.color);
                            newBall.speY = -newBall.speY;
                            newBall.isStuck = false;
                            ballsToAdd.Add(newBall);
                        }
                        else
                        {
                            SoundManager.PlayBrickHit();
                        }

                        break;
                    }
                }
            }

            if (ballsToAdd.Count > 0)
            {
                balls.AddRange(ballsToAdd);
            }
        }

        void clearLists()
        {
            bricks.RemoveAll(b => !b.isAlive);
            balls.RemoveAll(b => b.Y > screenHeight);
        }

        void checkKeyPressed()
            {
                if (EZInput.Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    paddle.MoveLeft();
                }
                else if (EZInput.Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    paddle.MoveRight();
                }
                if (EZInput.Keyboard.IsKeyPressed(Key.Space))
                {
                    foreach (Ball ball in balls)
                    {
                        if (ball.isStuck)
                        {
                            ball.isStuck = false;
                        }
                    }
                }
            }
        

        public void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //backGround.Draw(g);
            paddle.Draw(g);

            foreach (Brick brick in bricks)
            {
                brick.Draw(g);
            }

            foreach (Ball ball in balls)
            {
                    ball.Draw(g);
            }
            foreach (Ball scoreBall in scoreBalls)
            {
                scoreBall.Draw(g);
            }
            foreach(PowerUp p in powerUps)
                {
                p.Draw(g);
                p.Move();
            }
            using (Font scoreFont = new Font("Arial", 16, FontStyle.Bold))
            {
                g.DrawString("Score: " + scores, scoreFont, Brushes.White, 15, 15);
            }



        }

        public void addBricks(int start)
        {
            Random ran = new Random();

            int totalRows = 5;
            int totalColumns = 12;
            int padding = 7;
            int startX = 150;
            int startY = start; 

            for (int r = 0; r < totalRows; r++)
            {
                int brickType = ran.Next(1, 7);

                for (int c = 0; c < totalColumns; c++)
                {
                    float xPos = startX + (c * (Brick.WIDTH + padding));
                    float yPos = startY + (r * (Brick.HEIGHT + padding));
                    bricks.Add(getBrick(xPos, yPos, brickType));
                   
                }
            }
           


            Brick getBrick(float xPos,float yPos,int brickType )
            {

                Brick brick;
                Random ran = new Random();
                bool isItSpecial = false;

                int number =ran.Next(1, 6);

                if (number == 5)
                {
                    isItSpecial = true;
                }


                switch (brickType)
                {
                    case 1:
                        brick=new RedBrick(xPos, yPos, isItSpecial);
                        break;

                    case 2:
                        brick=new YellowBrick(xPos, yPos, isItSpecial);
                        break;

                    case 3:
                        brick = new PlumBrick(xPos, yPos, isItSpecial);
                        break;

                    case 4:
                        brick = new GreenBrick(xPos, yPos, isItSpecial);
                        break;

                    case 5:
                        brick = new TurquoiseBrick(xPos, yPos, isItSpecial);
                        break;

                        case 6:
                            brick = new BrownBrick(xPos, yPos, isItSpecial);
                        break;

                    default:
                        brick = new TurquoiseBrick(xPos, yPos, isItSpecial);
                        break;

                       
                }
                return brick;
            }
            


        }
    }
}
