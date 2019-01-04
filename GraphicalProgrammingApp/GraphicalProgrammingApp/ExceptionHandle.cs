using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingApp
{
   
        /// This is user defined exception class used to throw user defined exceptions

        class ExceptionHandle : Exception
        {
            String message;
            public ExceptionHandle(string message)
            {
                this.message = message;
            }
            override
            public string ToString()
            {
                return "Error:\n" + message;
            }

        }

    }


