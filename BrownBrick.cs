using System;
using System.Collections.Generic;
using System.Text;

namespace oop_final_game
{
    internal class BrownBrick : Brick
    {
        public BrownBrick(float x, float y, bool isItSpecial) : base(x, y, System.Drawing.ColorTranslator.FromHtml("#754C1F"), isItSpecial ? Resource.brown_brick_s : Resource.brown_brick)
        {
            this.isItSpecial = isItSpecial;

        }
    }
}
