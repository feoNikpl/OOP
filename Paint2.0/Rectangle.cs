using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint2._0
{
    class Rectangle : Figure
    {
        private int height, width, X, Y;

        public Rectangle(Pen pen, int X, int Y, int height, int width)
        {
            this.pen = pen;
            this.height = height;
            this.width = width;
            this.X = X;
            this.Y = Y;
        }

        public override void Draw (Graphics graphic)
        {
            graphic.DrawRectangle(pen, X, Y, width, height);
        }
    }
}
