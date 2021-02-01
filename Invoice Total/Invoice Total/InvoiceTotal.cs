using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Total
{
    public partial class Invoice_Total : Form
    {
        public Invoice_Total()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetSubTotalTextBox();
        }

        private void ResetSubTotalTextBox()
        {
            Sub_Total_TextBox.Focus();
            Sub_Total_TextBox.Text = "0";
            Sub_Total_TextBox.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTotal();

        }
       /// <summary>
       /// this method does has 
       /// no arguments
       /// </summary>

        private void CalculateTotal()
        {
            try
            {
                //read values 
                double SubTotal;
                double DiscountAmount;
                double Total;
                const double DiscountPercent = 0.1;
                //convert string to double
                SubTotal = Convert.ToDouble(Sub_Total_TextBox.Text);
                //DiscountAmount=Subtotal*0.1
                DiscountAmount = SubTotal * DiscountPercent;
                //Total= Subtotal-DiscountAmount
                Total = SubTotal - DiscountAmount;
                //Display DiscountAmount in proper Textbox
                DiscountAmount_TextBox.Text = DiscountAmount.ToString("C2");
                //display total in proper Textbox
                Total_TextBox.Text = Total.ToString("C2");
            }
            catch (Exception)
            {

                //throw;
                MessageBox.Show("Please Enter a number", "Input Error");
                ResetSubTotalTextBox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DiscountAmount_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
