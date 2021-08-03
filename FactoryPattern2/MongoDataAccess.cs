using System;
using System.Collections.Generic;
namespace FactoryPattern2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }

        public void LoadData()
        {
            Console.WriteLine("I am reading data from the Mongo database");
            var products = new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the Mongo database");
        }
    }
}
