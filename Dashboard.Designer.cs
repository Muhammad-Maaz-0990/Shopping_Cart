namespace Shopping_Cart
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recomendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(12, 102);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(764, 225);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Brown;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.recomendedToolStripMenuItem,
            this.actualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // recomendedToolStripMenuItem
            // 
            this.recomendedToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.recomendedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.recomendedToolStripMenuItem.Name = "recomendedToolStripMenuItem";
            this.recomendedToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.recomendedToolStripMenuItem.Text = "Recomend";
            this.recomendedToolStripMenuItem.Click += new System.EventHandler(this.recomendedToolStripMenuItem_Click);
            // 
            // actualToolStripMenuItem
            // 
            this.actualToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.actualToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.actualToolStripMenuItem.Name = "actualToolStripMenuItem";
            this.actualToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.actualToolStripMenuItem.Text = "Virtual";
            this.actualToolStripMenuItem.Click += new System.EventHandler(this.actualToolStripMenuItem_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(355, 54);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Brown;
            this.btnAddToCart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(265, 355);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(111, 36);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click_1);
            this.btnAddToCart.MouseLeave += new System.EventHandler(this.btnAddToCart_MouseLeave);
            this.btnAddToCart.MouseHover += new System.EventHandler(this.btnAddToCart_MouseHover);
            // 
            // btnViewCart
            // 
            this.btnViewCart.BackColor = System.Drawing.Color.Brown;
            this.btnViewCart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCart.ForeColor = System.Drawing.Color.White;
            this.btnViewCart.Location = new System.Drawing.Point(391, 355);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(98, 36);
            this.btnViewCart.TabIndex = 5;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = false;
            this.btnViewCart.Visible = false;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            this.btnViewCart.MouseLeave += new System.EventHandler(this.btnViewCart_MouseLeave);
            this.btnViewCart.MouseHover += new System.EventHandler(this.btnViewCart_MouseHover);
            this.btnViewCart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnViewCart_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblLogOut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Location = new System.Drawing.Point(717, 0);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(10);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Padding = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.lblLogOut.Size = new System.Drawing.Size(71, 23);
            this.lblLogOut.TabIndex = 7;
            this.lblLogOut.Text = "LogOut";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            this.lblLogOut.MouseLeave += new System.EventHandler(this.lblLogOut_MouseLeave);
            this.lblLogOut.MouseHover += new System.EventHandler(this.lblLogOut_MouseHover);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 410);
            this.ControlBox = false;
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnViewCart;
        public System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem recomendedToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem actualToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogOut;
    }
}