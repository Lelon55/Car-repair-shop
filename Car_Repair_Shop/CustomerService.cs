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
        void Check_Customer_At_Database();
        bool Check_Email_At_Database(string email);

        int Add_Spent_Money(int spent, string parts_cost, string labor_cost);

        void Insert_Customer_At_Database();
        void Update_Customer_At_Database();
        void Set_Customer_At_Database();
    }

    public class CustomerService : ICustomerService
    {
        private Database database = new Database();
        private bool email;
        private int spent_money;

        public void Check_Customer_At_Database() //check if the email is saved in the database
        {
            database.ConnectToDatabase(Data.server_name, Data.database_name, Data.username, Data.password);

            string query = "SELECT * FROM customers WHERE email='" + Customer.Email + "'";

            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    email = Check_Email_At_Database(dataReader["email"].ToString()); // email = returned value from Check_Email_At_Database
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
            int part_cost = Int32.Parse(parts_cost);
            int labors_cost = Int32.Parse(labor_cost);
            return spent + part_cost + labors_cost;
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

        public void Update_Customer_At_Database()
        {
            string Update_data = "UPDATE customers SET spent_money='" + Add_Spent_Money(spent_money, Car.PartCost, Car.LaborCost) + "' WHERE email='" + Customer.Email + "'";

            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(Update_data, database.connection);
                cmd.CommandText = Update_data;
                cmd.Connection = database.connection;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                database.CloseConnection();
            }
        }

        public void Set_Customer_At_Database()
        {
            Check_Customer_At_Database(); //call the method so that the conditional statement can work correctly

            if (email == false) // false = new customer. Add new customer with spent money
            {
                Insert_Customer_At_Database();
            }
            else if (email == true) // true = customer already in the database. Just Update Spent_money from new repair
            {
                Update_Customer_At_Database();
            }
        }


    }
}
