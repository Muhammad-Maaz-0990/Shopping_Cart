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
    public partial class CouponFormcs : Form
    {
        public CouponFormcs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == "111111")
            {
                this.DialogResult = DialogResult.OK;
                txtOTP.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid OTP.");
                txtOTP.Clear();
            }
        }

        private void CouponFormcs_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Gray;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Brown;
        }
    }
}
