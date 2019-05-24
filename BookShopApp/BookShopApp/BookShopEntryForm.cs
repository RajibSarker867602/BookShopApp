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
        const int size = 100;
        int index = 0;
        string[] name = new string[size];
        string[] contactNo = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];
        int[] quantity = new int[size];
        decimal[] totalPrice = new decimal[size];


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal price = 0;
                string message = "";
                name[index] = nameTextBox.Text;
                contactNo[index] = contactNoTextBox.Text;
                address[index] = addressTextBox.Text;
                order[index] = orderComboBox.Text;
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
                quantity[index] = Convert.ToInt32(quantityTextBox.Text);
                decimal subTotalPrice = quantity[index] * price;
                totalPrice[index] = subTotalPrice;
                for (int index = 0; index < size; index++)
                {
                    if (name[index] != "" && name[index] != null)
                        message = message + "\t\tShow Customer " + (index + 1) + " Information" + Environment.NewLine + "\t=============================" + Environment.NewLine + Environment.NewLine + "Name : " + name[index] + Environment.NewLine + "Contact No : " + contactNo[index] + Environment.NewLine + "Address : " + address[index] + Environment.NewLine + "Your ordered item : " + order[index] + Environment.NewLine + "Quantity : " + quantity[index] + Environment.NewLine + "Your total price : " + totalPrice[index] + Environment.NewLine + Environment.NewLine + "\t Thank you for stay with us...\n\n";
                }
                showRichTextBox.Text = message;
                index++;
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
