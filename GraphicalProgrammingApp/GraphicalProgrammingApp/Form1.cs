using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgrammingApp
{
    // Form is used as a canvas on which shape objects are drawn
    
    public partial class Form1 : Form
    {
        ArrayList shapes = new ArrayList();

        
        // Form constructor that take shape's list as parameter
        //"shapes" List of shapes to be drawn
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(ArrayList shapes)
        {


            InitializeComponent();
            this.shapes = shapes;
            Console.WriteLine("Shapes: " + shapes.Count);
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            String commands = textBox1.Text;

            String[] cmds = commands.Split(
                         new[] { Environment.NewLine },
                         StringSplitOptions.None
                     );


            try
            {

                String validCommands = "";
                bool isValid = false;
                //to keep accepting the input until run command
                foreach (String cmdLine in cmds)
                {
                    Console.WriteLine(cmdLine);
                    isValid = CommandParser.ValidateCommand(cmdLine.ToUpper().Trim());
                    if (isValid == false)
                    {
                        Console.WriteLine("Validation failed");
                    }
                    else
                    {
                        validCommands = validCommands + cmdLine.ToUpper().Trim() + " \n";
                    }

                }

                CommandParser.processCommands(validCommands);

                shapes = CommandParser.shapes;


                this.Refresh();

            }
            catch (ExceptionHandle eh)
            {
                Console.WriteLine(eh.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("paint called");
            Graphics g = e.Graphics;
            for (int i = 0; i < shapes.Count; i++)
            {
                Shape s;
                s = (Shape)shapes[i];
                if (s != null)
                {
                    s.draw(g);
                    Console.WriteLine(s.ToString());
                }
                else
                    Console.WriteLine("invalid shape in array"); //shouldn't happen as factory does not produce rubbish




            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

