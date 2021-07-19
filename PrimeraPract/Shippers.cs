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
    public partial class Shippers : Form
    {
        public Shippers()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");

        public void full()
        {
            string consul = "select * from Shippers ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            shippersDataGridView.DataSource = dt;

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void shippersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shippersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Shippers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Shippers' Puede moverla o quitarla según sea necesario.
            this.shippersTableAdapter.Fill(this.northwindDataSet.Shippers);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var atras = new menu();
            this.Hide();
            atras.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            borrar();
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

            if (phoneTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(phoneTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();

                string cons = "insert into Shippers Values ('" + companyNameTextBox.Text + "','" + phoneTextBox.Text + "')";
                SqlCommand com = new SqlCommand(cons, cn);
                com.ExecuteNonQuery();
                MessageBox.Show("Guardado satisfactoriamente");
                full();
                cn.Close();
            }

            return ok;
        }

        public void borrar()
        {
            errorProvider1.SetError(companyNameTextBox, "");
            errorProvider1.SetError(phoneTextBox, "");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            borrarv();
            Validacion();
        }
        private bool Validacion()
        {
            bool ok = true;
            if (companyNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(companyNameTextBox, "No se permiten campos vacios");
            }

            if (phoneTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(phoneTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();
                string consult = "update Shippers set CompanyName='" + companyNameTextBox.Text + "',Phone= '" + phoneTextBox.Text +  "'where CompanyName= '" + companyNameTextBox.Text + "' ";
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
        private void borrarv()
        {
            errorProvider1.SetError(companyNameTextBox, "");
            errorProvider1.SetError(phoneTextBox, "");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cn.Open();
            string consu = "delete from Shippers where CompanyName= '" + companyNameTextBox.Text + "'";
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
    }
}
