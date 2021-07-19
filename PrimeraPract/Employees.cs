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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");
        public void full()
        {
            string consul = "select * from Employees";
            SqlDataAdapter adap = new SqlDataAdapter(consul, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            employeesDataGridView.DataSource = dt;

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.EmployeeTerritories' Puede moverla o quitarla según sea necesario.
            this.employeeTerritoriesTableAdapter.Fill(this.northwindDataSet.EmployeeTerritories);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Employees' Puede moverla o quitarla según sea necesario.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

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
            if (lastNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(lastNameTextBox, "No se permiten campos vacios");
            }

            if (firstNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(firstNameTextBox, "No se permiten campos vacios");
            }

            if (titleTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(titleTextBox, "No se permiten campos vacios");
            }

            if (titleOfCourtesyTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(titleOfCourtesyTextBox, "No se permiten campos vacios");
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
            if (homePhoneTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(homePhoneTextBox, "No se permiten campos vacios");
            }

            if (extensionTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(extensionTextBox, "No se permiten campos vacios");
            }
           

            if (notesTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(notesTextBox, "No se permiten campos vacios");
            }
            if (reportsToTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(reportsToTextBox, "No se permiten campos vacios");
            }

            if (photoPathTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(photoPathTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();

                var cons = "insert into Employees (LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsTo,PhotoPath) Values ('"+lastNameTextBox.Text+"','"+firstNameTextBox.Text+"','"+titleTextBox.Text+"','"+titleOfCourtesyTextBox.Text+"','"+birthDateDateTimePicker.Value+"','"+hireDateDateTimePicker.Value+"','"+addressTextBox.Text+"','"+cityTextBox.Text+"','"+regionTextBox.Text+"','"+postalCodeTextBox.Text+"','"+countryTextBox.Text+"','"+homePhoneTextBox.Text+"',"+extensionTextBox.Text+",'"+notesTextBox.Text+"',"+Convert.ToInt32(reportsToTextBox.Text)+",'"+photoPathTextBox.Text+"')";
                SqlCommand com = new SqlCommand(cons, cn);
                com.ExecuteNonQuery();
                full();
                cn.Close();
            }
            return ok;

        }


        private void Borrarval()
        {
            
            errorProvider1.SetError(lastNameTextBox, "");
            errorProvider1.SetError(firstNameTextBox, "");
            errorProvider1.SetError(titleTextBox, "");
            errorProvider1.SetError(titleOfCourtesyTextBox, "");
            errorProvider1.SetError(addressTextBox, "");
            errorProvider1.SetError(cityTextBox, "");
            errorProvider1.SetError(regionTextBox, "");
            errorProvider1.SetError(postalCodeTextBox, "");
            errorProvider1.SetError(countryTextBox, "");
            errorProvider1.SetError(homePhoneTextBox, "");
            errorProvider1.SetError(extensionTextBox, "");
            errorProvider1.SetError(notesTextBox, "");
            errorProvider1.SetError(reportsToTextBox, "");
            errorProvider1.SetError(photoPathTextBox, "");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            borrar();
            valmodificar();
        }
        private bool valmodificar()
        {
            bool ok = true;
            if (lastNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(lastNameTextBox, "No se permiten campos vacios");
            }

            if (firstNameTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(firstNameTextBox, "No se permiten campos vacios");
            }

            if (titleTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(titleTextBox, "No se permiten campos vacios");
            }

            if (titleOfCourtesyTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(titleOfCourtesyTextBox, "No se permiten campos vacios");
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
            if (homePhoneTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(homePhoneTextBox, "No se permiten campos vacios");
            }

            if (extensionTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(extensionTextBox, "No se permiten campos vacios");
            }


            if (notesTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(notesTextBox, "No se permiten campos vacios");
            }
            if (reportsToTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(reportsToTextBox, "No se permiten campos vacios");
            }

            if (photoPathTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(photoPathTextBox, "No se permiten campos vacios");
            }
            else
            {
                cn.Open();
                string consult = "update Employees set LastName='" + lastNameTextBox.Text + "',FirstName='" + firstNameTextBox.Text + "',Title='" + titleTextBox.Text + "',TitleOfCourtesy='" + titleOfCourtesyTextBox.Text + "' ,BirthDate='" + birthDateDateTimePicker.Value + "', HireDate= '" + hireDateDateTimePicker.Value + "', Address='" + addressTextBox.Text + "', City='" + cityTextBox.Text + "',Region='" + regionTextBox.Text + "',PostalCode='" + postalCodeTextBox.Text + "',Country='" + countryTextBox.Text + "',HomePhone='" + homePhoneTextBox.Text + "',Extension='" + extensionTextBox.Text + "',Notes='" + notesTextBox.Text + "',ReportsTo='" + reportsToTextBox.Text + "', where LastName='"+lastNameTextBox.Text + "' ";
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
            errorProvider1.SetError(lastNameTextBox, "");
        }

    }
}
