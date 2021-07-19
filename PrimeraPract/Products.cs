using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeraPract
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");

        public void full()
        {
            string consul = "select * from Products ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            productsDataGridView.DataSource = dt;

        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet10.Categories' Puede moverla o quitarla según sea necesario.
            this.categoriesTableAdapter.Fill(this.northwindDataSet10.Categories);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet9.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.northwindDataSet9.Suppliers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Borrarval();
            Validar();
        }
        private bool Validar()
        {
            bool ok = true;
            if (productNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(productNameTextBox, "No se permiten campos vacios");
            }

            if (supplierid.Text == "")
            {
                ok = false;
                errorProvider1.SetError(supplierid, "No se permiten campos vacios");
            }

            if (categoryid.Text == "")
            {
                ok = false;
                errorProvider1.SetError(categoryid, "No se permiten campos vacios");
            }

            if (quantityPerUnitTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(quantityPerUnitTextBox, "No se permiten campos vacios");
            }


            if (unitPriceTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(unitPriceTextBox, "No se permiten campos vacios");
            }

            if (unitsInStockTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(unitsInStockTextBox, "No se permiten campos vacios");
            }

            if (unitsOnOrderTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(unitsOnOrderTextBox, "No se permiten campos vacios");
            }

            if (reorderLevelTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(reorderLevelTextBox, "No se permiten campos vacios");
            }


            else
            {
                cn.Open();

                var cons = "insert into Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel,Discontinued) Values ('" + productNameTextBox.Text + "'," + supplierid.Text + "," + categoryid.Text + ",'" + quantityPerUnitTextBox.Text + "'," + unitPriceTextBox.Text + "," + unitsInStockTextBox.Text + "," + unitsOnOrderTextBox.Text + "," + reorderLevelTextBox.Text + ")";
                SqlCommand com = new SqlCommand(cons, cn);
                com.ExecuteNonQuery();
                MessageBox.Show("datos agregados");
                full();
                cn.Close();
            }
            return ok;

        }
        private void Borrarval()
        {
            errorProvider1.SetError(productNameTextBox, "");
            errorProvider1.SetError(supplierid, "");
            errorProvider1.SetError(categoryid, "");
            errorProvider1.SetError(quantityPerUnitTextBox, "");
            errorProvider1.SetError(unitPriceTextBox, "");
            errorProvider1.SetError(unitsInStockTextBox, "");
            errorProvider1.SetError(unitsOnOrderTextBox, "");
            errorProvider1.SetError(reorderLevelTextBox, "");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var atras = new menu();
            this.Hide();
            atras.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Borrarval();
            valmodificar();

        }
        private bool valmodificar()
        {
            bool ok = true;
            if (productNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(productNameTextBox, "No se permiten campos vacios");
            }

            if (supplierid.Text == "")
            {
                ok = false;
                errorProvider1.SetError(supplierid, "No se permiten campos vacios");
            }

            if (categoryid.Text == "")
            {
                ok = false;
                errorProvider1.SetError(categoryid, "No se permiten campos vacios");
            }

            if (quantityPerUnitTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(quantityPerUnitTextBox, "No se permiten campos vacios");
            }


            if (unitPriceTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(unitPriceTextBox, "No se permiten campos vacios");
            }

            if (unitsInStockTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(unitsInStockTextBox, "No se permiten campos vacios");
            }

            if (unitsOnOrderTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(unitsOnOrderTextBox, "No se permiten campos vacios");
            }

            if (reorderLevelTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(reorderLevelTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();
                string consult = "update Products set ProductName ='" + productNameTextBox.Text + "',SupplierID='" + supplierid.Text + "',CategoryID='" + categoryid.Text + "',QuantityPerUnit='" + quantityPerUnitTextBox.Text + "',UnitPrice='" + unitPriceTextBox.Text + "', UnitsInStock= '" + unitsInStockTextBox.Text + "', UnitsOnOrder='" + unitsOnOrderTextBox.Text + "',ReorderLevel= '" + reorderLevelTextBox.Text + "'WHERE ProductName= '" + productNameTextBox.Text + "'";
                SqlCommand comand = new SqlCommand(consult, cn);
                int can;
                can = comand.ExecuteNonQuery();
                if (can > 0)
                {
                    MessageBox.Show("modificado satisfactoriamente");

                }
                full();
                cn.Close();
            }
            return ok;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cn.Open();
            string consu = "delete from Products where ProductName= '" +productNameTextBox.Text + "'";
            SqlCommand com = new SqlCommand(consu, cn);
            com.ExecuteNonQuery();
            MessageBox.Show("Eliminado Satisfactoriamente");
            full();

            cn.Close();
        }
    }
}
