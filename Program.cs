﻿namespace AtYarisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //birden fazla at var
            //bu atlar mesafe kat ediyorlar
            //bu atlardan hangisi ilk olarak bitişi geçerse (bulunduğu mesafe >= bitişin mesafesi) o at kazanıyor
            //eğer kişi doğru tahmin ederse hangi atın kazandığını, kişi oyunu kazanır, yoksa kaybeder

            //at1 -> 5, 8 -> 7 turda bu at 100m'ye gelirken
            //at2 -> 3, 13 -> 6 turda gelecek

            int at1 = 0, at2 = 0; //at1 ve at2'nin mesafeleri
            int bitisZamani = 80; //bitiş çizgisinin mesafesi

            Random rnd = new Random();

            for (int i = 1; i <= bitisZamani; i++)
            {
                int at1Mesafe = rnd.Next(11);
                at1 += at1Mesafe; //at1 = at1 + at1Mesafe;

                int at2Mesafe = rnd.Next(11);
                at2 += at2Mesafe; //at2 = at2 + at2Mesafe;

                //Console.WriteLine(i + ". turda At1'in mesafesi: " + at1 + ", At2'nin mesafesi: " + at2);
                //Console.WriteLine("At1'in gittiği mesafe: " + at1Mesafe + ", At2'nin gittiği mesafe: " + at2Mesafe);
            }

            if (at1 > at2)
                Console.WriteLine("At1 kazanmıştır. At1: " + at1 + " At2: " + at2);
            else if (at1 == at2)
                Console.WriteLine("Berabere");
            else
                Console.WriteLine("At2 kazanmıştır. At1: " + at1 + " At2: " + at2);

            Console.Read();
        }

        //tek boyutlu çarpım tablosu: 15
        //15*1 = 15, 15*2= 30

        //1*1 = 1, 1*2 = 2
        //2*1 = 2, 2*2 = 4
        //10*1 = 10, 10*2 = 20

        /*
         *
        * *
       *   *
      *     *

         *
         **
        ***
        ****

        *
        **
        ***
        ****
     */
    }
}