using System.Drawing;

namespace oop_final_game
{
    // Interface for anything that has boundaries for collision detection
    public interface ICollidable
    {
        Rectangle GetBounds();
    }
}
