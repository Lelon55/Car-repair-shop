using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Repair_Shop
{
    public class Data
    {
        internal static string server_name, database_name, username, password;
    }

    public class Car
    {
        #region Car
        internal static string Vin, Plate;

        internal static string Brand, Model, YearProduction, Mileage;
        internal static string DateAcceptance, DateDevotion;
        internal static string PartCost, LaborCost;

        internal static string ToDo, Repaired, Comment;

        #endregion
    }

    public class Customer
    {
        internal static string Email;
        //internal static int Spent_money;
    }
}
