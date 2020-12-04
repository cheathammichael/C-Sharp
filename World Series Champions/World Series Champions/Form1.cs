using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace World_Series_Champions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] winners1 = new String[108];
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inputFile;
            StreamReader inputFile1;

            inputFile = File.OpenText("Teams.txt");
            inputFile1 = File.OpenText("WorldSeriesWinners.txt");

            String[] winners = new String[108];
            for (int i = 0; i < winners.Length; i++)
            {
                winners[i] = inputFile1.ReadLine();
            };

            while (inputFile.EndOfStream == false)
            {
                listBox1.Items.Add(inputFile.ReadLine());
            }

            winners1 = winners;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < winners1.Length; i++)
            {
                String temp = listBox1.SelectedItem.ToString();
                if (winners1[i] == temp)
                {
                    count++;
                }
            }
            MessageBox.Show("They've won " + count + " times!");
        }
    }
}
