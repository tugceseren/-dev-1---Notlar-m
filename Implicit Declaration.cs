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
            var tam=true;
            var tam=10.1f;
            int tamSayi=0; //buradaki `Tamsayi` kelimesini Console.WriteLine kısmına `tamsayi` şeklinde yazarsak olmaz. Aynısnı yazmalıyız.
            decimal ondalik;
            string myName; //string tanimi. string kullanırken asd#,asd$ gibi işaretler, string,int,float gibi isimler kullanamayız. _asd gibi işaretler kullanılır.
            float ondalikUcBasamakliSayi; // Buna `camel case` denir.
            float OndalikSayi; // Buna `pascal case` denir.
            bool renkli; // değişkenlerimizin bilgisayarımızın memory`sinde kısa zamanlı tutulan şeylerdir. Kısa zaman sonra memoryden silinirler.Kolayca tanımlanır ve kullanılır ve silinirler.
            myName = "Tuğçe Seren";
            Console.WriteLine(myName);
            myName = "Karasürmeli";
            Console.WriteLine(myName);
            Console.WriteLine(tamSayi);
            Console.WriteLine(tam);
            Console.Write(tam);
            Console.ReadLine();


        }
    }
}
