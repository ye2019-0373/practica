using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraPract
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void lordenes_Click(object sender, EventArgs e)
        {
            Lista_de_ordenes fm = new Lista_de_ordenes { };
            this.Hide();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crear_orden fm = new crear_orden { };
            this.Hide();
            fm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            Suppliers fm = new Suppliers { };
            this.Hide();
            fm.Show();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            Employees fm = new Employees { };
            this.Hide();
            fm.Show();
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            Orders fm = new Orders { };
            this.Hide();
            fm.Show();
        }

        private void Shippers_Click(object sender, EventArgs e)
        {
            Shippers fm = new Shippers { };
            this.Hide();
            fm.Show();
        }

        private void Region_Click(object sender, EventArgs e)
        {
            Region fm = new Region { };
            this.Hide();
            fm.Show();

        }

        private void Territories_Click(object sender, EventArgs e)
        {
            Territories fm = new Territories { };
            this.Hide();
            fm.Show();
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            Categories fm = new Categories { };
            this.Hide();
            fm.Show();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            Products fm = new Products { };
            this.Hide();
            fm.Show();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            Customers fm = new Customers { };
            this.Hide();
            fm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
