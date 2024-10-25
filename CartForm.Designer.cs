namespace Shopping_Cart
{
    partial class CartForm
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
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.btnAddCoupon = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCheckTotal = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.Location = new System.Drawing.Point(22, 33);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(793, 199);
            this.listBoxCart.TabIndex = 0;
            this.listBoxCart.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAddCoupon
            // 
            this.btnAddCoupon.BackColor = System.Drawing.Color.DimGray;
            this.btnAddCoupon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCoupon.ForeColor = System.Drawing.Color.White;
            this.btnAddCoupon.Location = new System.Drawing.Point(150, 256);
            this.btnAddCoupon.Name = "btnAddCoupon";
            this.btnAddCoupon.Size = new System.Drawing.Size(90, 33);
            this.btnAddCoupon.TabIndex = 1;
            this.btnAddCoupon.Text = "Add Cupon";
            this.btnAddCoupon.UseVisualStyleBackColor = false;
            this.btnAddCoupon.Click += new System.EventHandler(this.btnAddCoupon_Click);
            this.btnAddCoupon.MouseLeave += new System.EventHandler(this.btnAddCoupon_MouseLeave);
            this.btnAddCoupon.MouseHover += new System.EventHandler(this.btnAddCoupon_MouseHover);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.DimGray;
            this.btnRemoveItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(269, 256);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(99, 33);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click_1);
            this.btnRemoveItem.MouseLeave += new System.EventHandler(this.btnRemoveItem_MouseLeave);
            this.btnRemoveItem.MouseHover += new System.EventHandler(this.btnRemoveItem_MouseHover);
            // 
            // btnCheckTotal
            // 
            this.btnCheckTotal.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckTotal.ForeColor = System.Drawing.Color.White;
            this.btnCheckTotal.Location = new System.Drawing.Point(396, 256);
            this.btnCheckTotal.Name = "btnCheckTotal";
            this.btnCheckTotal.Size = new System.Drawing.Size(98, 33);
            this.btnCheckTotal.TabIndex = 3;
            this.btnCheckTotal.Text = "Check Out";
            this.btnCheckTotal.UseVisualStyleBackColor = false;
            this.btnCheckTotal.Click += new System.EventHandler(this.btnCheckTotal_Click_1);
            this.btnCheckTotal.MouseLeave += new System.EventHandler(this.btnCheckTotal_MouseLeave);
            this.btnCheckTotal.MouseHover += new System.EventHandler(this.btnCheckTotal_MouseHover);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.DimGray;
            this.Return.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Return.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.Color.White;
            this.Return.Location = new System.Drawing.Point(526, 256);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(86, 33);
            this.Return.TabIndex = 4;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            this.Return.MouseLeave += new System.EventHandler(this.Return_MouseLeave);
            this.Return.MouseHover += new System.EventHandler(this.Return_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Brown;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.Return;
            this.ClientSize = new System.Drawing.Size(840, 301);
            this.ControlBox = false;
            this.Controls.Add(this.Return);
            this.Controls.Add(this.btnCheckTotal);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddCoupon);
            this.Controls.Add(this.listBoxCart);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CartForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Button btnAddCoupon;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnCheckTotal;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}