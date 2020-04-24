using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint2._0
{
    class Ellipse:Figure
    {
        private int height, width, X, Y;

        public Ellipse(Pen Pen, int X, int Y, int height, int width)
        {
            this.pen = Pen;
            this.height = height;
            this.width = width;
            this.X = X;
            this.Y = Y;
        }

        public override void Draw(Graphics graphic)
        {
            graphic.DrawEllipse(pen, X, Y, width, height);
        }
    }
}
