using System;
using System.Collections.Generic;
namespace FactoryPattern2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
        }

        public void LoadData()
        {
            Console.WriteLine("I am reading data from the SQL database");
            var products = new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the SQL database");
        }
    }
}
