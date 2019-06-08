using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticSimulator
{
    public class BallSprite : Sprite
    {
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, Position.X, Position.Y, 2, 2);
        }
    }
}
