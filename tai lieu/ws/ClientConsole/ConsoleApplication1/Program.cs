using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();

            int a, b;

            Console.Write("Nhap so thu nhat: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("a + b = " + ws.cong(a, b));
            Console.WriteLine("a - b = " + ws.tru(a, b));
            Console.WriteLine("a * b = " + ws.nhan(a, b));
            Console.WriteLine("a / b = " + ws.chia(a, b));

            Console.ReadKey();
        }
    }
}
