using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingApp
{

    ///<summary>This class represent a polygon shape
    ///</summary>
    class Polygon:Shape
    {

        int[] pointsCo;
        public Polygon() : base()
        {

        }
        public Polygon(Color colour, int x, int y) : base(colour, x, y)
        {


        }
        ///<summary>To set Polygon points and colours
        ///</summary>
        public override void set(Color colour, params int[] list)
        {
            //list[list.Length-2] is x, list[list.Length-1] is y
            base.set(colour, list[list.Length - 2], list[list.Length - 1]);
            pointsCo = list;

        }
        ///<summary>To draw the ploygon
        ///</summary>
        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);


            // Create points that define polygon.
            int i = 0;
            int pc = 0;
            Point[] curvePoints = new Point[pointsCo.Length / 2];
            Point point1 = new Point(pointsCo[pointsCo.Length - 2], pointsCo[pointsCo.Length - 1]);
            curvePoints[pc] = point1;
            pc++;
            while (i < pointsCo.Length - 2)
            {
                point1 = new Point(pointsCo[i], pointsCo[i + 1]);
                // Console.WriteLine("PC: " + pc + " -"+point1.ToString() + " ");
                curvePoints[pc] = point1;
                pc++;
                i = i + 2;
            }

            // Draw polygon to screen.
            g.DrawPolygon(p, curvePoints);
            SolidBrush b = new SolidBrush(colour);
            g.FillPolygon(b, curvePoints);
        }

    }
}
