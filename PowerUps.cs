using System;
using System.Drawing;

namespace oop_final_game
{
    public enum PowerUpType
    {
        ExtraBall,
        ExtraLife,
        ExpandPaddle
    }

    public class PowerUp : GameObject
    {
        public PowerUpType Type { get; set; }
        public float SpeedY { get; set; } = 3.5f;

        public PowerUp(float x, float y, PowerUpType type) 
            : base(x, y, Color.Transparent, GetImageForType(type))
        {
            Type = type;
            this.Width = 35; 
            this.Height = 35;
        }

        private static Image GetImageForType(PowerUpType type)
        {
            switch (type)
            {
                case PowerUpType.ExtraBall:
                    return Resource.ball;

                case PowerUpType.ExpandPaddle:
                    return Resource.Expand_paddle;

                case PowerUpType.ExtraLife:
                    return Resource.star1; 
                default:
                    return Resource.yellow_brick;
            }
        }

        public void Move()
        {
            Y += SpeedY;
        }
    }
}