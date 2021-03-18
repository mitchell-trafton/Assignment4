using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        int xmin = -10;//minimum x value for graph
        int xmax = 10;//maximum x value for graph
        int xintvl = 1;//interval for x-axis tick marks
        int ymin = -10;//minimum y value for graph
        int ymax = 10;//maximum y value for graph
        int yintvl = 1;//interval for y-axis tick marks


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            int index = box.SelectedIndex;
            switch (index)
            {
                case 0: //Y=MX+B
                    label1.Text = "M=";
                    label2.Text = "B=";
                    label3.Text = "";
                    label4.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    break;
                case 1: // AX2+BX+C
                    label1.Text = "A=";
                    label2.Text = "B=";
                    label3.Text = "C=";
                    label4.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = false;
                    break;
                case 2: //AX3+BX2+CX+D
                    label1.Text = "A=";
                    label2.Text = "B=";
                    label3.Text = "C=";
                    label4.Text = "D=";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    break;
                case 3: //R2 = (x-H)2 + (Y-K)2
                    label1.Text = "H=";
                    label2.Text = "K=";
                    label3.Text = "R=";
                    label4.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = false;
                    break;
                default: //default and unselected
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e) //calculate button
        {
            try
            {
                if (lineBox.SelectedIndex == -1) throw new InvalidOperationException();

                switch(equationBox.SelectedIndex)
                {
                    case 0:
                        if(textBox1.TextLength != 0 && textBox2.TextLength != 0)
                        {
                            int[] values = new int[] {Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)};
                            goDraw(equationBox.SelectedIndex, lineBox.SelectedIndex, values);
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }
                        break;
                    case 1:
                        if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && textBox3.TextLength !=0)
                        {
                            int[] values = new int[] { Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text)};
                            goDraw(equationBox.SelectedIndex, lineBox.SelectedIndex, values);
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }
                        break;
                    case 2:
                        if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && textBox3.TextLength !=0 && textBox4.TextLength !=0)
                        {
                            int[] values = new int[] { Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text)};
                            goDraw(equationBox.SelectedIndex, lineBox.SelectedIndex, values);
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }
                        break;
                    case 3:
                        if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && textBox3.TextLength != 0)
                        {
                            int[] values = new int[] { Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text) };
                            goDraw(equationBox.SelectedIndex, lineBox.SelectedIndex, values);
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }
                        break;
                }
            }
            catch(InvalidOperationException e2)
            {
                string message = "please fill out all fields";
                string caption = "error";
                MessageBoxButtons mButtons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, mButtons);
            }
        }
        private void goDraw(int index, int lineNumber, int[] values)
        {
            Globals.line[(uint)lineNumber] = new List<int>();
            //This loop sets the array of ints for the line into the dictionary for said line.
            foreach (int i in values)
            {
                Globals.line[(uint)lineNumber].Add(i);
            }
            Globals.line[(uint)lineNumber].Add(index); // this is the index of the chosen function being set for the line.

            pictureBox1.Refresh();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (lineBox.SelectedIndex > -1) Globals.line[(uint)lineBox.SelectedIndex] = null;
            pictureBox1.Refresh();
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            bool minOverMax = false;//true when the min value entered is greater than the max

            try
            {
                if (Int32.Parse(xmin_txt.Text) >= Int32.Parse(xmax_txt.Text) || Int32.Parse(ymin_txt.Text) >= Int32.Parse(ymax_txt.Text))
                {
                    minOverMax = true;
                    throw new Exception();
                }

                xmin = Int32.Parse(xmin_txt.Text);
                xmax = Int32.Parse(xmax_txt.Text);
                xintvl = Int32.Parse(xintvl_txt.Text);
                ymin = Int32.Parse(ymin_txt.Text);
                ymax = Int32.Parse(ymax_txt.Text);
                yintvl = Int32.Parse(yintvl_txt.Text);
            }
            catch(Exception ee)
            {
                if (!minOverMax) MessageBox.Show("Please fill in all fields with numbers.", "Error");
                else MessageBox.Show("Pleas make sure that no minimum value is greater than or equal to its corresponding maximum value.", "Error");
                return;
            }

            pictureBox1.Refresh();
        }

        /**********************************************************************************
         * lineBox_SelectedIndexChanged
         * Purpose: When called, this method updates the textboxes to hold the values
         * currently stored in the line, according to what, if any, mathmatical function
         * it's holding.
         * 
         **********************************************************************************/
        private void lineBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(new[] { 0, 1, 2, 3 }.Contains(Globals.line[(uint)lineBox.SelectedIndex][4]))
            textBox1.Text =  Globals.line[(uint)lineBox.SelectedIndex][0].ToString();
            if (new[] { 0, 1, 2, 3 }.Contains(Globals.line[(uint)lineBox.SelectedIndex][4]))
                textBox1.Text = Globals.line[(uint)lineBox.SelectedIndex][1].ToString();
            if (new[] { 1, 2, 3 }.Contains(Globals.line[(uint)lineBox.SelectedIndex][4]))
                textBox1.Text = Globals.line[(uint)lineBox.SelectedIndex][2].ToString();
            if (new[] { 2 }.Contains(Globals.line[(uint)lineBox.SelectedIndex][4]))
                textBox1.Text = Globals.line[(uint)lineBox.SelectedIndex][3].ToString();
            //set or reset the chosen equation
            if (Globals.line[(uint)lineBox.SelectedIndex][4] != -1)
                equationBox.SelectedIndex = Globals.line[(uint)lineBox.SelectedIndex][4];
            else
                equationBox.SelectedIndex = 0;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            /***********************************************************************
             * Paint handler for pictureBox1.
             * 
             * Will create a graph according to the xmin, xmax, xintvl, ymin, ymax, 
             * and yintvl specifications. Also plots any equations stored in the global
             * line dictionary according in their designated colors.
             ***********************************************************************/

            Graphics g = e.Graphics;

            this.DoubleBuffered = true;

            //reset graph size to default
            pictureBox1.Height = 400;
            pictureBox1.Width = 400;

            float xUnitSize = pictureBox1.Width / System.Math.Abs((xmax - xmin) / xintvl);//the size of one unit on the graph's x axis
            float yUnitSize = pictureBox1.Height / System.Math.Abs((ymax - ymin) / yintvl);//the size of one unit on the graph's y axis

            int xintvlNum = System.Math.Abs((xmax - xmin) / xintvl);//number of x interval marks on the graph
            int yintvlNum = System.Math.Abs((ymax - ymin) / yintvl);//number of y interval marks on the graph

            Console.WriteLine(pictureBox1.Height);
            Console.WriteLine(pictureBox1.Height * ((float)(0 - ymin) / (ymax-ymin)));

            using (Pen p = new Pen(Color.Gray))//draw interval lines
            {
                for (int i = 0; i <= xintvlNum; i++)
                {
                    g.DrawLine(p, 0 + (xUnitSize * i), 0, 0 + (xUnitSize * i), pictureBox1.Height + 20); // x lines
                    pictureBox1.Width = (int)(xUnitSize * ((float)(xmax - xmin)/xintvl));//readjust graph size to fit interval lines
                }
                for (int i = 0; i <= yintvlNum; i++)
                {
                    g.DrawLine(p, 0, 0 + (yUnitSize * i), pictureBox1.Width + 20, 0 + (yUnitSize * i)); // y lines
                    pictureBox1.Height = (int)(yUnitSize * ((float)(ymax - ymin) / yintvl));//readjust graph size to fit interval lines
                }                   
            }
            //draw solid black lines at x = 0 and y = 0 if they appear within the graph's limits
            using (Pen p = new Pen(Color.Black, 2))
            {
                if (xmin <= 0 && xmax >= 0)//x = 0
                    g.DrawLine(p, pictureBox1.Width * ((float)(0 - xmin) / (xmax - xmin)), 0, pictureBox1.Width * ((float)(0 - xmin) / (xmax - xmin)), pictureBox1.Height);

                if (ymin <= 0 && ymax >= 0)//y = 0
                    g.DrawLine(p, 0, pictureBox1.Height - (pictureBox1.Height * ((float)(0 - ymin) / (ymax - ymin))),
                               pictureBox1.Width, pictureBox1.Height - (pictureBox1.Height * ((float)(0 - ymin) / (ymax - ymin))));
            }

            //draw numbers at the ends of each axis to display the limits
            g.DrawString(ymax.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), pictureBox1.Width / 2 + 2, 0);//y-max
            g.DrawString(ymin.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), pictureBox1.Width / 2 + 2, pictureBox1.Height - 15);//y-min
            g.DrawString(xmax.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), pictureBox1.Width - 17, pictureBox1.Height / 2);//x-max
            g.DrawString(xmin.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 0, pictureBox1.Height / 2);//x-min

            Pen[] penColors = { new Pen(Color.Black), new Pen(Color.Red), new Pen(Color.Green), new Pen(Color.Blue) };//different pen colors corresponding with each index in the item dictionary
            

            //draw each equation that is stored in the global line dictionary
            foreach (KeyValuePair<uint, List<int>> lines in Globals.line)//only existing entries in the dictionary that are not null will be drawn
            {
                if (lines.Value == null) continue;//don't do anything if there is no list for a line

                //the equation to be drawn is specified by the last entry in each list
                if (lines.Value[lines.Value.Count-1] == 0) // y = mx + b (line)
                {
                    float x_start = coordConversion(xmin, xUnitSize, 'x');
                    float y_start = coordConversion(lines.Value[0] * xmin + lines.Value[1], yUnitSize, 'y');
                    float x_end = coordConversion(xmax, xUnitSize, 'x');
                    float y_end = coordConversion(lines.Value[0] * xmax + lines.Value[1], yUnitSize, 'y');

                    g.DrawLine(penColors[lines.Key], x_start, y_start, x_end, y_end);
                }

                else if (lines.Value[lines.Value.Count-1] == 1) // y = ax^2 + bx + c (quadratic)
                {
                    Point[] points = quadraticPoints(xmin, xmax, lines.Value[0], lines.Value[1], lines.Value[2], xUnitSize, yUnitSize);

                    if (points != null) g.DrawCurve(penColors[lines.Key], points);
                }

                else if (lines.Value[lines.Value.Count-1] == 2) // y = ax^3 + bx^2 + cx + d (cubic)
                {
                    Point[] points = cubicPoints(xmin, xmax, lines.Value[0], lines.Value[1], lines.Value[2], lines.Value[3], xUnitSize, yUnitSize);

                    if (points != null) g.DrawCurve(penColors[lines.Key], points);
                }

                else if (lines.Value[lines.Value.Count-1] == 3) // (x-h)^2 + (y-k)^2 = r^2 (circle)
                {
                    float x_coord = coordConversion(lines.Value[0] - lines.Value[2], xUnitSize, 'x');
                    float y_coord = coordConversion(lines.Value[1] + lines.Value[2], yUnitSize, 'y');
                    float x_diameter = 2 * lines.Value[2] / xintvl * xUnitSize;
                    float y_diameter = 2 * lines.Value[2] / yintvl * yUnitSize;

                    g.DrawEllipse(penColors[lines.Key], x_coord, y_coord, x_diameter, y_diameter);
                }
            }
        }

        private Point[] quadraticPoints(int xMin, int xMax, int a, int b, int c, float xUnitSize, float yUnitSize)
        {
            /*******************************************************************
             * Takes in a minimum and maximum x value, as well as
             * the a, b, and c values for a quadratic equation, and 
             * returns an array of points within the graph in pictureBox1
             * that create the equation in graph form.
             * 
             * Parameters:
             * @xMin      = Minimum x value.
             * @xMax      = Maximum x value.
             * @a         = 'a' value for quadratic equation.
             * @b         = 'b' value for quadratic equation.
             * @c         = 'c' value for quadratic equation.
             * @xUnitSize = Size of a single x interval (see class's xintvl value)
             *              within the graph in pictureBox1.
             * @yUnitSize = Size of a single y interval (see class's xintvl value)
             *              within the graph in pictureBox1.
             *              
             *              
             * @return: List of points that will plot out a quadratic equation
             *          within the graph in pictureBox1.
             *****************************************************************/

            if (xMin >= xMax) return null;//return null if xMax is not greater than xMin

            List<Point> points = new List<Point>();//list of generated points; will be returned as an array

            //a point will be calculated for each integer between xMin and xMax
            for (int x = xMin; x <= xMax; x++) 
            {
                int result = a * x * x + b * x + c;
                points.Add(new Point(coordConversion(x, xUnitSize, 'x'), coordConversion(result, yUnitSize, 'y')));
            }

            return points.ToArray();
        }

        private Point[] cubicPoints(int xMin, int xMax, int a, int b, int c, int d, float xUnitSize, float yUnitSize)
        {
            /*******************************************************************
             * Takes in a minimum and maximum x value, as well as
             * the a, b, c, and d values for a cubic equation, and 
             * returns an array of points within the graph in pictureBox1
             * that create the equation in graph form.
             * 
             * Parameters:
             * @xMin      = Minimum x value.
             * @xMax      = Maximum x value.
             * @a         = 'a' value for cubic equation.
             * @b         = 'b' value for cubic equation.
             * @c         = 'c' value for cubic equation.
             * @d         = 'd' value for cubic equation.
             * @xUnitSize = Size of a single x interval (see class's xintvl value)
             *              within the graph in pictureBox1.
             * @yUnitSize = Size of a single y interval (see class's yintvl value)
             *              within the graph in pictureBox1.
             *              
             *              
             * @return: List of points that will plot out a cubic equation
             *          within the graph in pictureBox1.
             *****************************************************************/

            if (xMin >= xMax) return null;//return null if xMax is not greater than xMin

            List<Point> points = new List<Point>();//list of generated points; will be returned as an array

            for (int x = xMin; x <= xMax; x++)
            {
                int result = a * x * x * x + b * x * x + c * x + d;
                points.Add(new Point(coordConversion(x, xUnitSize, 'x'), coordConversion(result, yUnitSize, 'y')));
            }

            return points.ToArray();
        }

        private int coordConversion(float coord, float unitSize, char axis = 'x')
        {
            /***************************************************
             * Converts a coordinate value to one that can be
             * plotted in the graph in pictureBox1.
             * 
             * Parameters:
             * @coord    = x/y coordinate to be converted.
             * @unitSize = Size of one interval on the coordinate's
             *             axis. (see class's xintvl/yintvl value)
             * @axis     = 'x' if the coordinate is an x coordinate.
             *             'y' if the coordinate is a y coordinate.
             *             
             * 
             * @return: The coordinate in a form that can be plotted
             *          in pictureBox1's graph.
             ***************************************************/

            float coordConv = 0;//converted coordinate; will be returned as an int

            if (axis == 'x')
            {
                coordConv = coord - xmin;
                coordConv /= xintvl;
                coordConv *= unitSize;
            }
            else if (axis == 'y')
            {
                coordConv = ymax - coord;
                coordConv /= yintvl;
                coordConv *= unitSize;
            }

            return (int)coordConv;
        }
    }
}
