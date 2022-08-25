using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Câu 1
            
            int n, s = 0,t=0,g=1;
            Console.Write("Nhap n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n-------------- Tinh tong n so voi n nhap tu ban phim----------------");
            for(int i = 1; i <= n; i++)
            {
                s += i;
                if (i < n)
                {
                    Console.Write("{0}+", i);
                }else
                {
                    Console.Write("{0}={1}", i,s);
                }
            }
            Console.WriteLine("\n");

            //Câu 2
            Console.WriteLine("--------------------Tinh tong binh phuong-----------------");
            for (int i = 1; i <= n; i++)
            {
                t += i*i;
                if (i < n)
                {
                    Console.Write("{0}^2+", i);
                }
                else
                {
                    Console.Write("{0}^2={1}", i, t);
                }
            }
            Console.WriteLine("\n");
            //câu 3
            Console.WriteLine("-----------------Tinh giai thua----------------");
            if (n == 0)
            {
                Console.Write("{0}! = 1",n);
            }
            else
            {
                for(int i=1; i<= n; i++)
                {
                    g *= i;
                  
                }
                Console.WriteLine("{0}! = {1}", n, g);

            }
            Console.Write("\n");

            //câu 4
            Console.WriteLine("-------------In tam giac can co chieu cao=5 ------------------");
        
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
        
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            //câu 5
            Console.WriteLine("-------------In tam giac can rong co chieu cao=5 ------------------");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < 5*2; j++)
                {
                    if (Math.Abs(5 - j) == i - 1 || i == 5)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("\n");
            }
            //   Console.WriteLine("Tong tu 1 đến {0} là : {1}", n, s);
            Console.ReadLine();

        

        }
    }
}
