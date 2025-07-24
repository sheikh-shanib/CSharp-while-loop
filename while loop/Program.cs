using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  start end process jump ----- while --- break down manner
            // start process jump end -------do while loop
            //entry level loop --- for loop , while
            //exit leave loop ----- do while loop
            Console.WriteLine("question no 1 ");
          
            Console.WriteLine("range of the   even/odd number");
            Console.WriteLine("enter minimum number");
            int min1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter maximum number");
            int max2 = int.Parse(Console.ReadLine());
            int num = min1;
            while(num<=max2)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num + "is even");
                }
                else
                {
                    Console.WriteLine(num + " is odd ");
                }
                num++;
            }


            Console.WriteLine("question no 2 ");
            Console.WriteLine("FIBONACHI series");
            Console.WriteLine(" enter the number");
            int w = int.Parse(Console.ReadLine());
            int a = 0; int b = 1;
            int i = 1;
            while( i <= w)
            {
                Console.WriteLine(a);
                int next = a + b;
                a = b;
                b = next;
                i++;
            }



            Console.WriteLine("question no 3 ");
            Console.WriteLine(" print  the table ");
            Console.WriteLine("enter any number");
            int n = int.Parse(Console.ReadLine());
            int m= 1;
            while (m <= 10) 
            {
                Console.WriteLine(n + " x " + m + " = " + (n * m));

                m++;
            }




            Console.WriteLine("question no 4");
            Console.WriteLine("summaition");
            int l= int.Parse(Console.ReadLine());
            int sum = 0;
            int j = 1;
            while (j <=l)
            {
                sum = sum + j;
                j++;
            }
            Console.WriteLine("sum from 1 to " + l+"=" + sum);




            Console.WriteLine("question no 5");
            Console.WriteLine("numb is prime or not");
            int numb = int.Parse(Console.ReadLine());
            int FLAG = 0;
            int g = 2;
            while( g <= numb / 2)
            {
                if (numb % g == 0)
                {
                    FLAG++;

                }
                g++;
            }
            if (FLAG == 0)
            {
                Console.WriteLine("numb is prime");
            }
            else
            {
                Console.WriteLine("numb is not prime");
            }



            Console.WriteLine("question no 6");
            Console.WriteLine("factorial");
            int o = int.Parse(Console.ReadLine());
            int fact = 1;
            int y = 1;
            while(y<=o)
            {

                fact = fact * y;
                y++;

            }
            Console.WriteLine(o + "=" + fact);





            Console.WriteLine("question no 7");
            Console.WriteLine(" range of prime and composit numbers");
            Console.WriteLine(" enter minimum number ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter maximum number");
            int max = int.Parse(Console.ReadLine());
            int num4 = min;
            while (num4<=max)
            {
                int p= 2;
                int flag = 0;
                while ( p<= num4 / 2) 
                {
                    if (num4 % p== 0)
                    {
                        flag = 1;
                    }
                    p++;
                }
               
                if (flag == 0)
                {
                    Console.WriteLine(num4 + "=" + " is prime ");
                }
                else
                {
                    Console.WriteLine(num4 + "=" + " is composit");
                }
                num4++;
               
            }















































        }
    }
}

