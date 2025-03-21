namespace AcunMedyaOdev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Marka bmw = new Marka("BMW");
            Kapi dortKapi = new Kapi(4);
            Pencere dortPencere = new Pencere(4);
            Kasa sedan = new Kasa("sedan");

            Araba bmwX5 = new Araba(bmw, "X5", dortKapi, dortPencere, sedan, 2000000);
            bmwX5.BilgileriYazdir();

            Matematik matematik = new Matematik();

            Console.WriteLine("Toplama işlemleri:");
            Console.WriteLine(matematik.Topla(3, 5));
            Console.WriteLine(matematik.Topla(3, 5, 2));
            Console.WriteLine(matematik.Topla(2.5, 4.7));
            Console.WriteLine(matematik.Topla(2.5, 4.7, 1.3));

            Console.WriteLine("\nÇarpma işlemleri:");
            Console.WriteLine(matematik.Carp(3, 5));
            Console.WriteLine(matematik.Carp(3, 5, 2));
            Console.WriteLine(matematik.Carp(2.5, 4.7));
            Console.WriteLine(matematik.Carp(2.5, 4.7, 1.3));

        }
    }
}
