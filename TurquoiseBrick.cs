using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace oop_final_game
{
    internal class TurquoiseBrick : Brick
    {

        public TurquoiseBrick(float x, float y, bool isItSpecial) : base(x, y, System.Drawing.ColorTranslator.FromHtml("#00AAE5"), isItSpecial ? Resource.turquoise_brick_s : Resource.turquoise_brick)
        {
            this.isItSpecial = isItSpecial;

        }
    }
}
