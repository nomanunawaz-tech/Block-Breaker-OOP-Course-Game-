using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace oop_final_game
{
    internal class GreenBrick : Brick
    {

        public GreenBrick(float x, float y, bool isItSpecial) : base(x, y, System.Drawing.Color.Green, isItSpecial ? Resource.green_brick_s : Resource.green_brick)
        {
            this.isItSpecial = isItSpecial;

        }
    }
}
