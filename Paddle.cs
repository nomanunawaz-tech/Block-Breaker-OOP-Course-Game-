using System;
using System.Collections.Generic;
using System.Text;

namespace oop_final_game
{
    internal class Paddle: GameObject
    {
         public const int WIDTH = 250;
         const int HEIGHT = 35;
         const int SPEED = 13;

        public bool movingLeft;
        public bool movingRight;

        int screenWidth;
         int screenHeight;
        public Paddle(int x,int y,int screenWidth,int screenHeight) : base(x, y, System.Drawing.Color.DarkBlue, Resource.Yellow_paddle)
        {
            this.Width = WIDTH;
            this.Height = HEIGHT;
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
            this.movingLeft = false;
            this.movingRight = false;
        }

        public void MoveLeft()
        {
            if (this.X > 0)
                this.X -= SPEED;
        }
        public void MoveRight()
        {
            if (this.X < screenWidth - this.Width)
                this.X += SPEED;
           
        }

    }
}
