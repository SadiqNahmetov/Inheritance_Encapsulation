using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Factor factor = new Factor();

            //     int result = factor.Fact(3);

            //    Console.WriteLine(result);

            //Gmail gmail = new Gmail();

            //int giris_sayisi = gmail.Email(3);
            //string emails = gmail.Email("sadigfn@code.edu.az");
            //string S12345 = null;
            //string password = gmail.Email(S12345);




            int giris_sayisi = 3;
            string emails = "sadigfn@code.edu.az";
            string password = "S12345";

            while (true)
            {
                Console.WriteLine("Zehmet olmazsa gmailnizi daxil edin");
                string istifadeciAdi = Console.ReadLine();

                Console.WriteLine("Sifrenizi daxil edin");
                string sifre = Console.ReadLine();

                if (istifadeciAdi == "sadigfn@code.edu.az" && sifre == "S12345")
                {
                    Console.WriteLine("Tebrikler Giris Edildi");
                    break;
                }
                else
                {
                    Console.WriteLine("Gmail  veya sifreniz duzgun deyil");

                    if (giris_sayisi > 0)
                    {
                        giris_sayisi -= 1;
                    }
                    if (giris_sayisi == 0)
                    {
                        Console.WriteLine("Giris sayiniz doldu! girisede bilmesiniz");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    
    }
}
