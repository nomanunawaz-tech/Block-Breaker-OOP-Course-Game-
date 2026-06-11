using System;
using System.Collections.Generic;
using System.Text;

namespace oop_final_game
{
    internal class YellowBrick:Brick
    {
        public YellowBrick(float x, float y, bool isItSpecial) : base(x, y, System.Drawing.ColorTranslator.FromHtml("#FFDD00"), isItSpecial ? Resource.yellow_brick_s : Resource.yellow_brick)
        {
            this.isItSpecial = isItSpecial;

        }
    }
}
