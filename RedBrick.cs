using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace oop_final_game
{
    internal class RedBrick : Brick
    {

        public RedBrick(float x, float y, bool isItSpecial) : base(x, y, System.Drawing.ColorTranslator.FromHtml("#ED1C24"), isItSpecial ? Resource.red_brick_s : Resource.red_brick)
        {
            this.isItSpecial = isItSpecial;
            
        }
    }
}
