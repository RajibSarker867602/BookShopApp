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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string contactNo = contactNoTextBox.Text;
                string address = addressTextBox.Text;
                string order = orderComboBox.Text;
                int quantity = Convert.ToInt32(quantityTextBox.Text);

                showRichTextBox.Text="\t\tShow Customer Information"+Environment.NewLine+"\t============================="+Environment.NewLine+Environment.NewLine+"Name : "+name+Environment.NewLine+"Contact No : "+contactNo+Environment.NewLine+"Address : "+address+Environment.NewLine+"Your ordered item : "+order+Environment.NewLine+"Quantity : "+quantity+Environment.NewLine+ Environment.NewLine + "\t Thank you for stay with us...";

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
