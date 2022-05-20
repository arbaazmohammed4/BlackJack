using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



          //      Create a simple Stationery application to add
          //      items and display added items using Generic collections
namespace Assignment04
{
    class Stationary
    {
        public static void Main()

        {
            Console.WriteLine("                             'Welcome To Stationary Application'            ");
            Console.WriteLine();
            Console.WriteLine();
            Stationary s = new Stationary();
            List<string> ls = new List<string>();
            Console.WriteLine("Items available in the Stationary: ");

            ls.Add("Pen");
            ls.Add("King Size Book");
            ls.Add("Pencil");
            ls.Add("Geometry Set");
            foreach (var item in ls)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("If you want to Add New Item in Stationary Press: 1 or press any number to display Items Available ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            
            if(n == 1)
            {
               Console.WriteLine("Enter Item Which you want to Add to Stationary :");
               string newitem = Console.ReadLine();
               ls.Insert(0, newitem);
               Console.WriteLine("Item Added Successfully");
            }
                
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("Item List");
            
            foreach (var item in ls)
            {

                Console.WriteLine(item);
            }



        }
        
       
    }
}
// out put
//'Welcome To Stationary Application'


//Items available in the Stationary:
//Pen
//King Size Book
//Pencil
//Geometry Set
//If you want to Add New Item in Stationary Press: 1 or press any number to display Items Available
//1
//Enter Item Which you want to Add to Stationary :
//Text Book
//Item Added Successfully

//=================================
//Item List
//Text Book
//Pen
//King Size Book
//Pencil
//Geometry Set