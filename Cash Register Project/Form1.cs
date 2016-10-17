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
        const decimal meadCost = 4.99M;
        const decimal muttonCost = 10.00M;
        const decimal mealCost = 11.50M;

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

        }
    }
}
