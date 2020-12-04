using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drink_Vending_Machine
{
    public partial class Form1 : Form
    {
        struct Beverage
        {
            public string name;
            public double cost;
            public int inventory;
        }

        Beverage cola = new Beverage();
        Beverage rootBeer = new Beverage();
        Beverage lemonLime = new Beverage();
        Beverage grape = new Beverage();
        Beverage creamSoda = new Beverage();

        double totalSales = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        Beverage[] drinks = new Beverage[5];

        private void Form1_Load(object sender, EventArgs e)
        {   
            cola.name = "Cola";
            cola.cost = 1.00;
            cola.inventory = 20;

            rootBeer.name = "Root Beer";
            rootBeer.cost = 1.00;
            rootBeer.inventory = 20;

            lemonLime.name = "Lemon Lime";
            lemonLime.cost = 1.00;
            lemonLime.inventory = 20;

            grape.name = "Grape";
            grape.cost = 1.50;
            grape.inventory = 20;

            creamSoda.name = "Cream Soda";
            creamSoda.cost = 1.50;
            creamSoda.inventory = 20;

            drinks[0] = cola;
            drinks[1] = rootBeer;
            drinks[2] = lemonLime;
            drinks[3] = grape;
            drinks[4] = creamSoda;

            colaPrice.Text = drinks[0].name;
            rtbrPrice.Text = drinks[1].name;
            lemonPrice.Text = drinks[2].name;
            grapePrice.Text = drinks[3].name;
            crmPrice.Text = drinks[4].name;

            colaPrice.Text = drinks[0].cost.ToString("c");
            rtbrPrice.Text = drinks[1].cost.ToString("c");
            lemonPrice.Text = drinks[2].cost.ToString("c");
            grapePrice.Text = drinks[3].cost.ToString("c");
            crmPrice.Text = drinks[4].cost.ToString("c");

            colaInv.Text = drinks[0].inventory.ToString();
            rtbrInv.Text = drinks[1].inventory.ToString();
            lemonInv.Text = drinks[2].inventory.ToString();
            grapeInv.Text = drinks[3].inventory.ToString();
            crmInv.Text = drinks[4].inventory.ToString();
            
            totalLabel.Text = totalSales.ToString("c");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (drinks[0].inventory == 0)
            {
                MessageBox.Show("I'm sorry, " + drinks[0].name + " is sold out!");
            }
            else
            {
                drinks[0].inventory -= 1;
                colaInv.Text = drinks[0].inventory.ToString();
                totalSales = totalSales + drinks[0].cost;
                totalLabel.Text = totalSales.ToString("c");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (drinks[1].inventory == 0)
            {
                MessageBox.Show("I'm sorry, " + drinks[1].name + " is sold out!");
            }
            else
            {
                drinks[1].inventory -= 1;
                rtbrInv.Text = drinks[1].inventory.ToString();
                totalSales = totalSales + drinks[1].cost;
                totalLabel.Text = totalSales.ToString("c");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (drinks[2].inventory == 0)
            {
                MessageBox.Show("I'm sorry, " + drinks[2].name + " is sold out!");
            }
            else
            {
                drinks[2].inventory -= 1;
                lemonInv.Text = drinks[2].inventory.ToString();
                totalSales = totalSales + drinks[2].cost;
                totalLabel.Text = totalSales.ToString("c");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (drinks[3].inventory == 0)
            {
                MessageBox.Show("I'm sorry, " + drinks[3].name + " is sold out!");
            }
            else
            {
                drinks[3].inventory -= 1;
                grapeInv.Text = drinks[3].inventory.ToString();
                totalSales = totalSales + drinks[3].cost;
                totalLabel.Text = totalSales.ToString("c");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (drinks[4].inventory == 0)
            {
                MessageBox.Show("I'm sorry, " + drinks[4].name + " is sold out!");
            }
            else
            {
                drinks[4].inventory -= 1;
                crmInv.Text = drinks[4].inventory.ToString();
                totalSales = totalSales + drinks[4].cost;
                totalLabel.Text = totalSales.ToString("c");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
