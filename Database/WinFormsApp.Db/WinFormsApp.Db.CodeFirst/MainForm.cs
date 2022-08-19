using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Db.CodeFirst.Admin;

namespace WinFormsApp.Db.CodeFirst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Program.login.Show();
            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 calculator = new Form1();
            calculator.MdiParent = this;
            calculator.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.MdiParent = this;
            inventory.Show();
        }
    }
}