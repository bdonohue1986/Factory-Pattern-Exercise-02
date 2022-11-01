using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Which Database would you like to access?");
                Console.WriteLine("Please enter List, SQL, Or Mongo. Only these will be accepted.");
                Console.WriteLine("You will be Promted twice for accuracy");
                string response = Console.ReadLine();
                IDataAccess type = DataAccessFactory.GetDataAccess(response);
                List<Product> products = type.LoadData();
                type.SaveData();
                Console.WriteLine();
                foreach (Product product in products) { Console.WriteLine($"Product - {product.Name} is Product price -{product.Price}"); }


            }
        }
    }
}
