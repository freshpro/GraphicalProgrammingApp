using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingApp
{
    /// <summary>
    /// Represent a line shape
    /// </summary>
    class Line : Shape
    {
        int x1, y1, x2, y2;
        public Line() : base()
        {
            x1 = 100;
            y1 = 100;
        }
        public Line(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {

            this.x1 = width;
            this.y1 = height;
        }

        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is end point x, list[3] is end point y
            base.set(colour, list[0], list[1]);
            this.x1 = list[0];
            this.y1 = list[1];
            this.x2 = list[2];
            this.y2 = list[3];
        }

        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.DrawLine(p, x1, y1, x2, y2);

        }

    }

}






