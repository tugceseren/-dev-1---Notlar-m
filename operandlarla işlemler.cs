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
           // int division = 35 / 34;
            float division = 35f / 34;
            int mod = firstNumber % secondNumber;
            float divisionSecond = (float)firstNumber / secondNumber;

            int thirdNumber = firstNumber + 5; //40 olacak
            thirdNumber += 10;             //thirdNumber = secondNumber + 10; 50

            thirdNumber -= 10; //40
            thirdNumber *= 2; //40*2
            thirdNumber /= 5; //80/5

           int fourthNumber = 5;

           fourthNumber ++; //5+1
           fourthNumber --; //6-1
            ++fourthNumber; //5+1

           int ex1 = 5 + 6 * 7; // 5+42 47
           int ex2 = (5 + 6) * 5; // 11*5 55

           Console.WriteLine(fourthNumber);          
           Console.ReadLine();




        }
    }
}