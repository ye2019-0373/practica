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
    public partial class Lista_de_ordenes : Form
    {

        public Lista_de_ordenes()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            if (Buscar.Text=="")
            {

                MessageBox.Show("No se permiten campos vacios");
                (Buscar).Clear();

            }
            else
            {
                string mostrar = "select*from Orders where CustomerID='"+Buscar.Text+"'";
                SqlCommand cm = new SqlCommand(mostrar,cn);
                SqlDataAdapter dat = new SqlDataAdapter(cm);
                DataTable tab = new DataTable();
                dat.Fill(tab);

                dataGridView1.DataSource = tab;
                (Buscar).Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var atras = new menu();
            this.Hide();
            atras.Show();
        }
    }
}
