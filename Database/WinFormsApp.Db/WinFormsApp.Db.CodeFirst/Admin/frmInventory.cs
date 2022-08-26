using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Db.CodeFirst.Models;
using WinFormsApp.Db.CodeFirst.Services;

namespace WinFormsApp.Db.CodeFirst.Admin
{
    public partial class frmInventory : Form
    {
        private InventoryServices inventoryServices = new InventoryServices();

        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadData();
            loadComboBoxData();
        }

        private void loadComboBoxData()
        {
            cmbUnits.DataSource = Enum.GetValues<Units>();
        }

        private void LoadData()
        {
            grdInventory.DataSource = inventoryServices.GetAll();
            grdInventory.Columns["Id"].Visible = false;
            grdInventory.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            grdInventory.DataSource = inventoryServices.GetFilteredByText(txtSearch.Text);
            grdInventory.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory()
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Price = Convert.ToDouble(txtPrice.Text),
                Quantity = Convert.ToDouble(txtQuantity.Text),
                Units = (Units)cmbUnits.SelectedItem
            };
            var res = inventoryServices.Create(inventory);
            if (res.Item1)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }

        private void clearTextFields()
        {
            txtCode.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbUnits.SelectedIndex = -1;
            lblId.Text = "";
        }

        private void grdInventory_SelectionChanged(object sender, EventArgs e)
        {
            var rows = grdInventory.SelectedRows;
            if (rows.Count > 0)
            {
                //we know that the rows are selected (multiple rows)
                var row = rows[0];
                lblId.Text = row.Cells["Id"].Value.ToString();
                txtCode.Text = row.Cells["Code"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                cmbUnits.SelectedItem = (Units)row.Cells["Units"].Value;

                EditMode(true);
            }
            else
            {
                //rows are not selected
                clearTextFields();
                EditMode(false);
            }
        }

        private void EditMode(bool enabled)
        {
            btnEdit.Visible = enabled;
            btnDelete.Visible = enabled;
            btnCreate.Visible = !enabled;
            btnReset.Visible = !enabled;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory()
            {
                Id = Convert.ToInt32(lblId.Text),
                Code = txtCode.Text,
                Name = txtName.Text,
                Price = Convert.ToDouble(txtPrice.Text),
                Quantity = Convert.ToDouble(txtQuantity.Text),
                Units = (Units)cmbUnits.SelectedItem
            };
            var res = inventoryServices.Edit(inventory);
            if (res.Item1)
            {
                clearTextFields();
                LoadData();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt32(lblId.Text);
            var res = inventoryServices.Delete(Id);
            if (res.Item1)
            {
                clearTextFields();
                LoadData();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }
    }
}