using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allRadixPrint
{
    class Program
    {
    

        static void Main(string[] args)
        {

            anyRadixPrint();



        }

        static void anyRadixPrint()
        {
            Console.WriteLine("Type in a number: ");

            int n = 0;

            n = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Enter base; Radix: ");

            int Radix = 0;

            Radix = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            int remainder;
            int quotient;

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int o = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;
            int w = 0;
            int x = 0;
            int y = 0;
            int zee = 0;

            quotient = (n / Radix);

            Console.WriteLine("The quotient(s) are: ");
            Console.WriteLine(quotient);
            Console.WriteLine(" ");

            if (quotient != 0)
            {
                a = quotient / Radix;
                Console.WriteLine(a);
                Console.WriteLine(" ");
            }

            if (a != 0)
            {
                b = a / Radix;
                Console.WriteLine(b);
                Console.WriteLine(" ");
            }

            if (b != 0)
            {
                c = b / Radix;
                Console.WriteLine(c);
                Console.WriteLine(" ");
            }

            if (c != 0)
            {
                d = c / Radix;
                Console.WriteLine(d);
                Console.WriteLine(" ");
            }

            if (d != 0)
            {
                e = d / Radix;
                Console.WriteLine(e);
                Console.WriteLine(" ");
            }

            if (e != 0)
            {
                f = e / Radix;
                Console.WriteLine(f);
                Console.WriteLine(" ");
            }

            if (f != 0)
            {
                g = f / Radix;
                Console.WriteLine(g);
                Console.WriteLine(" ");
            }

            if (g != 0)
            {
                h = g / Radix;
                Console.WriteLine(h);
                Console.WriteLine(" ");
            }

            if (h != 0)
            {
                i = h / Radix;
                Console.WriteLine(i);
                Console.WriteLine(" ");
            }

            if (i != 0)
            {
                j = i / Radix;
                Console.WriteLine(j);
                Console.WriteLine(" ");
            }

            if (j != 0)
            {
                k = j / Radix;
                Console.WriteLine(k);
                Console.WriteLine(" ");
            }

            if (k != 0)
            {
                l = k / Radix;
                Console.WriteLine(l);
                Console.WriteLine(" ");
            }

            if (l != 0)
            {
                m = l / Radix;
                Console.WriteLine(m);
                Console.WriteLine(" ");
            }

            if (m != 0)
            {
                o = m / Radix;
                Console.WriteLine(o);
                Console.WriteLine(" ");
            }

            if (o != 0)
            {
                p = o / Radix;
                Console.WriteLine(p);
                Console.WriteLine(" ");
            }

            if (p != 0)
            {
                q = p / Radix;
                Console.WriteLine(q);
                Console.WriteLine(" ");
            }

            if (q != 0)
            {
                r = q / Radix;
                Console.WriteLine(r);
                Console.WriteLine(" ");
            }

            if (r != 0)
            {
                s = r / Radix;
                Console.WriteLine(s);
                Console.WriteLine(" ");
            }

            if (s != 0)
            {
                t = s / Radix;
                Console.WriteLine(t);
                Console.WriteLine(" ");
            }

            if (t != 0)
            {
                u = t / Radix;
                Console.WriteLine(u);
                Console.WriteLine(" ");
            }

            if (u != 0)
            {
                v = u / Radix;
                Console.WriteLine(v);
                Console.WriteLine(" ");
            }

            if (v != 0)
            {
                w = v / Radix;
                Console.WriteLine(w);
                Console.WriteLine(" ");
            }

            if (w != 0)
            {
                x = w / Radix;
                Console.WriteLine(x);
                Console.WriteLine(" ");
            }

            if (x != 0)
            {
                y = x / Radix;
                Console.WriteLine(y);
                Console.WriteLine(" ");
            }

            if (y != 0)
            {
                zee = y / Radix;
                Console.WriteLine(zee);
                Console.WriteLine(" ");
            }

            remainder = (n % Radix);

            char z = (char)('0' + remainder);

           Console.WriteLine(" ");

           Console.WriteLine("This is the remainder: ");
           Console.WriteLine(z);

           Console.ReadKey();



        }
           
            

    }
}
