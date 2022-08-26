using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Db.CodeFirst.Services;

namespace WinFormsApp.Db.CodeFirst
{
    public partial class LoginForm : Form
    {
        private UserServices userServices = new UserServices();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void clearTextFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var res = userServices.Login(txtUsername.Text, txtPassword.Text);
            if (res.Item1)
            {
                MainForm frm = new MainForm();
                frm.Show();
                clearTextFields();
                this.Hide();
            }
            else
            {
                if (res.Item3 == 2)
                {
                    lblPasswordValidation.Text = res.Item2;
                    lblPasswordValidation.Visible = true;
                }
                else
                {
                    MessageBox.Show(res.Item2);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = Hasher.HashPassword(txtPassword.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = txtUsername.Text;
            if (Hasher.VerifyHashedPassword(str, txtPassword.Text))
            {
                MessageBox.Show("Matched");
            }
            else
            {
                MessageBox.Show("Not matched");
            }
        }
    }
}