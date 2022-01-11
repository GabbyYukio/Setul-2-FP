using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrosFPSet1P1
{
    class Program
    {
        static void P1()
        {
            float a, b;
            Console.WriteLine("Dati valoarea lui a");
            a=float.Parse(Console.ReadLine());

            Console.WriteLine("Dati valoarea lui b");
            b=float.Parse(Console.ReadLine());

            if (a != 0)
            {
                float x;
                x = -b / a;
                Console.WriteLine("Valoarea necunoscutei este {0}", x);
            }
            else
                Console.WriteLine("Nu este ecuatie!");
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
        static void P2()
        {
            double a, b, c;
            Console.WriteLine("Dati valoarea lui a");
            a=double.Parse(Console.ReadLine());

            Console.WriteLine("Dati valoarea lui b");
            b=double.Parse(Console.ReadLine());

            Console.WriteLine("Dati valoarea lui c");
            c=double.Parse(Console.ReadLine());

            if(a==0)
            {
                if(b==0)
                    Console.WriteLine("Nu este ecuatie");
                else
                    Console.WriteLine("Problema este ecuatie de gradul al doilea, cu unica solutie fiind {0}", -c / b);       
            }
            else
            {
                double delta=b*b-(4*a*c);
                if (delta < 0)
                    Console.WriteLine("Ecuatia are solutii ireale");
                else if(delta==0)
                    Console.WriteLine("Ecuatia are o singura solutie, aceasta fiind {0}",-b/(2*a));
                else
                    Console.WriteLine("Solutiile sunt: x1={0} si x2={1}", (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a));
            }
        }
        static void P3()
        {
            int x, k;
            Console.Write("Dati valore lui x\n>>> ");
            x=int.Parse(Console.ReadLine());
            Console.Write("Dati valore lui x\n>>> ");
            k=int.Parse(Console.ReadLine());

            if (x % k == 0)
            {
                Console.WriteLine("{0} se divide la {1}", x, k);
            }
            else
                Console.WriteLine("{0} impartit la {1} da catul {2} si restul {3}", x, k, x / k, x % k);
            Console.ReadLine();
        }
        static void P4()
        {
            int y;
            Console.Write("Dati anul curent\n>>> ");
            y = int.Parse(Console.ReadLine());

            if (y % 4 == 0)
            {
                if (y % 100 != 0)
                    Console.WriteLine("Anul {0} este an bisect.", y);
                else
                {
                    if (y % 400 == 0)
                        Console.WriteLine("Anul {0} este an bisect.", y);
                    else
                        Console.WriteLine("Anul {0} este an obisnuit", y);
                }

            }
            else
                Console.WriteLine("Anul {0} este an obisnuit", y);
            Console.ReadLine();
        }
        static bool apartine(int k, int n)
        {
            int cifre = 0;
            while (n != 0)
            {
                n /= 10;
                cifre++;
            }
            if (cifre >= k)
                return true;
            return false;
        }
        static void p5()
        {
            int n, k;
            Console.Write("Dati valoarea lui n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\nDati valoarea lui k: ");
            k = int.Parse(Console.ReadLine());

            if (apartine(k, n) ==true)
            {
                int copie_k = k, copie_n = n;
                while (k != 1)
                {
                    n /= 10;
                    k--;
                }
                Console.WriteLine("Al {0}-lea cifra al numarului {1} este {2}", copie_k, copie_n, n % 10);
            }
            else
                Console.WriteLine("Numarul nu are cel putin {0} termeni ", k);
            Console.ReadLine();
        }
        static void schimbare(ref float a, ref float b)
        {
            float aux = a;
            a = b;
            b = aux;
        }
        static void p7()
        {
            float a, b;
            Console.Write("Dati valoarea lui a: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("\nDati valoarea lui b: ");
            b = float.Parse(Console.ReadLine());


            schimbare(ref a, ref b);
            Console.WriteLine("Valorile dupa swap sunt {0} si {1} ", a, b);
        }
        static void schimbare_maibuna(ref float x,ref float y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }
        static void p8()
        {
            float a, b;
            Console.Write("Dati valoarea lui a: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("\nDati valoarea lui b: ");
            b = float.Parse(Console.ReadLine());


            schimbare_maibuna(ref a, ref b);
            Console.WriteLine("Valorile dupa swap sunt {0} si {1} ", a, b);
            Console.ReadLine();

        }
        static void p9()
        {
            int n;
            Console.Write("Dati valoarea lui n: ");
            n = int.Parse(Console.ReadLine());

            int d = 2;
            Console.Write("Divizorii sunt: 1");
            if(n%d==0)
                Console.Write("{0} ",d);
            d++;
            while(d<=n/2)
            {
                if(n%d==0)
                    Console.Write("{0} ",d);
                d += 2;
            }
            Console.Write("{0}", d);
        }

        static void p10()
        {
            int n;
            Console.Write("Dati valoarea lui n: ");
            n = int.Parse(Console.ReadLine());

            int div = 2;
            if (n % div == 0 && div != n)
                Console.WriteLine("Numarul {0} nu este prim", n);
            else
            {
                bool prim = true;
                div = 3;
                while (div < n / 2)
                {
                    if (n % div == 0)
                    {
                        prim = false;
                        break;
                    }
                    div += 2;
                }
                if (prim == true)
                    Console.WriteLine("Numarul {0} este prim", n);
                else
                    Console.WriteLine("Numarul {0} nu este prim", n);
            }
            Console.ReadLine();
        }

        static void p11()
        {
            int n;
            Console.Write("Dati valoarea lui n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Cifrele numarului sunt: ");
            while(n!=0)
            {
                Console.Write("{0}", n % 10);
                n /= 10;
            }
        }

        static void p12()
        {
            int n;
            Console.Write("Dati valoarea lui n: ");
            n = int.Parse(Console.ReadLine());

            int a, b;
            Console.WriteLine("Dati valoarea minima a intervalului deschis: ");
            a=int.Parse(Console.ReadLine());

            Console.WriteLine("Dati valoarea maxima a intervalului deschis: ");
            b=int.Parse(Console.ReadLine());

            int suma = 0;
            for(int i=a; i<=b; i++)
            {
                if (i % n == 0)
                    suma++;
            }
            if (suma == 0)
                Console.WriteLine("Nu exista niciun numar intreg din intervalul [{0},{1}] divizibil cu {2}", a, b, n);
            else
                Console.WriteLine("Exista {0} numere intregi divizile la {1} din intervalul [{2},{3}]", suma, n, a, b);
        }

        static bool an_bisect(int y)
        {
            if (y % 4 == 0)
            {
                if (y % 100 != 0)
                    return true;
                else
                {
                    if (y % 400 == 0)
                        return true;
                    else
                        return false;
                }

            }
            else
                return false;
        }

        static void p13()
        {
            int y1, y2;
            Console.WriteLine("Dati primul an: ");
            y1=int.Parse(Console.ReadLine());

            Console.WriteLine("Dati al doilea an: ");
            y2=int.Parse(Console.ReadLine());

            int caut = y1, suma=0;
            while(caut<=y2)
            {
                if(an_bisect(caut)==true)
                {
                    for (int i = caut; i <= y2; i += 4)
                        suma++;
                    break;
                }
            }
            Console.WriteLine("Numarul de ani bisecti intre {0} si {1} este {2}", y1, y2, suma);
        }

        static bool verificare_palindrom(int x)
        {
            int copie = x, oglindit=0;
            while(copie!=0)
            {
                oglindit = oglindit * 10 + copie % 10;
                copie /= 10;
            }
            if (x == oglindit)
                return true;
            return false;
        }
        static void p14()
        {
            int n;
            Console.WriteLine("Dati valoarea lui n: ");
            n=int.Parse(Console.ReadLine());

            if (verificare_palindrom(n) == true)
                Console.WriteLine("Numarul {0} este palindrom. ", n);
            else
                Console.WriteLine("Numarul {0} nu este palindrom. ", n);
        }
        static void ordonare(ref int x,ref int y)
        {
            if(x>y)
            {
                x = y + x;
                y = x - y;
                x = x - y;
            }
        }
        static void p15()
        {
            int a, b, c;
            Console.WriteLine("Dati valoarea lui a");
            a=int.Parse(Console.ReadLine());

            Console.Write("Dati valoarea lui b");
            b=int.Parse(Console.ReadLine());

            Console.WriteLine("Dati valorea lui c");
            c=int.Parse(Console.ReadLine());

            ordonare(ref a, ref b);
            ordonare(ref a, ref c);
            ordonare(ref b, ref c);

            Console.WriteLine("{0}, {1}, {2}", a, b, c);
        }

        static void p16()
        {
            int a, b, c, d, e;
            Console.WriteLine("Dati valoarea lui a");
            a = int.Parse(Console.ReadLine());

            Console.Write("Dati valoarea lui b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Dati valorea lui c");
            c = int.Parse(Console.ReadLine());

            Console.Write("Dati valoarea lui d");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("Dati valorea lui e");
            e = int.Parse(Console.ReadLine());

            ordonare(ref a, ref b);
            ordonare(ref a, ref c);
            ordonare(ref a, ref d);
            ordonare(ref a, ref e);
            ordonare(ref b, ref c);
            ordonare(ref b, ref d);
            ordonare(ref b, ref e);
            ordonare(ref c, ref d);
            ordonare(ref c, ref e);
            ordonare(ref d, ref e);

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", a,b, c, d, e);
        }
        static int cmmdc_euclid(int x, int y)
        {
            while(x!=y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }
            return x;
        }
        static void p17()
        {
            int a, b;
            Console.WriteLine("Dati valoarea lui a");
            a = int.Parse(Console.ReadLine());

            Console.Write("Dati valoarea lui b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Cel mai mare divizor comun dintre {0} si {1} este {2}", a, b, cmmdc_euclid(a, b));
            Console.WriteLine("Iar cel mai mic multiplu comun este {0}", (a/cmmdc_euclid(a,b))*(b/cmmdc_euclid(a,b)));
        }

        static bool prim(int n)
        {
            int div = 2;
            if (n % div == 0 && div != n)
                return false;
            else
            {
                bool prim = true;
                div = 3;
                while (div < n / 2)
                {
                    if (n % div == 0)
                    {
                        prim = false;
                        break;
                    }
                    div += 2;
                }
                return prim;
            }
        }
        static void p18()
        {
            int n;
            Console.Write("Dati valoarea lui n: ");
            n = int.Parse(Console.ReadLine());

            if (prim(n) == true)
                Console.WriteLine("Numarul {0} nu are divizori proprii. ", n);
            else
            {
                Console.WriteLine("Numarul {0} poate fi scris ca: 1x",n);
                int d = 2, s = 0;
                while(n%d==0)
                {
                    n /= d;
                    s++;
                }
                if (s != 0)
                    Console.WriteLine("2^{0}", s);
                d++;
                while(d<n/2)
                {
                    s = 0;
                    while(n%d==0)
                    {
                        n /= d;
                        s++;
                    }
                    Console.WriteLine("x{0}^{1}", d, s);
                    d += 2;
                }
            }
        }

        static  void p20()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 1024), input;
            Console.Write("Ghiciti numarul meu: ");
            input=int.Parse(Console.ReadLine());
            while (n!=input)
            {
                if (input < n)
                    Console.WriteLine("Numarul este mai mare decat {0}", input);
                if (input > n)
                    Console.WriteLine("Numarul este mai mic decat {0}", input);
                Console.Write("Incercati din nou: ");
                input=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ai ghicit numarul!");
        }
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P7();
            //P8();
            //p10();
            //p11();
            //p12();
            //p13();
            //p14();
            //p15();
            //p16();
            //p17();
            //p18();
            //p20();
        }
    }
}
