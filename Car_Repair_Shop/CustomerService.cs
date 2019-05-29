using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Car_Repair_Shop
{
    public interface ICustomerService
    {
        void Check_Customer_At_Database(string email);
        bool Check_Email_At_Database(string email);

        int Add_Spent_Money(int spent, string parts_cost, string labor_cost);

        void Insert_Customer_At_Database();
        void Update_Customer_At_Database();
        void Set_Customer_At_Database(string email);
    }

    public class CustomerService : ICustomerService
    {
        private Database database = new Database();
        private bool _IsEmail;
        private string[] Array_Email;
        private int spent_money;

        public void Check_Customer_At_Database(string email) //check if the email is saved in the database
        {
            database.ConnectToDatabase(Data.server_name, Data.database_name, Data.username, Data.password);

            string query = "SELECT * FROM customers WHERE email='" + email + "'";
            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    _IsEmail = Check_Email_At_Database(dataReader["email"].ToString()); // email = returned value from Check_Email_At_Database
                    spent_money = (int)dataReader["spent_money"];
                }
                dataReader.Close();
                database.CloseConnection();
            }
        }

        public bool Check_Email_At_Database(string email)
        {
            return email != "";
        }

        public int Add_Spent_Money(int spent, string parts_cost, string labor_cost)
        {
            return spent + Int32.Parse(parts_cost) + Int32.Parse(labor_cost);
        }

        public void Insert_Customer_At_Database()
        {
            string query = "INSERT INTO customers (email, spent_money) VALUES ('" + Customer.Email + "', '" + Add_Spent_Money(0, Car.PartCost, Car.LaborCost) + "')";
            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Close();
                database.CloseConnection();
            }
        }

        public void Update_Customer_At_Database() //update spent money
        {
            string Update_data = "UPDATE customers SET spent_money=(SELECT SUM(labor_cost + parts_cost) FROM car_repair WHERE email='" + Customer.Email + "') WHERE email='" + Customer.Email + "'";
            OpenConnection_Update(Update_data);
        }

        public void Update_All_Customer()//po zmianie emaila w dataform i klieknieciu update dokonuje aktualizacji dla wszystkich
        {

            //wczytaj SELECT wszystkie maila z bazy danych (car_repair) (tworz tabele z nimi)
            //z tej tabeli przeszukaj maila po mailu w car_repair i sumuj jego wydatki
            // wpisz w customers dana sume danego maila, brak maila z car_repiar w customers daj Rowne 0

            //1
            /*string[] email = new string[] { };

            string query = "SELECT email FROM customers";
            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    
                }
                dataReader.Close();
                database.CloseConnection();
            }
            */
            /*string Update_data = "UPDATE customers SET spent_money=(SELECT SUM(labor_cost + parts_cost) FROM car_repair WHERE email='" + query + "') WHERE email=''";
            OpenConnection_Update(Update_data);*/
        }

        public void OpenConnection_Update(string query)
        {
            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.connection);
                cmd.CommandText = query;
                cmd.Connection = database.connection;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                database.CloseConnection();
            }
        }

        public void Set_Customer_At_Database(string email) // for AddForm
        {
            Check_Customer_At_Database(email); //call the method so that the conditional statement can work correctly
            if (_IsEmail == false) // false = new customer. Add new customer with spent money
            {
                Insert_Customer_At_Database();
            }
            else if (_IsEmail == true) // true = customer already in the database. Just Update Spent_money from new repair
            {
                Update_Customer_At_Database();
            }
        }
    }
}
