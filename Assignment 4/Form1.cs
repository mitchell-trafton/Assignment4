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
            Graphics g = e.Graphics;


            //draw the grid lines for the graph
            using (Pen p = new Pen(Color.Black, 2))//draw black lines representing x = 0 and y = 0
            {
                g.DrawLine(p, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);//x = 0
                g.DrawLine(p, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);//y = 0

                g.DrawString("10", new Font("Arial", 10), new SolidBrush(Color.Black), pictureBox1.Width / 2 + 2, 5);
                g.DrawString("10", new Font("Arial", 10), new SolidBrush(Color.Black), pictureBox1.Width - 17, pictureBox1.Height / 2);
            }

            using (Pen p = new Pen(Color.Gray))//draw 9 transparent white lines on each side of the x = 0 and y = 0 lines
            {
                for (int i = 0; i <= 20; i++)
                {
                    g.DrawLine(p, 0 + (pictureBox1.Width / 20 * i), 0, 0 + (pictureBox1.Width / 20 * i), pictureBox1.Height); // x lines
                    g.DrawLine(p, 0, 0 + (pictureBox1.Height / 20 * i), pictureBox1.Width, 0 + (pictureBox1.Height / 20 * i)); // y lines
                }
            }

            Pen[] penColors = { new Pen(Color.Black), new Pen(Color.Red), new Pen(Color.Green), new Pen(Color.Blue) };
            float xUnitSize = pictureBox1.Width / 2 / 10;//the size of one unit on the graph's x axis
            float yUnitSize = pictureBox1.Height / 2 / 10;//the size of one unit on the graph's y axis

            g.DrawCurve(new Pen(Color.Purple), new Point[]
            {
                new Point((int)((pictureBox1.Width / 2) - 4*xUnitSize), (int)((pictureBox1.Height / 2) + 64*yUnitSize)),
                new Point((int)((pictureBox1.Width / 2) - 3*xUnitSize), (int)((pictureBox1.Height / 2) + 27*yUnitSize)),
                new Point((int)((pictureBox1.Width / 2) - 2*xUnitSize), (int)((pictureBox1.Height / 2) + 8*yUnitSize)),
                new Point((int)((pictureBox1.Width / 2) - xUnitSize), (int)((pictureBox1.Height / 2) + yUnitSize)),
                new Point((int)(pictureBox1.Width / 2), (int)(pictureBox1.Height / 2)),
                new Point((int)((pictureBox1.Width / 2) + xUnitSize), (int)((pictureBox1.Height / 2) - yUnitSize)),
                new Point((int)((pictureBox1.Width / 2) + 2*xUnitSize), (int)((pictureBox1.Height / 2) - 8*yUnitSize)),
                new Point((int)((pictureBox1.Width / 2) + 3*xUnitSize), (int)((pictureBox1.Height / 2) - 27*yUnitSize)),
                new Point((int)((pictureBox1.Width / 2) + 4*xUnitSize), (int)((pictureBox1.Height / 2) - 64*yUnitSize))
            });

            foreach (KeyValuePair<uint, List<int>> lines in Globals.line)
            {
                if (lines.Value[lines.Value.Count-1] == 0) // y = mx + b (line)
                {
                    float y_start = (pictureBox1.Height / 2) + yUnitSize * (lines.Value[0] * 10 - lines.Value[1]);
                    float y_end = (pictureBox1.Height / 2) + yUnitSize * (lines.Value[0] * -10 - lines.Value[1]);

                    g.DrawLine(penColors[lines.Key], 0, y_start, pictureBox1.Width, y_end);
                }

                else if (lines.Value[lines.Value.Count-1] == 1) // y = ax^2 + bx + c (quadratic)
                {
                    Point[] points = quadraticPoints(-10, 10, lines.Value[0], lines.Value[1], lines.Value[2], xUnitSize, yUnitSize);

                    if (points != null) g.DrawCurve(penColors[lines.Key], points);
                }

                else if (lines.Value[lines.Value.Count-1] == 2) // y = ax^3 + bx^2 + cx + d (cubic)
                {
                    Point[] points = cubicPoints(-10, 10, lines.Value[0], lines.Value[1], lines.Value[2], lines.Value[3], xUnitSize, yUnitSize);

                    if (points != null) g.DrawCurve(penColors[lines.Key], points);
                }

                else if (lines.Value[lines.Value.Count-1] == 3) // (x-h)^2 + (y-k)^2 = r^2 (circle)
                {
                    float x_coord = (pictureBox1.Width / 2) + lines.Value[0] * xUnitSize - lines.Value[2] * xUnitSize;
                    float y_coord = (pictureBox1.Height / 2) - lines.Value[1] * yUnitSize - lines.Value[2] * yUnitSize;
                    float diameter = 2 * lines.Value[2];

                    g.DrawEllipse(penColors[lines.Key], x_coord, y_coord, diameter * xUnitSize, diameter * yUnitSize);
                }
            }
        }

        private Point[] quadraticPoints(int xMin, int xMax, int a, int b, int c, float xUnitSize, float yUnitSize)
        {
            if (xMin >= xMax) return null;//return null if xMax is not greater than xMin

            List<Point> points = new List<Point>();//list of generated points; will be returned as an array

            for (int x = xMin; x <= xMax; x++) 
            {
                int result = a * x * x + b * x + c;
                points.Add(new Point((int)((pictureBox1.Width / 2) + x * xUnitSize), (int)((pictureBox1.Height / 2) - result * yUnitSize)));
            }

            return points.ToArray();
        }

        private Point[] cubicPoints(int xMin, int xMax, int a, int b, int c, int d, float xUnitSize, float yUnitSize)
        {
            if (xMin >= xMax) return null;//return null if xMax is not greater than xMin

            List<Point> points = new List<Point>();//list of generated points; will be returned as an array

            for (int x = xMin; x <= xMax; x++)
            {
                int result = a * x * x * x + b * x * x + c * x + d;
                points.Add(new Point((int)((pictureBox1.Width / 2) + x * xUnitSize), (int)((pictureBox1.Height / 2) - result * yUnitSize)));
            }

            return points.ToArray();
        }
    }
}
