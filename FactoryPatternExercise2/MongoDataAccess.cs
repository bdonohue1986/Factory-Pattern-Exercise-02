using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("Saving data to Mongo Database");
        }

        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Database");
            return new List<Product>()
            {
                new Product(){Name = "Computer", Price = 650.45},
                new Product(){Name = "Desk", Price = 199.87},
                new Product(){Name = "Power", Price = 250.28},
                new Product(){Name = "Pens", Price = 20.99},
                new Product(){Name = "NotePads", Price = 50},
            };


        }
    }
}
