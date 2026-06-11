using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace oop_final_game
{
    internal class PlumBrick : Brick
    {

        public PlumBrick(float x, float y, bool isItSpecial) : base(x, y, System.Drawing.ColorTranslator.FromHtml("#91278F"), isItSpecial ? Resource.plum_brick_s : Resource.plum_brick)
        {
            this.isItSpecial = isItSpecial;

        }
    }
}
