using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase_Forms
{
    class Line
    {
        private Point fromPoint;
        private Point toPoint;

        public Line(Point fromPoint, Point toPoint)
        {
            this.fromPoint = fromPoint;
            this.toPoint = toPoint;
        }

        public void drawLine(Graphics g)
        {
            Pen myPen = new Pen(Color.Black, 4);
            g.DrawLine(myPen, fromPoint, toPoint);
        }
    }
}
