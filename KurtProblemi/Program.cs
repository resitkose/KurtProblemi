using System;

namespace KurtProblemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç Adet Kurt Var?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("==============================================================");
            int sayac;
            int buyuksayac = 0;
            Random rnd = new Random();
            int[] dizi = new int[n];
            Console.WriteLine();
            Console.WriteLine("Oluşturulan Dizi");
            Console.WriteLine();
            Console.WriteLine("==============================================================");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 6);
                Console.Write(dizi[i].ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==============================================================");
            int sayi1 = 0;
            for (int i = 1; i <= 5; i++)
            {
                sayac = 0;

                for (int j = 0; j < dizi.Length; j++)
                {
                    if (i == dizi[j])
                    {
                        sayac++;
                        if (sayac > buyuksayac)
                        {
                            buyuksayac = sayac;
                            sayi1 = dizi[j];
                        }
                    }
                }
                if (sayac != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(i + "  Sayısından  " + sayac + "  tane  ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("==============================================================");
            int min = dizi[0];
            if (buyuksayac != 0)
            {
                for (int k = 1; k < dizi.Length; k++)
                {
                    if (min > dizi[k])
                        min = dizi[k];
                }
                Console.WriteLine();
                Console.WriteLine("Dizi içindeki en çok tekrar eden sayılardan en küçük olan sayı :" + sayi1);
            }

            Console.ReadKey();
        }
    }
}
