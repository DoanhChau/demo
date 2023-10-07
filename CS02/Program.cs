using System;

namespace CS02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kieu_du_lieu Ten_bien;
            //Ten_bien:
            //    - a...z A...Z
            //    - 0...9
            //    -_
            //    -Khong bat dau bang so
            string studentName = "Nguyen Van A";
            int studentAge;



            char a; /*ky tu*/
            bool b; /*true/false*/

            float c;
            c = 12.12f; /*hoac c = (float)12.12; hoac double c; */

            object d;
            d = studentName; /*phai gan gia tri truoc do cho doi tuong*/



            double so_pi;
            so_pi = 3.14;
            double hai_pi;
            hai_pi = 2 * so_pi;
            Console.WriteLine(hai_pi);


            string hovaten;
            Console.Write("Ho va ten cua ban: ");
            hovaten = Console.ReadLine();
            Console.WriteLine("Xin chao {0}", hovaten); /*hovaten se chen vao {0}*/


            float e, f;
            string sinput;
            Console.WriteLine("Hay nhap tham so e: ");
            sinput = Console.ReadLine();
            e = float.Parse(sinput);
            Console.WriteLine("Hay nhap tham so f: ");
            sinput = Console.ReadLine();
            f = Convert.ToSingle(sinput); /*hoac f = float.Parse(sinput);*/
            Console.WriteLine("So e = {0}, f = {1}", e, f);


            var g = "1"; /*gan g bang gi (so, ky tu,...) var thi se hieu la kieu du lieu do*/


            double PI = 3.14; /*co the thay doi so PI HOAC  const double PI = 3.14 thi PI tro thanh hang so k the thay doi*/
            PI = 3.1414;

        }
    }
}