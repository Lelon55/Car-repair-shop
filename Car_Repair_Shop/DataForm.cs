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
    public partial class DataForm : Form
    {
        private Database database = new Database();
        private Methods methods = new Methods();
        private PdfAddForm pdfgenerate = new PdfAddForm();
        private int search; //0 vin, 1 plate

        private string choosen_cell = "";

        public DataForm()
        {
            database.ConnectToDatabase(Data.server_name, Data.database_name, Data.username, Data.password);
            InitializeComponent();
            dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(WriteChar);
        }

        internal void Back()
        {
            Form Main = new Main();
            this.Hide();
            Main.ShowDialog();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {

            if (Car.Vin.Length > 0)
            {
                label_SearchText.Text = "VIN: " + Car.Vin;
                search = 0;
                Auto_Load();
            }
            else
            {
                label_SearchText.Text = "Plate: " + Car.Plate;
                search = 1;
                Auto_Load();
            }
        }

        private string Select_Query(int value) //if 1 = nr rej, if 0 = vin
        {
            if (value == 0)
            {
                return "SELECT * FROM car_repair WHERE vin='" + Car.Vin + "'";
            }
            return "SELECT * FROM car_repair WHERE plate='" + Car.Plate + "'";
        }

        private void Auto_Load()
        {
            string query = Select_Query(search);

            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Add_Subject(dataReader["id"].ToString(), dataReader["vin"].ToString(), dataReader["plate"].ToString(), dataReader["brand"].ToString(), dataReader["model"].ToString(), dataReader["year_production"].ToString(), dataReader["todo"].ToString(), dataReader["repaired"].ToString(), dataReader["parts_cost"].ToString(), dataReader["labor_cost"].ToString(), dataReader["mileage"].ToString(), dataReader["acceptance"].ToString(), dataReader["devotion"].ToString(), dataReader["comment"].ToString(), dataReader["email"].ToString());
                }
                dataReader.Close();
                database.CloseConnection();
            }
        }

        private void Add_Subject(string id, string vin, string plate, string brand, string model, string year_production, string todo, string repaired, string parts_cost, string labor_cost, string mileage, string acceptance, string devotion, string comment, string email)
        {
            dataGridView1.Rows.Add(id, vin, plate, brand, model, year_production, todo, repaired, parts_cost, labor_cost, mileage, acceptance, devotion, comment, email);
        }

        private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Komunikat = MessageBox.Show("Are you sure to exit?", Text, MessageBoxButtons.YesNo);
            if (Komunikat == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else if (Komunikat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void SaveAutoData(int nr_row)
        {
            Car.Vin = dataGridView1.Rows[nr_row].Cells["vin"].Value.ToString();

            Car.Plate = dataGridView1.Rows[nr_row].Cells["plate"].Value.ToString();
            Car.Brand = dataGridView1.Rows[nr_row].Cells["brand"].Value.ToString();
            Car.Model = dataGridView1.Rows[nr_row].Cells["model"].Value.ToString();
            Car.Mileage = dataGridView1.Rows[nr_row].Cells["mileage"].Value.ToString();
            Car.YearProduction = dataGridView1.Rows[nr_row].Cells["year_production"].Value.ToString();

            Car.DateAcceptance = dataGridView1.Rows[nr_row].Cells["acceptance"].Value.ToString();
            Car.DateDevotion = dataGridView1.Rows[nr_row].Cells["devotion"].Value.ToString();

            Car.LaborCost = dataGridView1.Rows[nr_row].Cells["labor_cost"].Value.ToString();
            Car.PartCost = dataGridView1.Rows[nr_row].Cells["parts_cost"].Value.ToString();

            Car.ToDo = dataGridView1.Rows[nr_row].Cells["todo"].Value.ToString();
            Car.Repaired = dataGridView1.Rows[nr_row].Cells["repaired"].Value.ToString();
            Car.Comment = dataGridView1.Rows[nr_row].Cells["comment"].Value.ToString();
        }

        private void SaveCustomerData(int nr_row)
        {
            Customer.Email = dataGridView1.Rows[nr_row].Cells["email"].Value.ToString();
        }

        private string SetData(int nr_row, string value_text)
        {
            return dataGridView1.Rows[nr_row].Cells[value_text].Value.ToString();
        }

        private void OptionsData_ButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            int nr_row = e.RowIndex;

            if (e.ColumnIndex == dataGridView1.Columns["generate_pdf"].Index && nr_row >= 0)
            {
                SaveAutoData(nr_row);
                SaveCustomerData(nr_row);
                pdfgenerate.Generate_PdfAddForm();
                Back();
            }

            if (e.ColumnIndex == dataGridView1.Columns["delete_record"].Index && nr_row >= 0)
            {
                string ID_data = dataGridView1.Rows[nr_row].Cells["id"].Value.ToString();
                if (MessageBox.Show("Are you sure to Delete ID: " + ID_data + "?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string Delete_data = "DELETE FROM car_repair WHERE id ='" + ID_data + "'";
                    MessageBox.Show("Deleted data ID: " + ID_data, Text);

                    if (database.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(Delete_data, database.connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        dataReader.Close();
                        database.CloseConnection();
                    }
                    Back();
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["update"].Index && nr_row >= 0)
            {
                string ID_data = dataGridView1.Rows[nr_row].Cells["id"].Value.ToString();
                if (MessageBox.Show("Are you sure to Update ID: " + ID_data + "?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string Update_data = "UPDATE car_repair SET vin='" + SetData(nr_row, "vin") + "', plate='" + SetData(nr_row, "plate") + "', brand='" + SetData(nr_row, "brand") + "', model='" + SetData(nr_row, "model") + "', year_production='" + SetData(nr_row, "year_production") + "', todo='" + SetData(nr_row, "todo") + "', repaired='" + SetData(nr_row, "repaired") + "', parts_cost='" + SetData(nr_row, "parts_cost") + "', labor_cost='" + SetData(nr_row, "labor_cost") + "', mileage='" + SetData(nr_row, "mileage") + "', acceptance='" + SetData(nr_row, "acceptance") + "', devotion='" + SetData(nr_row, "devotion") + "', comment='" + SetData(nr_row, "comment") + "' WHERE id='" + ID_data + "'";
                    MessageBox.Show("Updated data ID: " + ID_data, Text);

                    if (database.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(Update_data, database.connection);
                        cmd.CommandText = Update_data;
                        cmd.Connection = database.connection;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        database.CloseConnection();
                    }
                    Back();
                }
            }

        }

        private void WriteChar(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(DataGridViewKeyPress);
        }

        private void DataGridViewKeyPress(object sender, KeyPressEventArgs e)
        {
            if (choosen_cell == "vin")
            {
                e.Handled = methods.DigitLetterForVIN(e.KeyChar);
            }
            else if (choosen_cell == "plate" || choosen_cell == "brand" || choosen_cell == "model")
            {
                e.Handled = methods.DigitLetterWithSpace(e.KeyChar);
            }
            else if (choosen_cell == "year_production" || choosen_cell == "labor_cost" || choosen_cell == "parts_cost" || choosen_cell == "mileage")
            {
                e.Handled = methods.JustDigit(e.KeyChar);
            }
            else if (choosen_cell == "todo" || choosen_cell == "rapeired" || choosen_cell == "acceptance" || choosen_cell == "devotion" || choosen_cell == "comment")
            {
                e.Handled = false;
            }
            else if (choosen_cell == "id")
            {
                e.Handled = true;
            }
        }

        private void ChooseColumns(object sender, DataGridViewCellCancelEventArgs e)
        {
            choosen_cell = dataGridView1.Columns[e.ColumnIndex].Name;
        }

        private void TextToUpper(object sender, DataGridViewCellEventArgs e)
        {
            if (choosen_cell == "vin" || choosen_cell == "plate")
            {
                string NewValue = dataGridView1.Rows[e.RowIndex].Cells[choosen_cell].Value.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[choosen_cell].Value = NewValue.ToUpper();
            }
        }
    }
}
