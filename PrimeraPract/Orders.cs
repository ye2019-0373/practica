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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");

        public void full()
        {
            string consul = "select * from Orders ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            ordersDataGridView.DataSource = dt;

        }
        public void full1()
        {
            string consul = "select * from Order Details ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            order_DetailsDataGridView.DataSource = dt;

        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet17.Shippers' Puede moverla o quitarla según sea necesario.
            this.shippersTableAdapter.Fill(this.northwindDataSet17.Shippers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet15.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter1.Fill(this.northwindDataSet15.Customers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet14.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter1.Fill(this.northwindDataSet14.Orders);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet13.Employees' Puede moverla o quitarla según sea necesario.
            this.employeesTableAdapter.Fill(this.northwindDataSet13.Employees);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet12.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet12.Customers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Order_Details' Puede moverla o quitarla según sea necesario.
            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Borrarval();
           
            Validar();
        }

      

        private bool Validar()
        {
            bool ok = true;
           

            if (comboBox1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboBox1, "No se permiten campos vacios");
            }

            if (comboBox2.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboBox2, "No se permiten campos vacios");
            }

            if (comboBox5.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboBox5, "No se permiten campos vacios");
            }

            if (freightTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(freightTextBox, "No se permiten campos vacios");
            }

            if (shipNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(shipNameTextBox, "No se permiten campos vacios");
            }

            if (shipAddressTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(shipAddressTextBox, "No se permiten campos vacios");
            }

            if (shipCityTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(shipCityTextBox, "No se permiten campos vacios");
            }
            if (shipRegionTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(shipRegionTextBox, "No se permiten campos vacios");
            }

            if (shipPostalCodeTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(shipPostalCodeTextBox, "No se permiten campos vacios");
            }

            if (shipCountryTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(shipCountryTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();

                var cons = "insert into Orders (CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate,ShipVia ,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry)  Values ('"+comboBox1.Text+"','"+comboBox2.Text+"','" +orderDateDateTimePicker.Value+"','" +requiredDateDateTimePicker.Value+ "','"+shippedDateDateTimePicker.Value +"',"+ comboBox5.Text+",'"+freightTextBox.Text+ "','"+shipNameTextBox.Text + "','" + shipAddressTextBox.Text +"','"+shipCityTextBox.Text+"','"+shipRegionTextBox.Text+"','"+shipPostalCodeTextBox.Text+"','"+shipCountryTextBox.Text+"')";
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
           
            errorProvider1.SetError(comboBox1, "");
            errorProvider1.SetError(comboBox2, "");  
            errorProvider1.SetError(shippedDateDateTimePicker, "");
            errorProvider1.SetError(comboBox5, "");
            errorProvider1.SetError(freightTextBox, "");
            errorProvider1.SetError(shipNameTextBox, "");
            errorProvider1.SetError(shipAddressTextBox, "");
            errorProvider1.SetError(shipCityTextBox, "");
            errorProvider1.SetError(shipRegionTextBox, "");
            errorProvider1.SetError(shipPostalCodeTextBox, "");
            errorProvider1.SetError(shipCountryTextBox, "");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Borrarval1();
            Validar1();
        }
        private bool Validar1()
        {
            bool ok = true;
            if (comboBox3.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboBox3, "No se permiten campos vacios");
            }

            if (comboBox4.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboBox4, "No se permiten campos vacios");
            }

            if (unitPriceTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(unitPriceTextBox, "No se permiten campos vacios");
            }

            if (quantityTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(quantityTextBox, "No se permiten campos vacios");
            }


            if (discountTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(discountTextBox, "No se permiten campos vacios");
            }

         
            else
            {
                cn.Open();

                var cons = "insert into Order Details (OrderID,ProductID,UnitPrice,Quantity,Discount) Values (" + comboBox3.Text + "," + comboBox4.Text + "," + unitPriceTextBox.Text + "," + quantityTextBox.Text + "," + discountTextBox.Text + ")";
                SqlCommand com = new SqlCommand(cons, cn);
                com.ExecuteNonQuery();
                MessageBox.Show("datos agregados");
                full1();
                cn.Close();
            }
            return ok;

        }

        private void Borrarval1()
        {
            errorProvider1.SetError(comboBox3, "");
            errorProvider1.SetError(comboBox4, "");
            errorProvider1.SetError(unitPriceTextBox, "");
            errorProvider1.SetError(quantityTextBox, "");
            errorProvider1.SetError(discountTextBox, "");
          
        }
    }
}
