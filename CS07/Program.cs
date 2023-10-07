using System;
using System.Diagnostics;

namespace CS07
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (khoi tao; dieu_kien; cap_nhat)
            //{
            //  ...Cau lenh trong khoi
            //}


            //In ra 10 lan Hello World!
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"i = {i}"); //dem so lan
                Console.WriteLine("Hello World!");
            }





            //In ra bang cuu chuong
            for (int i; i <= 10; i++)
            {
                Console.WriteLine($"3 x {i} = {3 * i}");
            }
            //HOAC
            //int i = 1;
            //for (;i <= 10; )
            //{
            //    Console.WriteLine($"3 x {i} = {3 * i}");
            //    i++;
            //}

            //HOAC
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine($"3 x {i} = {3 * i}");
            //    i++;
            //}

            //HOAC
            //do
            //{
            //    Console.WriteLine($"3 x {i} = {3 * i}");
            //    i++;
            //}
            //while (i <= 10)







            //break; continue;
            int i = 0;
            while (i < 1000)
            {
                Console.WriteLine(i);
                i++;
                //if ( i == 10)
                break; //gap break, while ket thuc ngay lap tuc
            }


            for (int i = 10; i <= 20; i++)
            {
                if ( i % 2 != 0) continue; //in so chan
                continue; //gap continue, lenh sau continue se bi bo qua va thuc hien luot lap tiep theo
                Console.WriteLine($"so i = {i}");
            }
        }
    }
}