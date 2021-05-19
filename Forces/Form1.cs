using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // read force and angle from text boxes
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox2.Text);

                double Fx = Force * cos(Angle);
                double Fy = Force * sin(Angle);

                label1.Text = "Fx = " + Fx;
                label2.Text = "Fy = " + Fy;
            }
            catch
            {
                // show error message if fails
                MessageBox.Show("D'oh!");
            }
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // remembers what the labels 
                double CuboidL = double.Parse(textBox5.Text);
                double CuboidH = double.Parse(textBox3.Text);
                double CuboidW = double.Parse(textBox4.Text);
                // works out the labels
                double CuboidSA = (2 * CuboidL * CuboidW) + (2 * CuboidL * CuboidH) + (2 * CuboidW * CuboidH);
                double CuboidVol = (CuboidW * CuboidL * CuboidH);
                //posts the labels
                label13.Text = "Surface Area =" + CuboidSA;
                label14.Text =  " Volume =" + CuboidVol;
            }

            catch

            {
                MessageBox.Show("EH EH! Try again *****!");
            }


        } 
        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }
    }
}