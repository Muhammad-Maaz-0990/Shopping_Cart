


using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class Form1 : Form
    {
        // File path for storing user data
        private string filePath = "users.txt";

        public Form1()
        {
            InitializeComponent();
            // Set Login panel visible by default
            

            lblSwitchToLogin.Visible = false;
            txtSignUpEmail.Visible = false;
            txtSignUpUsername.Visible = false;
            txtSignUpPassword.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btnSignUp.Visible = false;
            txtLoginUsername.Focus();
            

        }

        // Switch to Sign-Up panel
        private void lblSwitchToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            lblSwitchToLogin.Visible = true;
            txtSignUpEmail.Visible = true;
            txtSignUpUsername.Visible = true;
            txtSignUpPassword.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            btnSignUp.Visible = true;


            lblSwitchToSignUp.Visible = false;
            txtLoginUsername.Visible = false;
            txtLoginPassword.Visible = false;
            btnLogin.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            txtSignUpEmail.Clear();
            txtSignUpUsername.Clear();
            txtSignUpPassword.Clear();
            txtSignUpEmail.Focus();
        }

        // Switch to Login panel
        private void lblSwitchToLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblSwitchToSignUp.Visible = true;
            txtSignUpEmail.Visible = false;
            txtSignUpUsername.Visible = false;
            txtSignUpPassword.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btnSignUp.Visible = false;

            lblSwitchToLogin.Visible = false;
            txtLoginUsername.Visible = true;
            txtLoginPassword.Visible = true;
            btnLogin.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            
            txtLoginUsername.Clear();
            txtLoginPassword.Clear();
            txtLoginUsername.Focus();
        }
        

        // Login button click event
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;

            // Validate login with file data
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var credentials = line.Split(',');
                    if (credentials[0] == username && credentials[1] == password)
                    {
                        MessageBox.Show("Login successful!");
                        txtLoginUsername.Clear();
                        txtLoginPassword.Clear();
                        this.Hide();
                        DashboardForm dash = new DashboardForm();
                        dash.ShowDialog();
                        this.Show();
                        return;
                    }
                }
                MessageBox.Show("Invalid Username or Password.");
                txtLoginUsername.Clear();
                txtLoginPassword.Clear();
            }
            else
            {
                MessageBox.Show("No users found. Please sign up.");
                txtLoginUsername.Clear();
                txtLoginPassword.Clear();
            }
        }

        // Sign-Up button click event
        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            string email = txtSignUpEmail.Text;
            string username = txtSignUpUsername.Text;
            string password = txtSignUpPassword.Text;

            // Validate email ending with @gmail.com
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email must end with @gmail.com");
                return;
            }

            // Check if username already exists in file
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var credentials = line.Split(',');
                    if (credentials[0] == username)
                    {
                        MessageBox.Show("Username already exists. Please choose another.");
                        return;

                    }
                }
            }

            // Append new user details to the file
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{username},{password},{email}");
            }

            MessageBox.Show("Sign-Up successful! You can now log in.");
            txtSignUpEmail.Clear();
            txtSignUpUsername.Clear();
            txtSignUpPassword.Clear();
            
            
        }

        private Panel panelLogin;
        private TextBox txtLoginPassword;
        private LinkLabel lblSwitchToSignUp;
        private Button btnLogin;
        private TextBox txtLoginUsername;
        private Label label2;
        private Label label1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblSwitchToLogin = new System.Windows.Forms.LinkLabel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtSignUpPassword = new System.Windows.Forms.TextBox();
            this.lblSwitchToSignUp = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSignUpEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSignUpUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lblSwitchToLogin);
            this.panelLogin.Controls.Add(this.btnSignUp);
            this.panelLogin.Controls.Add(this.txtLoginPassword);
            this.panelLogin.Controls.Add(this.txtSignUpPassword);
            this.panelLogin.Controls.Add(this.lblSwitchToSignUp);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtLoginUsername);
            this.panelLogin.Controls.Add(this.label5);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.txtSignUpEmail);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.txtSignUpUsername);
            this.panelLogin.Location = new System.Drawing.Point(12, 200);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(352, 213);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSwitchToLogin
            // 
            this.lblSwitchToLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSwitchToLogin.AutoSize = true;
            this.lblSwitchToLogin.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitchToLogin.LinkColor = System.Drawing.Color.Black;
            this.lblSwitchToLogin.Location = new System.Drawing.Point(106, 165);
            this.lblSwitchToLogin.Name = "lblSwitchToLogin";
            this.lblSwitchToLogin.Size = new System.Drawing.Size(157, 16);
            this.lblSwitchToLogin.TabIndex = 19;
            this.lblSwitchToLogin.TabStop = true;
            this.lblSwitchToLogin.Text = "Already have an account? Login";
            this.lblSwitchToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSwitchToLogin_LinkClicked_1);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignUp.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(133, 111);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(95, 40);
            this.btnSignUp.TabIndex = 18;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click_1);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(165, 41);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(133, 20);
            this.txtLoginPassword.TabIndex = 5;
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.Location = new System.Drawing.Point(146, 75);
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.PasswordChar = '*';
            this.txtSignUpPassword.Size = new System.Drawing.Size(133, 20);
            this.txtSignUpPassword.TabIndex = 17;
            this.txtSignUpPassword.TextChanged += new System.EventHandler(this.txtSignUpPassword_TextChanged);
            // 
            // lblSwitchToSignUp
            // 
            this.lblSwitchToSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSwitchToSignUp.AutoSize = true;
            this.lblSwitchToSignUp.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitchToSignUp.LinkColor = System.Drawing.Color.Black;
            this.lblSwitchToSignUp.Location = new System.Drawing.Point(106, 165);
            this.lblSwitchToSignUp.Name = "lblSwitchToSignUp";
            this.lblSwitchToSignUp.Size = new System.Drawing.Size(157, 16);
            this.lblSwitchToSignUp.TabIndex = 4;
            this.lblSwitchToSignUp.TabStop = true;
            this.lblSwitchToSignUp.Text = "Don\'t have an account? Sign Up";
            this.lblSwitchToSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSwitchToSignUp_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(133, 111);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(165, 3);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(133, 20);
            this.txtLoginUsername.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtSignUpEmail
            // 
            this.txtSignUpEmail.Location = new System.Drawing.Point(146, 0);
            this.txtSignUpEmail.Name = "txtSignUpEmail";
            this.txtSignUpEmail.Size = new System.Drawing.Size(133, 20);
            this.txtSignUpEmail.TabIndex = 15;
            this.txtSignUpEmail.TextChanged += new System.EventHandler(this.txtSignUpEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "User-Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User-Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txtSignUpUsername
            // 
            this.txtSignUpUsername.Location = new System.Drawing.Point(146, 37);
            this.txtSignUpUsername.Name = "txtSignUpUsername";
            this.txtSignUpUsername.Size = new System.Drawing.Size(133, 20);
            this.txtSignUpUsername.TabIndex = 11;
            this.txtSignUpUsername.TextChanged += new System.EventHandler(this.txtSignUpUsername_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(366, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnLogin;
            this.ClientSize = new System.Drawing.Size(393, 425);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLogin);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void panelSignUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private TextBox txtSignUpPassword;
        private Label label5;
        private TextBox txtSignUpEmail;
        private Label label3;
        private TextBox txtSignUpUsername;
        private Label label4;

        private void txtSignUpEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSignUpPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSignUpUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox1;

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private Button btnSignUp;
        private LinkLabel lblSwitchToLogin;
        private PictureBox pictureBox2;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

