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
    public partial class Region : Form
    {
        public Region()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");

        public void full()
        {
            string consul = "select * from Region ";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            regionDataGridView.DataSource = dt;

        }

        private void regionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.regionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Region_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Region' Puede moverla o quitarla según sea necesario.
            this.regionTableAdapter.Fill(this.northwindDataSet.Region);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            borrar();
            Validar();
           
           
           
        }
        private bool Validar()
        {
            bool ok = true;
            if (regionDescriptionTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(regionDescriptionTextBox, "No se permiten campos vacios");
            }
           
            else
            {
                cn.Open();

                string cons = "insert into Region (RegionID, RegionDescription) Values ("+regionIDTextBox.Text+",'" + regionDescriptionTextBox.Text + "' )";
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
            errorProvider1.SetError(regionDescriptionTextBox, "");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }
  

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
