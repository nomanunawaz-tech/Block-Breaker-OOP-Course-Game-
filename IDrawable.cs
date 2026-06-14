using System.Drawing;

namespace oop_final_game
{
    // Interface for anything that can be drawn on the screen
    public interface IDrawable
    {
        void Draw(Graphics g);
    }
}
