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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");

        public void full()
        {
            string consul = "select * from Customers ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            customersDataGridView.DataSource = dt;

        }
        public void full2()
        {
            string consul = "select * from CustomerDemographics ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            customerDemographicsDataGridView.DataSource = dt;
        }
        public void full3()
        {
            string consul = "select * from CustomerCustomerDemo  ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            customerCustomerDemoDataGridView.DataSource = dt;
        }

        private void customerCustomerDemoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerCustomerDemoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet7.CustomerDemographics' Puede moverla o quitarla según sea necesario.
            this.customerDemographicsTableAdapter1.Fill(this.northwindDataSet7.CustomerDemographics);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet5.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter1.Fill(this.northwindDataSet5.Customers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.CustomerDemographics' Puede moverla o quitarla según sea necesario.
            this.customerDemographicsTableAdapter.Fill(this.northwindDataSet.CustomerDemographics);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.CustomerCustomerDemo' Puede moverla o quitarla según sea necesario.
            this.customerCustomerDemoTableAdapter.Fill(this.northwindDataSet.CustomerCustomerDemo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrarval();
            if (Validar())
            {
                MessageBox.Show("datos agregados");
            }

        }
        private bool Validar()
        {
            bool ok = true;
            if (customerIDTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(customerIDTextBox, "No se permiten campos vacios");
            }

            if (companyNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(companyNameTextBox, "No se permiten campos vacios");
            }

            if (contactNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(contactNameTextBox, "No se permiten campos vacios");
            }

            if (contactTitleTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(contactTitleTextBox, "No se permiten campos vacios");
            }

            if (addressTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(addressTextBox, "No se permiten campos vacios");
            }

            if (cityTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cityTextBox, "No se permiten campos vacios");
            }

            if (regionTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(regionTextBox, "No se permiten campos vacios");
            }

            if (postalCodeTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(postalCodeTextBox, "No se permiten campos vacios");
            }

            if (countryTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(countryTextBox, "No se permiten campos vacios");
            }

            if (phoneTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(phoneTextBox, "No se permiten campos vacios");
            }
            if (faxTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(faxTextBox, "No se permiten campos vacios");
            }

            else
            {
                cn.Open();

                string cons = "insert into Customers(CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) Values ('" + customerIDTextBox.Text + "','" + companyNameTextBox.Text + "','" + contactNameTextBox.Text + "','" + contactTitleTextBox.Text + "','" + addressTextBox.Text + "','" + cityTextBox.Text + "','" + regionTextBox.Text + "','" + postalCodeTextBox.Text + "','" + countryTextBox.Text + "','" + phoneTextBox.Text + "','" + faxTextBox.Text + "')";
                SqlCommand com = new SqlCommand(cons, cn);
                com.ExecuteNonQuery();
                full();
                cn.Close();
            }
            return ok;

        }

        private void Borrarval()
        {
            errorProvider1.SetError(customerIDTextBox, "");
            errorProvider1.SetError(companyNameTextBox, "");
            errorProvider1.SetError(contactNameTextBox, "");
            errorProvider1.SetError(contactTitleTextBox, "");
            errorProvider1.SetError(addressTextBox, "");
            errorProvider1.SetError(cityTextBox, "");
            errorProvider1.SetError(regionTextBox, "");
            errorProvider1.SetError(postalCodeTextBox, "");
            errorProvider1.SetError(countryTextBox, "");
            errorProvider1.SetError(phoneTextBox, "");
            errorProvider1.SetError(faxTextBox, "");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            borrardemographics();
            Validardemographic();
        }
        private bool Validardemographic()
        {
            bool ok = true;
            if (customerTypeIDTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(customerTypeIDTextBox, "No se permiten campos vacios");
            }

            if (customerDescTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(customerDescTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();

                string cons = "insert into CustomerDemographics(CustomerTypeID,CustomerDesc) Values ('" + customerDescTextBox.Text + "','" + customerDescTextBox.Text + "')";
                SqlCommand com = new SqlCommand(cons, cn);
                com.ExecuteNonQuery();
                MessageBox.Show("Guardado satisfactoriamente");
                full2();
                cn.Close();
            }

            return ok;

        }
        public void borrardemographics()
        {
            errorProvider1.SetError(customerTypeIDTextBox, "");
            errorProvider1.SetError(customerDescTextBox, "");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerTypeIDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void customerIDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            borrardemo();
            Validardemo();
        }
        private bool Validardemo()
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
            else
            {
                cn.Open();

                string cons = "insert into CustomerCustomerDemo(CustomerID,CustomerTypeID) Values ('" + comboBox1.Text + "','" + comboBox2.Text + "')";
                SqlCommand com = new SqlCommand(cons, cn);
                com.ExecuteNonQuery();
                MessageBox.Show("Guardado satisfactoriamente");
                full3();
                cn.Close();
            }

            return ok;

        }
        public void borrardemo()
        {
            errorProvider1.SetError(comboBox1, "");
            errorProvider1.SetError(comboBox2, "");
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Borrarval();
            valmodificar();
        }
        private bool valmodificar()
        {
            bool ok = true;
            if (customerIDTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(customerIDTextBox, "Este campo es Obligatorio");
            }
            else
            {
                cn.Open();
                string consult = "update Customers set CustomerID='" + customerIDTextBox.Text + "',CompanyName='" + companyNameTextBox.Text + "',ContactTitle='" + contactTitleTextBox.Text + "',Address='" + addressTextBox.Text + "' ,City='" + cityTextBox.Text + "', Region= '" + regionTextBox.Text + "', PostalCode='" + postalCodeTextBox.Text + "',Country= '" + countryTextBox.Text + "',Phone= '" + phoneTextBox.Text + "',Fax= '" + faxTextBox.Text + "'where CustomerID= '" + customerIDTextBox.Text + "' ";
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
        private void borrar()
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            borrardemo();
            Validacion();
        }
        private bool Validacion()
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
            else
            {
                cn.Open();
                string consult = "update CustomerCustomerDemo set CustomerID='" + comboBox1.Text + "',CustomerTypeID= '" + comboBox2.Text + "'where CustomerID= '" + comboBox1.Text + "' ";
                SqlCommand comand = new SqlCommand(consult, cn);
                int can;
                can = comand.ExecuteNonQuery();
                if (can > 0)
                {
                    MessageBox.Show("modificado satisfactoriamente");

                }
                full3();
                cn.Close();
            }

            return ok;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            borrardemographics();
            ValidacionGRAPHICS();
        }
        private bool ValidacionGRAPHICS()
        {
            bool ok = true;
            if (customerTypeIDTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(customerTypeIDTextBox, "No se permiten campos vacios");
            }

            if (customerDescTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(customerDescTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();
                string consult = "update CustomerDemographics set CustomerTypeID='" + customerTypeIDTextBox.Text + "',CustomerDesc= '" + customerDescTextBox.Text + "'where CustomerTypeID= '" + customerTypeIDTextBox.Text + "' ";
                SqlCommand comand = new SqlCommand(consult, cn);
                int can;
                can = comand.ExecuteNonQuery();
                if (can > 0)
                {
                    MessageBox.Show("modificado satisfactoriamente");

                }
                full3();
                cn.Close();
            }

            return ok;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cn.Open();
            string consu = "delete from Customers where CustomerID='" + customerIDTextBox.Text + "' ";
            SqlCommand com = new SqlCommand(consu, cn);
            com.ExecuteNonQuery();
            MessageBox.Show("Eliminado Satisfactoriamente");
            full();

            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var atras = new menu();
            this.Hide();
            atras.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
