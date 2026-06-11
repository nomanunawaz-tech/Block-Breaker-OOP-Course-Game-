using System;
using System.Drawing;

namespace oop_final_game
{
    public enum PowerUpType
    {
        WidePaddle,
        SlowBall,
        ExtraBall,
        ScoreBoost
    }

    public class PowerUp
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; } = 25;
        public int Height { get; set; } = 15;
        public float SpeedY { get; set; } = 3.5f;
        public PowerUpType Type { get; set; }

        public PowerUp(float x, float y, PowerUpType type)
        {
            X = x;
            Y = y;
            Type = type;
        }

        public void Move()
        {
            Y += SpeedY;
        }

        public Rectangle GetBounds()
        {
            return new Rectangle((int)X, (int)Y, Width, Height);
        }

        public void Draw(Graphics g)
        {
            Brush brush;

            switch (Type)
            {
                case PowerUpType.WidePaddle:
                    brush = Brushes.Cyan;
                    break;
                case PowerUpType.SlowBall:
                    brush = Brushes.LimeGreen;
                    break;
                case PowerUpType.ExtraBall:
                    brush = Brushes.Gold;
                    break;
                case PowerUpType.ScoreBoost:
                    brush = Brushes.Magenta;
                    break;
                default:
                    brush = Brushes.White;
                    break;
            }

            g.FillEllipse(brush, X, Y, Width, Height);

            using (Pen borderPen = new Pen(Color.White, 1.5f))
            {
                g.DrawEllipse(borderPen, X, Y, Width, Height);
            }
        }
    }
}