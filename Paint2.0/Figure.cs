using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint2._0
{
   abstract class Figure
    {
        public Pen pen;

        public abstract void Draw(Graphics graphics);
    }
}
