using System;
using System.Collections.Generic;
namespace FactoryPattern2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
        }

        public void LoadData()
        {
            Console.WriteLine("I am reading data from the List database");
            var products = new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the List database");
        }
    }
}
