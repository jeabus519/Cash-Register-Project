using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register_Project
{
    public partial class Form1 : Form
    {
        //declares variables
        const decimal meadCost = 4.99M;
        const decimal muttonCost = 10.00M;
        const decimal mealCost = 11.50M;
        const decimal taxRate = 0.13M;

        int meadCount;
        int muttonCount;
        int mealCount;

        decimal subtotal;
        decimal tax;
        decimal total;
        decimal tendered;
        decimal change;

        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //sets variables to respective values 
            meadCount = Convert.ToInt16(meadInput.Value);
            muttonCount = Convert.ToInt16(muttonInput.Value);
            mealCount = Convert.ToInt16(mealInput.Value);

            //calculates the subtotal
            subtotal = meadCount * meadCost + muttonCount * muttonCost + mealCount * mealCost;

            //displays subtotal
            subtotalOutput.Text = subtotal.ToString("0.00");

            //calculates tax
            tax = subtotal * taxRate;

            //displays tax
            taxOutput.Text = tax.ToString("0.00");

            //calculates total
            total = subtotal + tax;

            //displays the total
            totalOutput.Text = total.ToString("0.00");
        }
    }
}
