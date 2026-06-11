using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace oop_final_game
{
    internal class Brick : GameObject
    {
        public const int WIDTH = 85;
        public const int HEIGHT = 30;
    
        public bool isItSpecial;
        public Brick(float x, float y, Color color, Image sprite) : base(x, y,color, sprite)
        {
            this.Width = WIDTH;
            this.Height = HEIGHT;
            this.speed = 0.1f;


        }
        public override void Update()
        {
            this.Y += speed;
        }


    }
}
