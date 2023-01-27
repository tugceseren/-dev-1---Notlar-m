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
            // Izmir'de bomba yedim ve tanesi 5 liraydı ve hava sıcaklığı 25,5 dereceydi.
            string sehirIsmi = "İzmir";
            int fiyat=5;            
            float havaSicakligi=25.5f; // decimal m float f.
            
            Console.Write(sehirIsmi);                 
            Console.Write("\'de bomba yedim ve tanesi ");
            Console.Write(fiyat);
            Console.Write(" liraydı ve hava sıcaklığı ");
            Console.Write(havaSicakligi);
            Console.Write(" dereceydi");
            Console.ReadLine();


        }
    }
}
