using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static object Employee { get; internal set; }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string userName = "Isuru";
            string passWord = "Isuru123";

            string user = user_name.Text;
            string pass = password.Text;

            if (userName == user && passWord == pass)
            {
                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Customers customer = new Customers();
                customer.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Usename / Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
