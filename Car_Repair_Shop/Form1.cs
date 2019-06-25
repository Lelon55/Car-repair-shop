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
    public partial class Form1 : Form
    {
        private Database database = new Database();
        private Methods methods = new Methods();

        public Form1()
        {
            database.CheckNetworkConnection();
            InitializeComponent();
        }

        private void Change_Form()
        {
            if (database.OpenConnection() == true)
            {
                MessageBox.Show("Logged!", Text);
                Form Main = new Main();
                this.Hide();
                Main.ShowDialog();
            }
        }

        private void Set_Data()
        {
            Data.server_name = txtServerName.Text;
            Data.database_name = txtDatabaseName.Text;
            Data.username = txtLogin.Text;
            Data.password = txtPassword.Text;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (methods.Check_Length(txtServerName.Text) == true && methods.Check_Length(txtDatabaseName.Text) == true && methods.Check_Length(txtLogin.Text) == true && methods.Check_Length(txtPassword.Text) == true)
            {
                Set_Data();
                database.ConnectToDatabase(Data.server_name, Data.database_name, Data.username, Data.password);
                Change_Form();
            }
            else
            {
                MessageBox.Show("Something empty", Text);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.ExitProgram(Text, e);
        }
    }
}
