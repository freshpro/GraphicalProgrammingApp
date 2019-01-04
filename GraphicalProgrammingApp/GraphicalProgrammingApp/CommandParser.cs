using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingApp
{
    class CommandParser
    {
        public static ArrayList shapes = new ArrayList();
        static ShapeFactory factory = new ShapeFactory();
        static int cradius, cheight, cwidth;
        static int clp;

        //  This method validates the allowded command keyword
        // returns True if value is valid else false
        static public bool ValidateCommand(String cmdString)
        {
            char[] sep = { ' ', '\t', ',' };
            String[] cmds = cmdString.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            bool valid = true;
            foreach (String cmdValue in cmds)
            {
                String cmd = cmdValue.Trim().ToUpper();

                int no;
                bool isNumeric = int.TryParse(cmd, out no);
                if (!isNumeric)
                {
                    if (!(cmd[0] == '+' || cmd[0] == '-' || cmd[0] == '='))
                    {
                        valid = false;
                        break;
                    }

                }
            }
            return valid;
        }// end of validate

        //  This method processes the command alongside syntax validation
        //  "commandSource" The whole list of commands

        static public void processCommands(String commandSource)
        {

            char[] sep = { ' ', '\t', ',' };
            //  Console.WriteLine("Commands Lines \n: ");
            char[] newl = { '\n' };
            String[] cmdLines = commandSource.Split(newl, StringSplitOptions.RemoveEmptyEntries);
            //   Console.WriteLine("Line Count:  " + cmdLines.Length);
            int c = 0;
            int x = 10, y = 10;

            //loop related variables
            bool loop = false;
            String loopscommand = "";
            int counter = 0;
            foreach (String cmdLine in cmdLines)
            {
                String cmdL = cmdLine.Trim();
                Console.WriteLine(c + ": Line:  " + cmdLine + "x");
                c++;
                //      Console.WriteLine(c + ": Line:  " + cmdLine);
                String[] cmds = cmdL.Split(sep, StringSplitOptions.RemoveEmptyEntries);




            }
        }
    }
}