using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApp
{
    class DortIslem
    {
        static void Main(string[] args)
        {
            // işlem sırası: () , Power , Çarpma ve Bölme soldan sağa, Toplama ve Çıkarma soldan sağa.
            int firstNumber = 35;
            int secondNumber = 34;
            int plus = 35 + 34;
            int minus = 35 - 34;
            int multiplication = 35 * 34;
            //int division = 35 / 34;
            //float division = 35f / 34;
            int mod = firstNumber % secondNumber;
            float divisionSecond = (float)firstNumber / secondNumber;
            int ex1 = 5 + 6 * 7; // 5+42 = 47
            int ex2 = (5 + 6) * 5; // 11 * 5 = 55

            Console.WriteLine(ex1);
            Console.WriteLine(ex2);
            Console.WriteLine("Plus " + plus + "\nMinus " + minus + "\nMultiplication " + multiplication + "\nDivision " + divisionSecond +"\nMod "+ mod);
            Console.ReadLine();




        }
    }
}
