namespace GoogleApp
{
#pragma warning disable CS0101 // 'GoogleApp' ad alanı 'Program' için zaten bir tanım içeriyor
    class Program
#pragma warning restore CS0101 // 'GoogleApp' ad alanı 'Program' için zaten bir tanım içeriyor
    {
#pragma warning disable CS0111 // 'Program' türü aynı parametre türleriyle 'Main' adlı bir üyeyi zaten tanımlıyor
        static void Main(string[] args)
#pragma warning restore CS0111 // 'Program' türü aynı parametre türleriyle 'Main' adlı bir üyeyi zaten tanımlıyor
        {
            // + işareti ile kelimeleri tek satırda birleştirebiliyoruz.
            string first = " Tuğçe";
            string second = " Unity Certified Instructor" + first;
            string third = " Unity Certified Instructor " + first + " " + "Karasürmeli";
            string four = $"{first} {second} elle yazi yaziyorum";
            string five = $@"C:\users\Tuğçe\{second}\veri";
            Console.WriteLine(five);
            Console.ReadLine();




        }
    }
}