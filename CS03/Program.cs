using System;
namespace CS03
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %
            // nhan chia truoc, cong tru sau
            int a = 1;
            int b = 2;
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);
            Console.WriteLine("a % b = {0}", a % b);


            //GAN
            //=
            //+= : cong them gia tri vao bien
            //-= : tru bot gia tri vao bien
            //*= : nhan gia tri vao bien
            ///= : chia gia tri vao bien
            ///%= : chia lay du
            /// ++ : them 1 don vi
            /// -- : bot 1 don vi
            int x;
            x = 10;
            x += 2;
            Console.WriteLine(x);

             // voi x++
            int z = 2 * x++;
            ////x = x + 1
            //2 * x
            Console.WriteLine(x);
            Console.WriteLine(z);


            //voi ++x
            int z = 2 * x++;
            //2 * x
            //x = x + 1
            Console.WriteLine(x);
            Console.WriteLine(z);

        }
    }
}