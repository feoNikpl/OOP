using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint2._0
{
    class Circle:Figure
    {
        private int length, X, Y;

        public Circle(Pen Pen, int X, int Y, int length)
        {
            this.pen = Pen;
            this.length = length;
            this.X = X;
            this.Y = Y;
        }

        public override void Draw(Graphics graphic)
        {
            graphic.DrawEllipse(pen, X, Y, length, length);
        }
    }
}
