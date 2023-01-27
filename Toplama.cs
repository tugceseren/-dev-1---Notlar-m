using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApp
{
    class Toplama
    {
        static void Main(string[] args)
        {
            // 
            int first = 35;
            int second = 34;
            //string third = " Unity Certified Instructor " + first + " " + "Karasürmeli";
            //string four = $"{first} {second} elle yazi yaziyorum";
            //string five = $@"C:\users\Tuğçe\{second}\veri";
            Console.WriteLine(first + second);
            Console.WriteLine(first + second + 10);
            Console.WriteLine(first +"bir string"+ second);  
            Console.WriteLine((first+10) + "bir string" + second +10); // 35+34
            Console.ReadLine();




        }
    }
}