using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;

namespace oop_final_game
{
    internal class Ball : GameObject
    {
        public bool isStuck=true;
        public float speX=0f;
        public float speY=-11f;
        public const int WIDTH= 25;
        public const int HEIGHT= 25;
        public Ball(float x, float y,Color color) : base(x, y, color, Resource.brown_brick)
        {
            this.Width = WIDTH;
            this.Height = HEIGHT;

            this.speed = 5f;
           
        }
        public override void Draw(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (SolidBrush ballBrush = new SolidBrush(this.color))
            {
                g.FillEllipse(ballBrush, this.X, this.Y, this.Width, this.Height);
            }
        }
    }
}
