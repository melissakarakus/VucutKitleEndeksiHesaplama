using System;

namespace hhj
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double BMI, kilo, boy;
            Console.Write("Kilonuzu giriniz : ");
            kilo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Boyunuzu m cinsinden giriniz : ");
            boy = Convert.ToDouble(Console.ReadLine());


            BMI = kilo / (boy* boy);

            if(BMI >0 && BMI<= 18.4)
            {
                Console.WriteLine("Z A Y I F S I N I Z ");
            }
            else if(BMI>18.4 && BMI<24.9)
            {
                Console.WriteLine("N O R M A L");
            }
            else if (BMI>24.9 && BMI<=29.9)
            {
                Console.WriteLine("K İ L O L U S U N U Z");
            }
            else if (BMI>29.9 && BMI<=34.9)
            {
                Console.WriteLine("1. D E R E C E   O B E Z S İ N İ Z");
            }
            else if (BMI>34.9 && BMI<=44.9)
            {
                Console.WriteLine("2. D E R E C E   O B E Z S İ N İ Z");

            }
            else if(BMI>44.9)
            {
                Console.WriteLine("A Ş I R I   O B E Z S İ N İ Z");
            }
            else
            {
                Console.WriteLine("Tanımlanamayan bir hata oluştu, tekrar deneyin.");
            }



            
            Console.ReadKey();





        }
    }
}
