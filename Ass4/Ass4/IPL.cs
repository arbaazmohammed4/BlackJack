using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Cricket
    {
        public void Points_Collection(int n)
        {
           
            Console.WriteLine("Enter the Scores of the TEAM: ");
            int[] scores = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Score Of MATCH {i + 1} : ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            int sum = 0;
            float avg = 0f;
            for (int i = 0; i < n; i++)
            {
                sum = sum + scores[i];
            }
            Console.WriteLine("Sum Of the Scores IS: " + sum);
            avg = (float)sum / n;
            Console.WriteLine("Average of the Scores is: " + avg);


        }

        static void Main(string[] args)
        {
            Cricket cricket = new Cricket();
            Console.WriteLine("Enter the number of matches played in the IPL:");
            int n = Convert.ToInt32(Console.ReadLine());
            cricket.Points_Collection(n);
        }
    }
}
