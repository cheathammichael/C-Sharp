using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        double CONST_TAXT_RATE = 0.06;
        
        private double OilLubeCharges()
        {
            double output = 0;
            if (oilChangeChkBx.Checked)
                output = output + 26;
            if (lubeJbChkBx.Checked)
                output = output + 18;
            return output;                            
        }

        private double FlushCharges()
        {
            double output = 0;
            if (radFlshBx.Checked)
                output = output + 30;
            if (TransFlshBx.Checked)
                output = output + 80;
            return output;
        }

        private double MiscCharges()
        {
            double output = 0;
            if (inspecBx.Checked)
                output = output + 15;
            if (mufflerBox.Checked)
                output = output + 100;
            if (rotationBox.Checked)
                output = output + 20;
            return output;
        }

        private double OtherCharges()
        {
            double output = 0;
            partsLabel.Text = double.Parse(partsTxtBox.Text).ToString("c");
            output = double.Parse(laborTxtBox.Text);
            return output;
        }

        private double TaxCharges()
        {
            double output = double.Parse(partsTxtBox.Text) * CONST_TAXT_RATE;
            return output;
        }

        private double TotalCharges()
        {
            double output = OilLubeCharges() + FlushCharges() + MiscCharges() +
                OtherCharges() + TaxCharges();
            return output;                 
        }

        private void ClearOilLube()
        {
            oilChangeChkBx.Checked = false;
            lubeJbChkBx.Checked = false;
        }

        private void ClearFlushes()
        {
            radFlshBx.Checked = false;
            TransFlshBx.Checked = false;
        }

        private void ClearMisc()
        {
            inspecBx.Checked = false;
            mufflerBox.Checked = false;
            rotationBox.Checked = false;
        }

        private void ClearOther()
        {
            partsTxtBox.Text = "";
            laborTxtBox.Text = "";
        }

        private void ClearFees()
        {
            servLabLabel.Text = "";
            partsLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void oilChangeChkBx_CheckedChanged(object sender, EventArgs e)
        {
                
        }

        private void lubeJbChkBx_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radFlshBx_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TransFlshBx_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inspecBx_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mufflerBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rotationBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            servLabLabel.Text = (OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges()).ToString("c");
            taxLabel.Text = TaxCharges().ToString("c");
            totalLabel.Text = (double.Parse(servLabLabel.Text) + double.Parse(taxLabel.Text) + double.Parse(partsLabel.Text)).ToString("c");
        }

        private void partsTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFees();
            ClearFlushes();
            ClearMisc();
            ClearOilLube();
            ClearOther();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
