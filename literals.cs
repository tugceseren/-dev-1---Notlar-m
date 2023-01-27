using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApp
{
    class Program
    {
        private static string d; // içine birden fazla karakter alabilen
        private static bool c; // true || false
        private static int a; //private int başka bir classtan erişilemez bir değişken. //public ise başka classlardan çağırılabilen, erişilebilen bir değişken. 
        private static float b; 
        static void Main(string[] args)
        {
            d = "more than characters";
            c = true;
            b = 1.1f; // f (floatin value) ondalikli sayiyi tanimlar.
            a = 1; //2 3 4 100 istediğimize eşitleyebiliriz.
            Console.WriteLine(346); //writeline kismina hangi rakami girmişsek onun çıktısını verir.
            Console.WriteLine(a); //a yi neye eşitlemişsek onun çıktısını verir. Bu da sayılar olarak kullanılır ve matematik işleminde görülür.
            Console.WriteLine("1"); // bu literal value`u  bir string yani karakterler silsilesi olarak algılayabiliyor. Matematiksel işlemde kullanılmaz.
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(false);
            Console.WriteLine(d);
            Console.WriteLine(4.0m); // bu -m- suffix`i (son ek) ister küçük ister büyük harf ile yazabiliriz.
            Console.ReadLine();
            

        }
    }
}