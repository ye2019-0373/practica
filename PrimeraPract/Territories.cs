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
    public partial class Territories : Form
    {
        public Territories()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");

        public void full()
        {
            string consul = "select * from Territories ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            territoriesDataGridView.DataSource = dt;

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void territoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.territoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Territories_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet3.Region' Puede moverla o quitarla según sea necesario.
            this.regionTableAdapter1.Fill(this.northwindDataSet3.Region);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet1.Region' Puede moverla o quitarla según sea necesario.
            this.regionTableAdapter.Fill(this.northwindDataSet1.Region);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Territories' Puede moverla o quitarla según sea necesario.
            this.territoriesTableAdapter.Fill(this.northwindDataSet.Territories);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            borrar();
            Validar();

        }
        private bool Validar()
        {
            bool ok = true;

          

            if (territoryDescriptionTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(territoryDescriptionTextBox, "No se permiten campos vacios");
            }

            if (territoryIDTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboBox1, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();

                string cons = "insert into Territories(TerritoryID,TerritoryDescription,RegionID) Values ('" + territoryIDTextBox.Text + "','" + territoryDescriptionTextBox.Text + "','"+comboBox1.Text+"')";
                SqlCommand com = new SqlCommand(cons, cn);
                com.ExecuteNonQuery();
                MessageBox.Show("Cambios Guardados");
                full();
                cn.Close();
            }

            return ok;
        }

        public void borrar()
        {

            errorProvider1.SetError(territoryIDTextBox, "");
            errorProvider1.SetError(territoryDescriptionTextBox, "");
            errorProvider1.SetError(comboBox1, "");
        }


        private void button6_Click(object sender, EventArgs e)
        {
            cn.Open();
            string consu = "delete from territories where TerritoryID= '" + territoryIDTextBox.Text + "'";
            SqlCommand com = new SqlCommand(consu, cn);
            com.ExecuteNonQuery();
            MessageBox.Show("Eliminado Satisfactoriamente");
            full();
            cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            borrarv();
            Validacion();
        }
        private bool Validacion()
        {
            bool ok = true;
            if (territoryDescriptionTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(territoryDescriptionTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();
                string consult = "update territories set TerritoryID ='" + territoryIDTextBox.Text + "'";
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
            errorProvider1.SetError(territoryDescriptionTextBox, "");
        
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
