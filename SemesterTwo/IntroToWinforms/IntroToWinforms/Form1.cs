using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroToWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += (o, e) => ChangeColor(Color.LightBlue);
            button1.MouseLeave += (o, e) => ChangeColor(Color.Pink);
            
        }

        public void ChangeColor(Color c)
        {
            button1.BackColor = c;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && dateTimePicker1.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }
            else
            {
                Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Random rand = new Random();

                for (int x = 0; x <pictureBox1.Width; x++)
                {
                    for (int y = 0; y < pictureBox1.Height; y++)
                    {
                        b.SetPixel(x, y, rand.Next(0, 2) == 0 ? Color.Cyan : Color.LightSeaGreen);
                    }
                }
                pictureBox1.Image = b;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Quit Program")
            {
                Environment.Exit(0);
            }
        }
    }
}
