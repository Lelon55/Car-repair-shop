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

        int Check_Cost(string cost);

        int Add_Spent_Money(int spent, int parts_cost, int labor_cost);
        int Substration_Spent_Money(int spent, int parts_cost, int labor_cost);

        void Insert_Customer_At_Database();
        void Update_Add_Customer_At_Database();
        void Update_Sub_Customer_At_Database();
        void Set_Add_Customer_At_Database(string email);
        void Set_Sub_Customer_At_Database(string email);
    }

    public class CustomerService : ICustomerService
    {
        private Database database = new Database();
        private bool _IsEmail;
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

        public int Check_Cost(string cost)    //if empty return 0
        {
            if (cost != "")
            {
                return Int32.Parse(cost);
            }
            else
            {
                return 0;
            }
        }

        public int Add_Spent_Money(int spent, int parts_cost, int labor_cost)
        {
            return spent + parts_cost + labor_cost;
        }

        public int Substration_Spent_Money(int spent, int parts_cost, int labor_cost)
        {
            return spent - parts_cost - labor_cost;
        }

        public void Insert_Customer_At_Database()
        {
            string query = "INSERT INTO customers (email, spent_money) VALUES ('" + Customer.Email + "', '" + Add_Spent_Money(0, Check_Cost(Car.PartCost), Check_Cost(Car.LaborCost)) + "')";
            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Close();
                database.CloseConnection();
            }
        }

        public void Update_Add_Customer_At_Database() //update add spent money
        {
            string Update_data = "UPDATE customers SET spent_money='" + Add_Spent_Money(spent_money, Check_Cost(Car.PartCost), Check_Cost(Car.LaborCost)) + "' WHERE email='" + Customer.Email + "'";

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

        public void Update_Sub_Customer_At_Database()//update substration spent money
        {
            string Update_data = "UPDATE customers SET spent_money='" + Substration_Spent_Money(spent_money, Check_Cost(Car.PartCost), Check_Cost(Car.LaborCost)) + "' WHERE email='" + Customer.Email + "'";

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

        public void Set_Add_Customer_At_Database(string email) // for AddForm
        {
            Check_Customer_At_Database(email); //call the method so that the conditional statement can work correctly

            if (_IsEmail == false) // false = new customer. Add new customer with spent money
            {
                Insert_Customer_At_Database();
            }
            else if (_IsEmail == true) // true = customer already in the database. Just Update Spent_money from new repair
            {
                Update_Add_Customer_At_Database();
            }
        }

        public void Set_Sub_Customer_At_Database(string email) // for DataForm when Delete repairID
        {
            Check_Customer_At_Database(email); //call the method so that the conditional statement can work correctly

            if (_IsEmail == false) // false 
            {
                //nothing
            }
            else if (_IsEmail == true) // true = customer already in the database. Just Update Spent_money from new repair
            {
                Update_Sub_Customer_At_Database();
            }
        }
    }
}
