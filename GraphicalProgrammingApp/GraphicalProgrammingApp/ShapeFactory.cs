using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingApp
{
    class ShapeFactory
    {
     
        // This method creates and return the shape of particluar class Example 
        // "shapeType" Name of the shape exampe cricle, rectangle 
        // Return the object of particualar shape class
        public Shape getShape(String shapeType)
        {
            shapeType = shapeType.ToUpper().Trim();


            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else
            {
                //in case of undefined shape object
                System.ArgumentException argEx = new System.ArgumentException ("Factory error: " + shapeType + " does not exist");
                throw argEx; 
            }
        }
    }
}
