using System;
using System.Collections.Generic;
namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database are you using?");
           var databaseType = Console.ReadLine();

            IDataAccess mydatabase = DataAccessFactory.GetDataAccessType(databaseType);

            mydatabase.LoadData();
            mydatabase.SaveData();




        }
    }
}
