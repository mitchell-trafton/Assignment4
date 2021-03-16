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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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
                            int[] values = new int[] { Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox2.Text)};
                            goDraw(equationBox.SelectedIndex, 0, values);
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
                            goDraw(equationBox.SelectedIndex, 0, values);
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
                            goDraw(equationBox.SelectedIndex, 0, values);
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
                string message = "please fill out all variables";
                string caption = "error";
                MessageBoxButtons mButtons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, mButtons);
            }
        }
        private void goDraw(int index, int lineNumber, int[] values)
        {
            //This loop sets the array of ints for the line into the dictionary for said line.
            int j = 0;
            foreach (int i in values)
            {
                Globals.line[(uint)lineNumber][j] = i;
                j++;
            }
            Globals.line[(uint)lineNumber][4] = index; // this is the index of the chosen function being set for the line.
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Globals.line[(uint)lineBox.SelectedIndex][0] = 0;
            Globals.line[(uint)lineBox.SelectedIndex][1] = 0;
            Globals.line[(uint)lineBox.SelectedIndex][2] = 0;
            Globals.line[(uint)lineBox.SelectedIndex][3] = 0;
            Globals.line[(uint)lineBox.SelectedIndex][4] = -1; // set line to no longer in use

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
    }
}
