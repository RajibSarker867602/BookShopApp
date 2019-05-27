using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopApp
{
    public partial class BookShopEntryForm : Form
    {
        public BookShopEntryForm()
        {
            InitializeComponent();
        }
        List<string> names = new List<string>();
        List<string> contacts = new List<string>();
        List<string> addresses = new List<string>();
        List<string> orders = new List<string>();
        List<int> quantites = new List<int>();
        List<decimal> totalPrices = new List<decimal>();


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                decimal price = 0;
                string message = "";
                names.Add(nameTextBox.Text);
                contacts.Add(contactNoTextBox.Text);
                addresses.Add(addressTextBox.Text);
                orders.Add(orderComboBox.Text);
                if (orderComboBox.Text == "Math")
                {
                    price = 120;
                }
                else if (orderComboBox.Text == "English")
                {
                    price = 100;
                }
                else if (orderComboBox.Text == "Bangla")
                {
                    price = 90;
                }
                else if (orderComboBox.Text == "Art")
                {
                    price = 80;
                }
                quantites.Add(Convert.ToInt32(quantityTextBox.Text));
                decimal subTotalPrice = quantites[index] * price;
                totalPrices.Add(subTotalPrice);
                foreach (decimal totalPrice in totalPrices)
                {
                    //if (name[index] != "" && name[index] != null)
                    message = message + "\t\tShow Customer " + (index + 1) + " Information" + Environment.NewLine + "\t=============================" + Environment.NewLine + Environment.NewLine + "Name : " + names[index] + Environment.NewLine + "Contact No : " + contacts[index] + Environment.NewLine + "Address : " + addresses[index] + Environment.NewLine + "Your ordered item : " + orders[index] + Environment.NewLine + "Quantity : " + quantites[index] + Environment.NewLine + "Your total price : " + totalPrice + Environment.NewLine + Environment.NewLine + "\t Thank you for stay with us...\n\n";
                    index++;
                }
                showRichTextBox.Text = message;

                nameTextBox.Text = "";
                contactNoTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.SelectedIndex = -1;
                quantityTextBox.Text = "";

            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
