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
    public partial class crear_orden : Form
    {
        public crear_orden()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var atras = new menu();
            this.Hide();
            atras.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""^ textBox2.Text == "" ^ textBox3.Text == "" ^ textBox4.Text == "" ^ textBox5.Text == "" ^ textBox6.Text == "" ^ textBox7.Text == "" ^ textBox8.Text == "" ^ textBox9.Text == "" ^ textBox10.Text == "" ^ textBox11.Text == "" ^ textBox12.Text == "" ^ textBox13.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios");

            }
       
            else
            {
                MessageBox.Show("¡su orden fue guardada satisfactoriamente!");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""^textBox13.Text=="")
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                MessageBox.Show("su orden fue eliminada satisfactoriamente ");

            }
        }
    }
}
