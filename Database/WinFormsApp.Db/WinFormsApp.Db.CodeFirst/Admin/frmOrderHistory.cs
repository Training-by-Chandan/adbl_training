using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Db.CodeFirst.Models;
using WinFormsApp.Db.CodeFirst.Models.ViewModels;
using WinFormsApp.Db.CodeFirst.Services;

namespace WinFormsApp.Db.CodeFirst.Admin
{
    public partial class frmOrderHistory : Form
    {
        private InventoryServices inventoryServices = new InventoryServices();
        private OrderServices orderServices = new OrderServices();

        public frmOrderHistory()
        {
            InitializeComponent();
        }

        private void frmOrderHistory_Load(object sender, EventArgs e)
        {
            cmbProduct.DataSource = inventoryServices.GetItemsForComboBox();
            cmbProduct.DisplayMember = "Value";
            cmbProduct.ValueMember = "Key";
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text = ((ComboBoxModel)cmbProduct.SelectedItem).Value;
            //label2.Text = cmbProduct.SelectedValue.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var order = new OrderHistory()
            {
                FirstName = txtFirstName.Text,
                Email = txtEmail.Text,
                LastName = txtLastName.Text,
                Quantity = Convert.ToDouble(txtQuantity.Text),
                InventoryId = ((ComboBoxModel)cmbProduct.SelectedItem).Key
            };
            var res = orderServices.Create(order);
            if (res.Item1)
            {
                clearTextFields();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }

        private void clearTextFields()
        {
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtQuantity.Clear();
            cmbProduct.SelectedIndex = -1;
        }
    }
}