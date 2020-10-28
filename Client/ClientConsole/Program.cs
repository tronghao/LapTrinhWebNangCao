using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            ServiceMath.ServiceSoapClient ws = new ServiceMath.ServiceSoapClient();

            //nhap mang
            for(int i =0; i<5; i++)
            {
                Console.Write("Nhap so thu {0}:", i+1);
                number[i] = Int32.Parse(Console.ReadLine());
            }


            //max
            int max = number[0];

            for (int i = 1; i <= 4; i++)
            {
                max = ws.max(max, number[i]);
            }

            Console.Write("\nSo lon nhat: " + max.ToString());


            //min
            int min = number[0];

            for (int i = 1; i <= 4; i++)
            {
                min = ws.min(min, number[i]);
            }

            Console.Write("\nSo nho nhat: " + min.ToString());

            


            //sum
            int sum = number[0];
            for (int i = 1; i <= 4; i++)
            {
                sum = ws.sum(sum, number[i]);
            }
            Console.Write("\nTong cac so: " + sum.ToString());

            //avarage
            double ave = 0;
            sum = number[0];
            for (int i = 1; i <= 4; i++)
            {
                sum = ws.sum(sum, number[i]);
            }

            ave = ws.average(sum, 5);
            Console.Write("\nTrung binh cac so: " + ave.ToString());


            //so le
            bool[] soLe = new bool[5];

            for (int i = 0; i < 5; i++)
            {
                soLe[i] = ws.soLe(number[i]);
            }


            Console.Write("\nSo le:");
            int cacSoLe = 0;
            for (int i = 0; i < 5; i++)
            {
                if (soLe[i] == true)
                {
                    Console.Write(" " + number[i].ToString());
                    cacSoLe++;
                }
            }

            if (cacSoLe == 0)
                Console.Write(" khong co so le");

            //so chan
            bool[] soChan = new bool[5];

            for (int i = 0; i < 5; i++)
            {
                soChan[i] = ws.soChan(number[i]);
            }


            Console.Write("\nSo chan:");
            int cacsoChan = 0;
            for (int i = 0; i < 5; i++)
            {
                if (soChan[i] == true)
                {
                    Console.Write(" " + number[i].ToString());
                    cacsoChan++;
                }
            }

            if (cacsoChan == 0)
                Console.Write(" khong co so chan");


            //snt
            bool[] soNguyenTo = new bool[5];

            for (int i = 0; i < 5; i++)
            {
                soNguyenTo[i] = ws.soNguyenTo(number[i]);
            }


            Console.Write("\nSo nguyen to:");
            int cacsoNguyenTo = 0;
            for (int i = 0; i < 5; i++)
            {
                if (soNguyenTo[i] == true)
                {
                    Console.Write(" " + number[i].ToString());
                    cacsoNguyenTo++;
                }
            }

            if (cacsoNguyenTo == 0)
                Console.Write(" khong co so nguyen to");
            Console.ReadLine();
        }
    }
}
