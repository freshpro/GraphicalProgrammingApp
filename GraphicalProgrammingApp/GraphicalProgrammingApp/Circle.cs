using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingApp
{
    ///<summary> This class represents a circle shape
    ///</summary>
    class Circle:Shape
    {
        int radius;


        public Circle() : base()
        {

        }
        public Circle(Color colour, int x, int y, int radius) : base(colour, x, y)
        {

            this.radius = radius; //the only thing that is different from shape
        }


        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is radius
            this.radius = list[2];
            base.set(colour, list[0] - radius, list[1] - radius);

        }
        public override void draw(Graphics g)
        {


            if (!texture)
            {
                Pen p = new Pen(Color.Black, 2);
                SolidBrush b = new SolidBrush(colour);
                g.FillEllipse(b, x, y, radius * 2, radius * 2);
                g.DrawEllipse(p, x, y, radius * 2, radius * 2);
            }
            else
            {
                // in case of texture image is used
                Bitmap bitmap = new Bitmap("texture.jpg");
                TextureBrush tBrush = new TextureBrush(bitmap);

                Pen p = new Pen(Color.Black, 2);
                g.FillEllipse(tBrush, x, y, radius * 2, radius * 2);
                g.DrawEllipse(p, x, y, radius * 2, radius * 2);

            }
        }
    }
}
