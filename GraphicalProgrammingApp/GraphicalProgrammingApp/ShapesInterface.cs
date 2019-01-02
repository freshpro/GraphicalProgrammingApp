using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingApp
{
 
        ///  This interface is for shape objects 
        ///  Different types will have the methods set  
        ///  and draw 
        interface Shapes
        {
            void set(Color c, params int[] list);

            void draw(Graphics g);
        }
    }
}
