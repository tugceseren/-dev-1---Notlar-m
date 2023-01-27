namespace GoogleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // \t tab tuşu işlevini görüyor ve kelimeler arasında büyük boşluk bırakıyor.
            // \n kelimeleri alt satıra alıyor.
            // \"veya \' birinin sözünü iki tırnak içerisinde yazacağında  \"Hello World\" şeklinde yazılır.
            // \\ klasör oluşturulacağında iki tane \\ koyulur ve c:\\users\\tuğçe\\appdata şeklinde yazılır.
            // @ doğrudan gösterim @ işareti ile oluyor. @"c:\users\tuğçe\appdata" şeklinde yazılır.
            // \u unicode karakterlerden birini önüne getirir. Fontlar içinde kullanılır.
            Console.WriteLine("Hello\tWorld && Hello\nMr Onur && \"Hello World\" && c:\\users\\tuğçe\\appdata");
            Console.ReadLine();



        }
    }
}

