using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // + işareti ile kelimeleri tek satırda birleştirebiliyoruz.
            string first = " Tuğçe";
            string second = " Unity Certified Instructor" + first;
            string third = " Unity Certified Instructor " + first + " " + "Karasürmeli";            
            Console.WriteLine(third);
            Console.ReadLine();




        }
    }
}
