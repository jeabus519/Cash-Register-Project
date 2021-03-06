﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

/* Michael Peterman
 * October 16, 2016
 * ICS3U Unit 2 Summative Project
 * Purpose: Create a cash register program for a fast food diner that will take a customer’s order,
 * process the cost, and calculate the change.  The user can then print a receipt for the customer.
 */

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

            //calculates tax, then rounds to the nearest hundredth
            tax = subtotal * taxRate;
            tax = Math.Round(tax, 2);

            //displays tax
            taxOutput.Text = tax.ToString();

            //calculates total
            total = subtotal + tax;

            //displays the total
            totalOutput.Text = total.ToString("0.00");
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //sets tendered to the correct value
            tendered = Convert.ToInt16(tenderedInput.Value);

            //calculates change
            change = tendered - total;

            //displays change
            changeOutput.Text = change.ToString("0.00");
        }

        private void recieptButton_Click(object sender, EventArgs e)
        {
            //sets up whats needed for graphics
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font consolasFont = new Font("Consolas", 12);
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            //draws the receipt
            formGraphics.FillRectangle(whiteBrush, 300, 150, 250, 450);

            formGraphics.DrawString("The Broken Drum", consolasFont, blackBrush, 350, 180);
            Thread.Sleep(500);
            formGraphics.DrawString("Tavern and Inn", consolasFont, blackBrush, 355, 200);
            Thread.Sleep(500);
            formGraphics.DrawString("12th of Deepsnow, 392", consolasFont, blackBrush, 325, 260);
            Thread.Sleep(500);

            formGraphics.DrawString("Mead", consolasFont, blackBrush, 325, 300);
            formGraphics.DrawString("x" + meadCount, consolasFont, blackBrush, 400, 300);
            formGraphics.DrawString(meadCost.ToString() + "  @", consolasFont, blackBrush, 530, 300, format);
            Thread.Sleep(500);
            formGraphics.DrawString("Mutton", consolasFont, blackBrush, 325, 320);
            formGraphics.DrawString("x" + muttonCount, consolasFont, blackBrush, 400, 320);
            formGraphics.DrawString(muttonCost.ToString() + " @", consolasFont, blackBrush, 530, 320, format);
            Thread.Sleep(500);
            formGraphics.DrawString("Meal", consolasFont, blackBrush, 325, 340);
            formGraphics.DrawString("x" + mealCount, consolasFont, blackBrush, 400, 340);
            formGraphics.DrawString(mealCost.ToString() + " @", consolasFont, blackBrush, 530, 340, format);
            Thread.Sleep(500);            

            formGraphics.DrawString("Subtotal", consolasFont, blackBrush, 325, 380);
            formGraphics.DrawString("$" + subtotal.ToString("0.00"), consolasFont, blackBrush, 530, 380, format);
            Thread.Sleep(500);

            formGraphics.DrawString("Kings Tax", consolasFont, blackBrush, 325, 400);
            formGraphics.DrawString("$" + tax.ToString("0.00"), consolasFont, blackBrush, 530, 400, format);
            Thread.Sleep(500);

            formGraphics.DrawString("Total", consolasFont, blackBrush, 325, 420);
            formGraphics.DrawString("$" + total.ToString("0.00"), consolasFont, blackBrush, 530, 420, format);
            Thread.Sleep(500);

            formGraphics.DrawString("Tendered", consolasFont, blackBrush, 325, 460);
            formGraphics.DrawString("$" + tendered.ToString("0.00"), consolasFont, blackBrush, 530, 460, format);
            Thread.Sleep(500);

            formGraphics.DrawString("Change", consolasFont, blackBrush, 325, 480);
            formGraphics.DrawString("$" + change.ToString("0.00"), consolasFont, blackBrush, 530, 480, format);
            Thread.Sleep(500);

            formGraphics.DrawString("Thank you! Come again!", consolasFont, blackBrush, 325, 530);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clears reciept
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.DimGray);

            //resets numericalupdown values
            meadInput.Value = 0;
            muttonInput.Value = 0;
            mealInput.Value = 0;
            tenderedInput.Value = 0;

            //resets output labels
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";
        }
    }
}
