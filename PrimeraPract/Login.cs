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
using System.Data.SqlTypes;

namespace PrimeraPract
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void llogin_Click(object sender, EventArgs e)
        {
            borrar();
            vali();
        }

        private bool vali()
        {
            bool ok = true;
            if (textBox1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1, "Este campo es Obligatorio");
            }
            if (textBox2.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox2, "Este campo es Obligatorio");
            }
            else
            {
                var men = new menu();
                this.Hide();
                men.Show();
            }
            return ok;

        }

        private void borrar ()
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, "");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
