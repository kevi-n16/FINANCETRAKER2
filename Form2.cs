using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINANCETRAKER2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            if(string.IsNullOrWhiteSpace(Username))
            {
                MessageBox.Show("Enter Username");
            }else if(string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Enter Password");
                return;
            }
            else if(txtUsername.Text != "ayer" || txtPassword.Text != "kev123")
            {
                MessageBox.Show("Wrong username or Wrong password");
            }
            if(txtUsername.Text=="ayer" && txtPassword.Text == "kev123")
            {
                Form1 financeForm = new Form1();
                financeForm.Show();

                
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
