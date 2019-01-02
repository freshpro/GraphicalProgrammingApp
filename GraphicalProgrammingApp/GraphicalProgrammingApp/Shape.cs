using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingApp
{
        // This is abstract class for shape object 
        //  Common feature of shapes are represent by this class  
        // This class is extend by shape classes 

        public abstract class Shape:Shapes
        {
            
            // Color of the shape 
           
            protected Color colour; //shape's colour
                                    
                                   
                                    
            protected int x, y; // shapes position
                                


            
             //Constructor to do the default settings of shape objects
            // Colour to red
            // and position to 100,100
         

            public Shape()

            {
                colour = Color.Red;
                x = y = 100;
            }

        
            //"colour"Fill colour of the shape
            //"x"X cooridanate
            //"y"Y cooridanate
            public Shape(Color colour, int x, int y)
            {

                this.colour = colour; //shape's colour
                this.x = x; //its x pos
                this.y = y; //its y pos

            }


            
            // The methods below is from the Shapes interface
            // Will be defined in the concrete class that extends this abstract class
            
            //"g" Graphics Object
            public abstract void draw(Graphics g);
        
            // This it the settings method of the shape class which be redefined in derrived class
            // as per the shapes specifications
            //colour"Colour of the shape
            //"list" List of parameter
            public virtual void set(Color colour, params int[] list)
            {
                this.colour = colour;
                this.x = list[0];
                this.y = list[1];
            }





        }
    }

