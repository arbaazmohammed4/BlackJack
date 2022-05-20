using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class shuffle
    {
        public string Shuffle()
        {
            List<string> list1 = new List<string>()
            {
                "Ace", "2" ,"3","4","5","6","7","8","9","10","Jack","Queen","King"
            };

            Random rnd = new Random();

            int index = rnd.Next(list1.Count);

            return list1[index];
            

        }

        public int convertToInt(string s)
        {
                int returnValue;
                switch (s)
                {
                    case "Ace":
                        returnValue = 11;
                        break;
                    case "King":
                    case "Queen":
                    case "Jack":
                    case "10":
                        returnValue = 10;
                        break;
                    case "9":
                        returnValue = 9;
                        break;
                    case "8":
                        returnValue = 8;
                        break;
                    case "7":
                        returnValue = 7;
                        break;
                    case "6":
                        returnValue = 6;
                        break;
                    case "5":
                        returnValue = 5;
                        break;
                    case "4":
                        returnValue = 4;
                        break;
                    case "3":
                        returnValue = 3;
                        break;
                    case "2":
                        returnValue = 2;
                        break;
                    default:
                        returnValue = 0;
                        break;
                }
                return returnValue;
        }

        public int HitMethod()
        {
            Random r = new Random();
            int Cardvalue = r.Next(1,11);
            return Cardvalue;
        }
   


    }
}
