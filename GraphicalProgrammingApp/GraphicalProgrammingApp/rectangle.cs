﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingApp
{
    class Rectangle:Shape
    {
        int width, height, rotate;
        public Rectangle() : base()
        {
            width = 100;
            height = 100;
        }
        public Rectangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {

            this.width = width; //the only thing that is different from shape
            this.height = height;
        }

        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is width, list[3] is height
            base.set(colour, list[0], list[1]);
            if (list.Length - 1 < 3)
            {

                this.width = list[2];
                this.height = list[2];
            }
            else
            {
                this.width = list[2];
                this.height = list[3];
            }
            if (list.Length == 5)
            {
                rotate = list[4];
            }


        }

        public override void draw(Graphics g)
        {
           
                Pen p = new Pen(Color.Black, 2);
                SolidBrush b = new SolidBrush(colour);
                g.FillRectangle(b, x, y, width, height);
                g.DrawRectangle(p, x, y, width, height);
            }

        }
   }
  