using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingApp
{
    /// <summary>  
    ///  This is abstract class for shape object 
    ///  Common feature of shapes are represent by this class  
    ///  This class is extend by concrete shape classes like
    ///  circle,square,rectangle,polygon,line etc.
    /// 
    /// </summary> 
    public abstract class Shape : Shapes
    {
        /// <summary>
        /// Colour of the shape 
        /// </summary>
        protected Color colour; //shape's colour
        /// <summary>
        /// Position of the shape
        /// </summary>
        protected int x, y; // shapes position
        /// <summary>
        /// To set whether to use colour or texture while drawing the shape
        /// </summary>
        protected bool texture;



        /// <summary>
        /// Consturtor to do the default settings of shape objects
        /// Colour to red
        /// and position to 100,100
        /// </summary>

        public Shape()

        {
            colour = Color.Red;
            x = y = 100;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="colour">Fill colour of the shape</param>
        /// <param name="x">X cooridanate</param>
        /// <param name="y">Y cooridanate</param>
        public Shape(Color colour, int x, int y)
        {

            this.colour = colour; //shape's colour
            this.x = x; //its x pos
            this.y = y; //its y pos

        }


        /// <summary>
        /// The methods below is from the Shapes interface
        /// Will be defined in the concrete class that extends this abstract class
        /// </summary>
        /// <param name="g">Graphics Object</param>
        public abstract void draw(Graphics g);
        /// <summary>
        /// This it the settings method of the shape class which be redefined in derived class
        /// as per the shapes specifications
        /// </summary>
        /// <param name="colour">Colour of the shape</param>
        /// <param name="list">List of parameter</param>
        public virtual void set(Color colour, params int[] list)
        {
            this.colour = colour;
            this.x = list[0];
            this.y = list[1];
        }
        /// <summary>
        /// To set whether the shape is to be drawn as texture or not
        /// </summary>
        /// <param name="text">True or false value</param>
        public void setTexture(bool text)
        {
            texture = text;
        }
    }
}


