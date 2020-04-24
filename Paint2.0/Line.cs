using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint2._0
{
    class Line: Figure
    {
        public Point Point1, Point2;
        public Line(Pen pen, Point firstPoint, Point secondPoint)
        {
            this.pen = pen;
            this.Point1 = firstPoint;
            this.Point2 = secondPoint;
        }
        public override void Draw(Graphics graphic)
        {
            graphic.DrawLine(pen, Point1, Point2);
        }
    }
}
