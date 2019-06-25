using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Repair_Shop
{
    public partial class Main : Form
    {
        private Database database = new Database();
        private Methods methods = new Methods();

        public Main()
        {
            database.ConnectToDatabase(Data.server_name, Data.database_name, Data.username, Data.password);
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add_Car();
        }

        private void Set_Vin()
        {
            Car.Plate = "";
            Car.Vin = txtVIN.Text;
        }

        private void Set_Plate()
        {
            Car.Plate = txtPlate.Text;
            Car.Vin = "";
        }

        private void Add_Car()
        {
            if (methods.Check_Length(txtVIN.Text) == true)
            {
                Set_Vin();
                AddForm AddCarForm = new AddForm();
                this.Hide();
                AddCarForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter the VIN!", Text);
            }

        }

        private void BtnSearchVIN_Click(object sender, EventArgs e)
        {
            if (methods.Check_Length(txtVIN.Text) == true)
            {
                Set_Vin();
                DataForm SearchCarForm = new DataForm();
                this.Hide();
                SearchCarForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter the VIN!", Text);
            }
        }

        private void BtnSearchPlate_Click(object sender, EventArgs e)
        {
            if (methods.Check_Length(txtPlate.Text) == true)
            {
                Set_Plate();
                DataForm SearchCarForm = new DataForm();
                this.Hide();
                SearchCarForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter the Plate!", Text);
            }
        }

        private void TxtVIN_TextChanged(object sender, EventArgs e)
        {
            methods.Count_Length(label_CountVIN, txtVIN);
        }

        private void TxtVIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = methods.DigitLetterForVIN(e.KeyChar);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.ExitProgram(Text, e);
        }

        private void TxtPlateLength_TextChanged(object sender, EventArgs e)
        {
            methods.Count_Length(label_CountPlate, txtPlate);
        }

        private void TxtPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = methods.DigitLetterWithSpace(e.KeyChar);
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            EmailCreator email = new EmailCreator();
            this.Hide();
            email.ShowDialog();
        }
    }
}
