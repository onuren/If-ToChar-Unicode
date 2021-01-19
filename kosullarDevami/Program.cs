using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosullarDevami
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcıdan alınan karakter büyük mü? Küçük mü?
            ////65-90 büyük karakter
            ////97-122 küçük karakter
            //Console.WriteLine("Karakter giriniz:");
            //char karakter = Convert.ToChar(Console.ReadLine());
            //int deger = Convert.ToInt32(karakter);
            //if (deger >= 65 && deger <= 90)
            //{
            //    Console.WriteLine("Karakter Büyük Harftir.");
            //}
            //else if (deger >= 97 && deger <= 122)
            //{
            //    Console.WriteLine("Karakter Küçük Harftir");
            //}
            //else
            //{
            //    Console.WriteLine("Sembol girdiniz.");
            //}
            #endregion


            #region karakter büyükse küçük, küçükse büyük halini yazdırın

            Console.WriteLine("Karakter giriniz:");
            char karakter = Convert.ToChar(Console.ReadLine());
            int deger = Convert.ToInt32(karakter);
            if (deger >= 65 && deger <= 90)
            {
                Console.WriteLine("Karakter Büyük Harftir.");
                deger += 32;
                char buyukhali = Convert.ToChar(deger);
                Console.WriteLine("Karakterin küçük hali:" + buyukhali);
            }
            else if (deger >= 97 && deger <= 122)
            {
                Console.WriteLine("Karakter Küçük Harftir");
                deger -= 32;
                char kucukhali = Convert.ToChar(deger);
                Console.WriteLine("Karakterin büyük hali:" + kucukhali);
            }
            else
            {
                Console.WriteLine("Sembol girdiniz.");
            }

            #endregion


        }
    }
}
