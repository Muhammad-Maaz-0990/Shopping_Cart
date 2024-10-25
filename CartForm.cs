using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class CartForm : Form
    {
        private List<Product> cart;
        private decimal discount = 0m;

        public CartForm(List<Product> cartItems)
        {
            InitializeComponent();
            cart = cartItems;
            UpdateCartDisplay();
        }

        // Display cart items in the list
        private void UpdateCartDisplay()
        {
            listBoxCart.Items.Clear();

            listBoxCart.Items.Add("ID\tName\t\t\t\tDescription\t\t\t\tQuantity\t\tPrice");
            listBoxCart.Items.Add("");
            foreach (var product in cart)
            {
                listBoxCart.Items.Add("\n\n" + product.ID + "\t" + product.Name + "\t\t\t" + product.Description + "\t\t\t  " + product.Quantity + "\t\t" + product.Price + "  Rupees");
            }
            
        }

        // Remove selected item from the cart
        private void btnRemoveItem_Click_1(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product to remove.");
                return;
            }

            var selectedProductName = listBoxCart.SelectedItem.ToString().Split('-')[0].Trim();
            var productToRemove = cart.FirstOrDefault(p => p.Name == selectedProductName);
            if (productToRemove != null)
            {
                cart.Remove(productToRemove);
                UpdateCartDisplay();
                MessageBox.Show("Product removed from the cart.");
            }
        }

        // Display total bill
        private void btnCheckTotal_Click_1(object sender, EventArgs e)
        {
            decimal total = cart.Sum(p => p.TotalPrice());
            total -= total * discount; // Apply discount if any

            string billDetails = "\t\tBill Details:\n\n\n";
            billDetails += "Name\t\t    Quantity\tPrice\tTotal Price\n\n\n";
            foreach (var product in cart)
            {
                billDetails += $"{product.Name}\t\t{product.Quantity}\t{product.Price}\t{product.TotalPrice()}\n\n";
            }
            billDetails += $"\n\n\t\tTotal Bill : ${total}";

            DashboardForm.cart_value = 0;

            MessageBox.Show(billDetails);
            listBoxCart.Items.Clear();
            cart.Clear();

            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Your logic here
        }



        // Apply coupon
        private void btnAddCoupon_Click(object sender, EventArgs e)
         {
             using (CouponFormcs couponForm = new CouponFormcs())
             {
                 if (couponForm.ShowDialog() == DialogResult.OK)
                 {
                     discount = 0.05m; // Apply 5% discount
                     MessageBox.Show("5% discount applied.");
                 }
             }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCoupon_MouseHover(object sender, EventArgs e)
        {
            btnAddCoupon.BackColor = Color.Brown;
        }

        private void btnRemoveItem_MouseHover(object sender, EventArgs e)
        {
            btnRemoveItem.BackColor = Color.Brown;
        }

        private void btnCheckTotal_MouseHover(object sender, EventArgs e)
        {
            btnCheckTotal.BackColor = Color.Brown;
        }

        private void Return_MouseHover(object sender, EventArgs e)
        {
            Return.BackColor = Color.Brown;
        }

        private void btnAddCoupon_MouseLeave(object sender, EventArgs e)
        {
            btnAddCoupon.BackColor = Color.DimGray;
        }

        private void btnRemoveItem_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveItem.BackColor = Color.DimGray;
        }

        private void btnCheckTotal_MouseLeave(object sender, EventArgs e)
        {
            btnCheckTotal.BackColor = Color.DimGray;
        }

        private void Return_MouseLeave(object sender, EventArgs e)
        {
            Return.BackColor = Color.DimGray;
        }
    }

    }
