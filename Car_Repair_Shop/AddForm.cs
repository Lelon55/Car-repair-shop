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
    public partial class AddForm : Form
    {
        private Database database = new Database();
        private Methods methods = new Methods();
        private PdfAddForm pdfgenerate = new PdfAddForm();
        private CustomerService customer_service = new CustomerService();

        public AddForm()
        {
            database.ConnectToDatabase(Data.server_name, Data.database_name, Data.username, Data.password);
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            methods.Back(this);
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            label_VIN.Text = "VIN: " + Car.Vin;
            dateAcceptanceCar.Text = DateTime.Today.ToString();
            dateDevotionCar.Text = dateAcceptanceCar.Text;
        }

        private void Add_Car_To_Database()
        {
            string query = "INSERT INTO car_repair (vin, plate, brand, model, year_production, todo, repaired, parts_cost, labor_cost, mileage, acceptance, devotion, comment, email) VALUES ('" + Car.Vin + "', '" + txtPlate.Text + "', '" + txtBrandCar.Text + "', '" + txtModelCar.Text + "', '" + txtYearProduction.Text + "', '" + txtToDo.Text + "', '" + txtRepaired.Text + "','" + txtPartCost.Text + "', '" + txtLaborCost.Text + "', '" + txtMileage.Text + "', '" + dateAcceptanceCar.Text + "','" + dateDevotionCar.Text + "', '" + txtComment.Text + "', '" + txtEmail.Text + "' )";
            if (database.OpenConnection() == true)
            {
                MessageBox.Show("Added data for VIN: " + Car.Vin, Text);
                MySqlCommand cmd = new MySqlCommand(query, database.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Close();
                database.CloseConnection();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SaveAutoData();
            SaveCustomerData();
            Add_Car_To_Database();
            customer_service.Set_Customer_At_Database(Customer.Email);
            methods.Back(this);
        }

        private void DateCompare(DateTime dt1, DateTime dt2)
        {
            if (dt2 < dt1)
            {
                dateDevotionCar.Value = dateAcceptanceCar.Value;
                MessageBox.Show("Date Devotion can't be earlier than Date Acceptance!", Text);
            }
        }

        #region CountLength
        private void CountToDoLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_ToDoLength, txtToDo);
        }
        private void CountCommentLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_CommentCount, txtComment);
        }

        private void CountPartCostLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_PartCostLength, txtPartCost);
        }

        private void CountLaborCostLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_LaborCostLength, txtLaborCost);
        }

        private void CountModelCarLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_ModelCarLength, txtModelCar);
        }

        private void CountYearProductionLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_YearProductionLength, txtYearProduction);
        }

        private void CountPlateLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_PlateLength, txtPlate);
        }

        private void CountMileageLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_MileageStatusLength, txtMileage);
        }

        private void CountRepairedLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_RepairedLength, txtRepaired);
        }

        private void CountBrandLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_BrandLength, txtBrandCar);
        }
        private void CountEmailLength(object sender, EventArgs e)
        {
            methods.Count_Length(label_EmailLength, txtEmail);
        }
        #endregion

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.ExitProgram(Text, e);
        }

        private void BtnGeneratePDF_Click(object sender, EventArgs e)
        {
            SaveAutoData();
            SaveCustomerData();
            Add_Car_To_Database();
            customer_service.Set_Customer_At_Database(Customer.Email);
            pdfgenerate.Generate_PdfAddForm();
            methods.Back(this);
        }

        private void SaveAutoData()
        {
            Car.Plate = txtPlate.Text;
            Car.Brand = txtBrandCar.Text;
            Car.Model = txtModelCar.Text;
            Car.Mileage = txtMileage.Text;
            Car.YearProduction = txtYearProduction.Text;

            Car.DateAcceptance = dateAcceptanceCar.Text;
            Car.DateDevotion = dateDevotionCar.Text;

            Car.LaborCost = methods.Check_Cost(txtLaborCost.Text);
            Car.PartCost = methods.Check_Cost(txtPartCost.Text);

            Car.ToDo = txtToDo.Text;
            Car.Repaired = txtRepaired.Text;
            Car.Comment = txtComment.Text;
        }

        private void SaveCustomerData()
        {
            Customer.Email = txtEmail.Text;
        }

        private void TxtDigitLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = methods.DigitLetterWithSpace(e.KeyChar);
        }

        private void TxtDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = methods.JustDigit(e.KeyChar);
        }

        private void CheckDates(object sender, EventArgs e)
        {
            DateCompare(dateAcceptanceCar.Value, dateDevotionCar.Value);
        }

        private void SetDateDevotion(object sender, EventArgs e)
        {
            dateDevotionCar.Value = dateAcceptanceCar.Value;
        }
    }
}
