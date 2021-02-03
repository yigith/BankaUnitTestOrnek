using System;

namespace Banka
{
    class Program
    {
        // https://docs.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019
        static void Main(string[] args)
        {
            Hesap hesap1 = new Hesap("Can Halfeoğulları", 200);
            Console.WriteLine("Hesap Sahibi: " + hesap1.HesapSahibi);
            Console.WriteLine("Bakiye: {0:n2}TL", hesap1.Bakiye);
            Console.WriteLine("50TL para çekiliyor..");
            hesap1.ParaCek(50);
            Console.WriteLine("Bakiye: {0:n2}TL", hesap1.Bakiye);

            Console.ReadKey();
        }
    }
}
