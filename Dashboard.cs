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

    public partial class DashboardForm : Form
    {
        private List<Product> recommendedProducts;
        private List<Product> actualProducts;
        private List<Product> cart = new List<Product>();
        private Timer cartExpiryTimer; // Timer for cart expiration

        public static int cart_value;


        public DashboardForm()
        {
            cart_value = 0;
            InitializeComponent();
            LoadProducts();
            homeToolStripMenuItem_Click(null, EventArgs.Empty);
            InitializeCartExpiryTimer();
        }

        private void InitializeCartExpiryTimer()
        {
            cartExpiryTimer = new Timer();
            cartExpiryTimer.Interval = 172800000; // For 48 hours
            cartExpiryTimer.Tick += CartExpiryTimer_Tick;
        }

        // Event handler for cart expiration
        private void CartExpiryTimer_Tick(object sender, EventArgs e)
        {
            cart.Clear(); // Clear the cart
            cartExpiryTimer.Stop(); // Stop the timer
            MessageBox.Show("Your cart is expired.");
        }


        // Initialize product lists
        private void LoadProducts()
        {
            // Recommended products
            recommendedProducts = new List<Product>
        {
              new Product { ID = 1, Name = "Blue T-Shirt", Description = "Casual Winter Blue Shirt ", Price = 1200 ,Quantity = 50},
            new Product { ID = 2, Name = "Dark green Polo", Description = "Lightening Small Keyboard", Price = 12320 ,Quantity = 10},
            new Product { ID = 3, Name = "Women's Dress", Description = "Elegant summer dress", Price = 2799 ,Quantity = 100},
            new Product { ID = 4, Name = "Jeans Pent", Description = "Stylish blue jeans pent", Price = 3699 ,Quantity = 3},
            new Product { ID = 5, Name = "Leather Jacket", Description = "Warm winter Blue jacket", Price = 15999 ,Quantity = 2},
            new Product { ID = 6, Name = "Women's Dress", Description = "Elegant summer Loan dress", Price = 2799 ,Quantity = 100}
        };

            // Actual products
            actualProducts = new List<Product>
        {
          

            new Product { ID = 1, Name = "PlayStation 5", Description = "Next-gen gaming console", Price = 120000 ,Quantity = 50},
            new Product { ID = 2, Name = "Xbox Series", Description = "Powerful gaming console", Price = 12320 ,Quantity = 10},
            new Product { ID = 3, Name = "Gaming Mouse", Description = "High precision gaming mouse", Price = 250 ,Quantity = 23},
            new Product { ID = 4, Name = "Gaming Headset", Description = "Surround sound headset", Price = 1500 ,Quantity = 20},
            new Product { ID = 5, Name = "Razer Keyboard", Description = "Mechanical gaming keyboard", Price = 1000 ,Quantity = 45},
            new Product { ID = 6, Name = "Men's T-Shirt", Description = "Casual cotton Men's t-shirt", Price = 2340 ,Quantity = 200},
            new Product { ID = 7, Name = "Women's Dress", Description = "Elegant summer dress Loan", Price = 2799 ,Quantity = 100},
            new Product { ID = 8, Name = "Blue Jeans", Description = "Stylish blue Narrow jeans", Price = 3699 ,Quantity = 3},
            new Product { ID = 9, Name = "Black Jacket", Description = "Warm winter black jacket", Price = 15999 ,Quantity = 2},
            new Product { ID = 10, Name = "White Sneakers", Description = "Comfortable running shoes", Price = 20000 ,Quantity = 5}
        };
        }

        // Display recommended products
        private void recomendedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            listBoxProducts.Items.Clear();

            listBoxProducts.Visible = true;
            txtQuantity.Visible = true;
            btnAddToCart.Visible = true;
            btnViewCart.Visible = true;
            label1.Visible = true;

            listBoxProducts.Items.Add("ID\tName\t\t\t\tDescription\t\t\t\tQuantity\t\tPrice" );
            listBoxProducts.Items.Add("");
            foreach (var product in recommendedProducts)
            {
                listBoxProducts.Items.Add("\n\n"+product.ID + "\t" + product.Name + "\t\t\t" + product.Description  + "\t\t\t  " + product.Quantity + "\t\t" + product.Price + "Rupees");
            }
        }

        // Display actual products
        private void actualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            listBoxProducts.Items.Clear();

            listBoxProducts.Visible = true;
            txtQuantity.Visible = true;
            btnAddToCart.Visible = true;
            btnViewCart.Visible = true;
            label1.Visible = true;

            listBoxProducts.Items.Add("ID\tName\t\t\t\tDescription\t\t\t\tQuantity\t\tPrice");
            listBoxProducts.Items.Add("");
            foreach (var product in actualProducts)
            {
                listBoxProducts.Items.Add("\n\n" + product.ID + "\t" + product.Name + "\t\t\t" + product.Description + "\t\t\t  " + product.Quantity + "\t\t" + product.Price + "  Rupees");
            }
        }


        private void ReloadListBox_recommend()
        {
            listBoxProducts.Items.Clear(); // Clear existing items
            listBoxProducts.Items.Add("ID\tName\t\t\t\tDescription\t\t\t\tQuantity\t\tPrice");
            listBoxProducts.Items.Add("");
            foreach (var product in actualProducts)
            {
                listBoxProducts.Items.Add("\n\n" + product.ID + "\t" + product.Name + "\t\t\t" + product.Description + "\t\t\t  " + product.Quantity + "\t\t" + product.Price + "  Rupees");
            }
        }


        private void ReloadListBox_actual()
        {
            listBoxProducts.Items.Clear(); // Clear existing items
            listBoxProducts.Items.Add("ID\tName\t\t\t\tDescription\t\t\t\tQuantity\t\tPrice");
            listBoxProducts.Items.Add("");
            foreach (var product in recommendedProducts)
            {
                listBoxProducts.Items.Add("\n\n" + product.ID + "\t" + product.Name + "\t\t\t" + product.Description + "\t\t\t  " + product.Quantity + "\t\t" + product.Price + "  Rupees");
            }
        }

        // Add product to cart
        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            int quantity;

            // Ensure valid quantity is entered
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Extract selected item name carefully
            string selectedProductText = listBoxProducts.SelectedItem.ToString();
            string selectedProductName = selectedProductText.Split('\t')[1].Trim(); // Adjust index as needed based on format

            // Check in both lists and determine the source list
            bool isRecommendedProduct = false;
            var selectedProduct = recommendedProducts.FirstOrDefault(p => p.Name.Equals(selectedProductName, StringComparison.OrdinalIgnoreCase));
            if (selectedProduct == null)
            {
                selectedProduct = actualProducts.FirstOrDefault(p => p.Name.Equals(selectedProductName, StringComparison.OrdinalIgnoreCase));
                isRecommendedProduct = selectedProduct != null;
            }

            if (selectedProduct != null)
            {
                // Check if entered quantity does not exceed available stock
                if (quantity > selectedProduct.Quantity)
                {
                    MessageBox.Show($"Only {selectedProduct.Quantity} units available. Please enter a smaller quantity.");
                    return;
                }

                // Check if product already exists in the cart
                var productInCart = cart.FirstOrDefault(p => p.Name == selectedProduct.Name);
                if (productInCart != null)
                {
                    // Increase quantity in the cart if the product already exists there
                    productInCart.Quantity += quantity;
                }
                else
                {
                    // Add new product to cart
                    cart.Add(new Product
                    {
                        ID = selectedProduct.ID,
                        Name = selectedProduct.Name,
                        Description = selectedProduct.Description,
                        Price = selectedProduct.Price,
                        Quantity = quantity
                    });
                }

                // Update the available quantity of the selected product
                selectedProduct.Quantity -= quantity;

                // Start the timer only when the first item is added to the cart
                if (cart.Count == 1)
                {
                    cartExpiryTimer.Start();
                }

                MessageBox.Show($"Product added to cart from {(isRecommendedProduct ? "recommended" : "actual")} products.");
                txtQuantity.Clear();
                cart_value = 1;
                // Reload the ListBox items
                if (isRecommendedProduct)
                {
                    ReloadListBox_recommend();
                }
                else
                {
                    ReloadListBox_actual();
                }
            }
            else
            {
                MessageBox.Show("Product not found. Please try again.");
            }
        }



        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            listBoxProducts.Visible = false;
            txtQuantity.Visible = false;
            btnAddToCart.Visible = false;
            btnViewCart.Visible = false;
            label1.Visible = false;
        }



        // View cart (open CartForm)
        private void btnViewCart_Click(object sender, EventArgs e)
        {
            if(cart_value==0)
            {
                MessageBox.Show("You Card is Empty");
            }
            else
            {
                this.Hide();
                txtQuantity.Clear();
                CartForm cartForm = new CartForm(cart);
                cartForm.ShowDialog();
                this.Show();
            }
            
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_MouseHover(object sender, EventArgs e)
        {
            btnAddToCart.BackColor = Color.DimGray;
        }

        private void btnAddToCart_MouseLeave(object sender, EventArgs e)
        {
            btnAddToCart.BackColor = Color.Brown;
        }

        private void btnViewCart_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnViewCart_MouseHover(object sender, EventArgs e)
        {
            btnViewCart.BackColor = Color.DimGray;
        }

        private void btnViewCart_MouseLeave(object sender, EventArgs e)
        {
            btnViewCart.BackColor = Color.Brown;
        }

        private void lblLogOut_MouseHover(object sender, EventArgs e)
        {
            lblLogOut.BackColor = Color.ForestGreen;
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLogOut_MouseLeave(object sender, EventArgs e)
        {
            lblLogOut.BackColor = Color.DarkOliveGreen;
        }
    }


    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice()
        {
            return Price * Quantity;
        }
    }

}
