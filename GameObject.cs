using System;
using System.Collections.Generic;
using System.Text;

namespace oop_final_game
{
    public  class GameObject : IDrawable, ICollidable
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Color color { get; set; }

        public Image sprite;
        public bool isAlive;
        public float speed;

        public GameObject(float x, float y,Color color,Image sprite)
        {
            this.color = color;
            X = x;
            Y = y;
            isAlive = true;
           
                            
                this.sprite = sprite;
            
        }

        public virtual void Draw(Graphics g)
        {
            if (this.sprite != null)
            {
                g.DrawImage(this.sprite, this.X, this.Y, this.Width, this.Height);
            }
        }

        public virtual void Update()
        {
        }

        public  Rectangle GetBounds()
        {
            return new Rectangle((int)X, (int)Y, Width, Height);
        }
    }
}
