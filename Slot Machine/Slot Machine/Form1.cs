using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double totalSpent = 0.00;
        double totalWon = 0.00;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int box1 = rand.Next(10);
            int box2 = rand.Next(10);
            int box3 = rand.Next(10);

            double tempSpent = Double.Parse(textBox1.Text);

            totalSpent = totalSpent + tempSpent; 

            pictureBox1.Image = imgList1.Images[box1];
            pictureBox2.Image = imgList1.Images[box2];
            pictureBox3.Image = imgList1.Images[box3];

            if ((box1 != box2) & (box2 != box3) & (box1 != box3))
            {
                MessageBox.Show("You won $ 0.00...");
            }
            if ((box1 == box2)&(box2 == box3))
            {
                totalWon = totalWon + (tempSpent * 3);
                MessageBox.Show("You won 3x! That's " + (tempSpent * 3).ToString("c") + " dollars!");
            }
            if (((box1 == box2) & (box2 != box3))| ((box2 == box3) & (box2 != box1)) | ((box1 == box3) & (box1 != box2)))
            {
                totalWon = totalWon + (tempSpent * 2);
                MessageBox.Show("You won 2x! That's " + (tempSpent * 2).ToString("c") + " dollars!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You won " + totalWon.ToString("c") + " dollars, and you spent " + totalSpent.ToString("c") + " dollars...");
            this.Close();
        }
    }
}
