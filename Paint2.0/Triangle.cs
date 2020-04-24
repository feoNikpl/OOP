using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint2._0
{
    class Triangle:Figure
    {
        public Point Point1, Point2, Point3;
        public Triangle(Pen pen, Point Point1, Point Point2, Point Point3)
        {
            this.pen = pen;
            this.Point1 = Point1;
            this.Point2 = Point2;
            this.Point3 = Point3;
        }
        public override void Draw(Graphics graphic)
        {
            graphic.DrawLine(pen, Point1, Point2);
            graphic.DrawLine(pen, Point2, Point3);
            graphic.DrawLine(pen, Point1, Point3);
        }
    }
}
