using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//Create a Class called Products with
//Productid, Product Name, Price. Accept 10 Products,
//sort them based on the price, and display the sorted Products

namespace Assignment04
{
    class Products
    {
        int ProductID;
        int ProductPrice;
        string ProductName;
        Dictionary<long, string> pro = new Dictionary<long, string>();
        public void Data()
        {
            Console.WriteLine("Enter The Product name along with its Price: ");
            for (int i = 0; i < 10; i++)
            {
                pro.Add(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            }
            Console.WriteLine("Products in the Dictionary: ");
            foreach(KeyValuePair<long, string> kvp in pro)
            {
                Console.WriteLine("Price: {0} Product NAme : {1} ", + kvp.Key, kvp.Value);
            }
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("Product details after Sorting:");
            foreach(KeyValuePair <long, string> sorted in pro.OrderBy(key => key.Value))
            {
                Console.WriteLine("Price: {0}  NAme : {1} ", + sorted.Key, sorted.Value);
            }
            Console.WriteLine();
            Console.WriteLine("========================================");

        }

        public static void Main()
        {
            Products products = new Products();
            products.Data();
        }

    }
}
