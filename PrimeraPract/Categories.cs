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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");

        public void full()
        {
            string consul = "select * from Categories ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            categoriesDataGridView.DataSource = dt;

        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Categories' Puede moverla o quitarla según sea necesario.
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            borrar();
            Validar();
        }
        private bool Validar()
        {
            bool ok = true;
            if (categoryNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(categoryNameTextBox, "No se permiten campos vacios");
            }

            if (descriptionTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(descriptionTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();

                string cons = "insert into Categories(CategoryName,Description) Values ('" + categoryNameTextBox.Text + "','" + descriptionTextBox.Text + "')";
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
            errorProvider1.SetError(categoryNameTextBox, "");
            errorProvider1.SetError(descriptionTextBox, "");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Validacion();
        }
        private bool Validacion()
        {
            bool ok = true;
            if (categoryNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(categoryNameTextBox, "No se permiten campos vacios");
            }

            if (descriptionTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(descriptionTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();
                string consult = "update categories set CategoryName='" + categoryNameTextBox.Text + "',Description= '" + descriptionTextBox.Text + "'where categoryName= '" + categoryNameTextBox.Text + "' ";
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
            errorProvider1.SetError(categoryNameTextBox, "");
            errorProvider1.SetError(descriptionTextBox, "");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cn.Open();
            string consu = "delete from Categories where CategoryName= '" + categoryNameTextBox.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            var atras = new menu();
            this.Hide();
            atras.Show();
        }
    }
}
