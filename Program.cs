using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Systems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ikkilik = Sanoq(100, 2);
            string turtlik = Sanoq(100, 4);
            string sakkizlik = Sanoq(100, 8);
            string yettilik = Sanoq(100, 7);
            string unlik = Sanoq(100, 10);
            Console.WriteLine("ikkilik="+ikkilik);
            Console.WriteLine("turtlik="+turtlik);
            Console.WriteLine("sakkizlik="+sakkizlik);
            Console.WriteLine("yettilik="+yettilik);
            Console.WriteLine("unlik="+unlik);
            Console.ReadKey();
        }
        public static string Sanoq(int a, int b)
        {
            string c = "";
            while (a >= 1)
            {
                c += Convert.ToString(a % b);
                Console.WriteLine("a/b=" + a / b);
                a /= b;
            }
            Console.WriteLine("c="+c);
            string natija = "";
            for (int i = c.Length - 1; i >= 0; i--)
            {
                natija += c[i];
            }
            return natija;
        }
    }
}