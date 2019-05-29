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
    public partial class EmailCreator : Form
    {
        private Database database = new Database();
        private Methods methods = new Methods();

        public EmailCreator()
        {
            database.ConnectToDatabase(Data.server_name, Data.database_name, Data.username, Data.password);
            InitializeComponent();
        }

        private void Auto_Load(string value)
        {
            string query = "SELECT id, email, spent_money FROM customers WHERE spent_money>='" + value + "'";
            MessageBox.Show("Over: " + value);
            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Add_Subject(dataReader["id"].ToString(), dataReader["email"].ToString(), dataReader["spent_money"].ToString());
                }
                dataReader.Close();
                database.CloseConnection();
            }
        }

        private void Add_Subject(string id, string email, string spent_money)
        {
            dataGridView1.Rows.Add(id, email, spent_money);
        }

        private void ComboBox_SendTo_TextChanged(object sender, EventArgs e)
        {
            ClearAllRows();
            Auto_Load(comboBox_SendTo.Text);
        }

        private void ClearAllRows()
        {
            dataGridView1.Rows.Clear();
        }

        private void CountMessageLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_MessageLength, txtMessage);
        }

        private void CountSubjectLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_SubjectLength, txtSubject);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            methods.Back(this);
        }

        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            if (methods.Check_Length(txtSubject.Text) == true && methods.Check_Length(txtMessage.Text) == true && dataGridView1.Rows.Count > 0)
            {
                for (int nr_row = 0; nr_row < dataGridView1.Rows.Count; nr_row++)
                {
                    EmailForm emailform = new EmailForm(txtSubject.Text, dataGridView1.Rows[nr_row].Cells["email"].Value.ToString(), txtMessage.Text);
                }
                MessageBox.Show("Send!", Text);
            }
            else
            {
                MessageBox.Show("Empty Subject or Message or no emails!", Text);
            }
        }      
    }
}
