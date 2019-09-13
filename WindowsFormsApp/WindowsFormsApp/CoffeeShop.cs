using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            string order = orderComboBox.Text;
            int Quantity = Convert.ToInt32( quantityTextBox.Text);
            int ContactNo = Convert.ToInt32(contactTextBox.Text);
            int Amount = 0;
            if (orderComboBox.Text == "Black-120") {
                Amount = 120;
            }

           else if(orderComboBox.Text=="Cold-100")
                {
                Amount = 100;
            }

            else if(orderComboBox.Text=="Hot-90")
            {
                Amount = 90;
            }
            else if(orderComboBox.Text== "Regular-80")

            {
                Amount = 80;
            }
            else
            {
                MessageBox.Show("Select an Item please");
            }

            int TotalPrice = Amount * Quantity;
            
            richTextBox.Text = "Customer name: " + nameTextBox.Text + "\n " +
                " " +"Contact Number: "+ contactTextBox.Text + "\n " +
                " " +"Address: "+ addressTextBox.Text + "\n " +
                "" +"Order Amount"+ orderComboBox.Text + "\n " +
                " "+"Quantity Number: "+ quantityTextBox.Text + "\n " +
                " " + "Total Price: "+ TotalPrice;
        }
    }
}
