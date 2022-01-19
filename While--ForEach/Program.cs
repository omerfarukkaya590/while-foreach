using System;

namespace While__ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1 den başlayarak console den girilen sayıya kadar (sayı dahil) oratalama hesaplayıp console a yazdıran program
            Console.Write("Lütfen bir sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac =1;
            int toplam =0;
            while (sayac<=sayi)
            {
                 toplam+= sayac;
                 sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //A dan Z ye kadar tüm harfleri yazdır
             char character= 'a';
            while (character<='z')
            {
                 Console.Write(character);
                 character++;
            }
            Console.WriteLine("*****ARABA MODELLERİ*****");

            String[] arabalar ={"BMW","FORD","AUDİ","HYUNDAİ"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine("araba");
            }
        }
    }
}
