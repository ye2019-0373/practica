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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");

        public void full()
        {
            string consul = "select * from Suppliers ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            suppliersDataGridView.DataSource = dt;

        }
        private void eregresar_Click(object sender, EventArgs e)
        {
            var atras = new menu();
            this.Hide();
            atras.Show();
        }


        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);

        }

        private void suppliersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)

        {
            Borrarval();
            Validar();
        }
        private bool Validar()
        {
            bool ok = true;
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

            if (homePageTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(homePageTextBox, "No se permiten campos vacios");
            }

            else
            {
                cn.Open();

                string cons = "insert into Suppliers Values ('"+companyNameTextBox.Text+"','" + contactNameTextBox.Text + "','" + contactTitleTextBox.Text + "','" + addressTextBox.Text + "','" + cityTextBox.Text + "','" + regionTextBox.Text + "','" + postalCodeTextBox.Text + "','" + countryTextBox.Text + "','" + phoneTextBox.Text + "','" + faxTextBox.Text + "','" + homePageTextBox.Text + "')";
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
            errorProvider1.SetError(homePageTextBox, "");

        }


        private void button5_Click(object sender, EventArgs e)
        {

            borrar(); 
            valmodificar();
        }

        private bool valmodificar()
        {
            bool ok = true;
            if (companyNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(companyNameTextBox, "Este campo es Obligatorio");
            }
            else
            {
                cn.Open();
                string consult = "update Suppliers set CompanyName='" + companyNameTextBox.Text + "',ContactName='" + contactNameTextBox.Text + "',ContactTitle='" + contactTitleTextBox.Text + "',Address='" + addressTextBox.Text + "' ,City='" + cityTextBox.Text + "', Region= '" + regionTextBox.Text + "', PostalCode='" + postalCodeTextBox.Text + "',Country= '" + countryTextBox.Text + "',Phone= '" + phoneTextBox.Text + "',Fax= '" + faxTextBox.Text + "',HomePage= '" + homePageTextBox.Text + "'where CompanyName= '" + companyNameTextBox.Text + "' ";
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
            errorProvider1.SetError(companyNameTextBox, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var atras = new menu();
            this.Hide();
            atras.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
            cn.Open();
            string consu = "delete from Suppliers where CompanyName= '" + companyNameTextBox.Text + "'";
            SqlCommand com = new SqlCommand(consu, cn);
            com.ExecuteNonQuery();
            MessageBox.Show("Eliminado Satisfactoriamente");
            full();

            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            cn.Open();
            string consu = "delete from Suppliers where CompanyName= '" + companyNameTextBox.Text + "'";
            SqlCommand com = new SqlCommand(consu, cn);
            com.ExecuteNonQuery();
            MessageBox.Show("Eliminado Satisfactoriamente");
            full();

            cn.Close();
        }
    }
}
