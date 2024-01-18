//1
/*Console.WriteLine("Da-mi un numar a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Da-mi un numar b:");
int b = Convert.ToInt32(Console.ReadLine());
int formula = -b / a;
Console.Write("x= ");
Console.Write(formula);
*/

//2
/*Console.WriteLine("Da-mi un numar a:");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Da mi un numar b:");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Da-mi un numar c:");
double c = Convert.ToDouble(Console.ReadLine());

sange(a, b, c);

static void sange(double a, double b, double c)
{
    double delta = Math.Pow(b, 2) - 4 * a * c;
    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

    if (x1 % 1 == 0 && x2 % 1 == 0)
    {
        Console.Write(" x1 = ");
        Console.WriteLine(x1);
        Console.Write(" x2 = ");
        Console.WriteLine(x2);
    }
    else
    {
        Console.WriteLine("Ecuatia nu are solutii reale");
    }
}*/

//3
/*
Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("k: ");
int k = Convert.ToInt32(Console.ReadLine());

if ( n % k == 0)
{
    Console.WriteLine("n se divide la k");
}
else
{
    Console.WriteLine("n nu se divide cu k"); 
}*/

//4
/*Console.Write(" Cate zile are anul y= ");
int y = Convert.ToInt32(Console.ReadLine());

if (y == 366)
{
    Console.WriteLine("y este an bisect");
}
else if (y == 365)
{
    Console.WriteLine("y nu este a bisect");
}*/

//7
/*Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());

int tempSwap = a;
a = b;
b = tempSwap; 
Console.WriteLine("a= " + a);
Console.WriteLine("b= " + b);*/


/*6
Console.Write("Lungimea laturii a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Lungimea laturii b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Lungimea laturii c: ");
int c = Convert.ToInt32(Console.ReadLine());

if ( a + b > c ||  b + c > a || c + a > b)
{
    Console.WriteLine($"Valorile {a}, {b}, {c} pot fi lungimile laturilor unui triunghi.");
}
else
{
    Console.WriteLine($"Valorile {a}, {b}, {c} nu pot fi lungimile laturilor unui triunghi ");
}*/

/*Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine("a= " + a);
Console.WriteLine("b= " + b);
*/

//9
/*Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int divizori = 0;
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        divizori++;
    }
}
Console.Write($"Numarul {n} are {divizori} divizori");*/



/*Console.Write("n= ");
int n = Convert.ToInt32(Console.ReadLine());

bool prime = true;

if (n < 2)
{
    prime = false;
}
for (int i = 2; i * i <= n; i++)
{
    if (n % i == 0)
    {
        prime = false;

    }
}
if (prime)
{
    Console.WriteLine($"Numarul {n} este prim");
}
else
{
    Console.WriteLine($"Numarul {n} nu este prim");
}
*/

/*Console.Write("Introduceti un numar n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Cifrele in ordine crescatoare sunt: ");
while (n > 0)
{
    int cifra = n % 10;
    Console.Write(cifra);
    n /= 10;
}
Console.WriteLine();
*/

//set1 5

//set1 14
/*using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Da-mi un numar:");
        int numar = Convert.ToInt32 (Console.ReadLine());

        Console.WriteLine("k:");
        int k = Convert.ToInt32 (Console.ReadLine());

        int kthDigit = ExtrageCifraDeLaSfarsitulNumarului(numar, k);

        Console.WriteLine($"A {k}-a cifra de la sfarsitul numarului {numar} este: {kthDigit}");
    }

    static int ExtrageCifraDeLaSfarsitulNumarului(int numar, int k)
    {
        int numarCifre = (int)Math.Floor(Math.Log10 (numar) + 1);

        if (k > 0 && k <= numarCifre)
        {
            int cifra = (int)( numar % Math.Pow(10, k));
            return cifra;
        }
        else
        {
            Console.WriteLine($"Eroare: {k} nu este o valoare validă pentru a extrage cifra.");
            return -1;
        }
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti un număr întreg: ");
        int numar = Convert.ToInt32(Console.ReadLine());

        if (EstePalindrom(numar))
        {
            Console.WriteLine($"{numar} este un număr palindrom.");
        }
        else
        {
            Console.WriteLine($"{numar} nu este un număr palindrom.");
        }
    }

    static bool EstePalindrom(int numar)
    {
        int numarInitial = numar;
        int invers = 0;

        while (numar > 0)
        {
            int cifra = numar % 10;
            invers = invers * 10 + cifra;
            numar /= 10;
        }

        return numarInitial == invers;
    }
}
*/

/*//set1 15
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Primul numar: ");
        int numar1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Al doilea numar: ");
        int numar2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Al treilea numar: ");
        int numar3 = Convert.ToInt32(Console.ReadLine());

        int[] numere = { numar1, numar2, numar3 };

        for (int i = 0; i < numere.Length - 1; i++)
        {
            for (int j = 0; i < numere.Length - i - 1; j++)
            {
                if (numere[j] > numere[j + 1])
                {
                    int temp = numere[j];
                    numere[j] = numere[j + 1];
                    numere[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Numerele in ordine crescatoare sunt: ");
        foreach(int numar in numere)
        {
            Console.Write(numar + " ");
        }
        Console.ReadLine();
    }
}*/

//set1 16
/*using System;

class Program
{
    static void Main()
    {
        // Citirea a 5 numere
        Console.Write("Introduceti primul numar: ");
        int numar1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al doilea numar: ");
        int numar2 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al treilea numar: ");
        int numar3 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al patrulea numar: ");
        int numar4 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al cincilea numar: ");
        int numar5 = int.Parse(Console.ReadLine());

        // Sortarea numerelor
        if (numar1 > numar2)
        {
            int temp = numar1;
            numar1 = numar2;
            numar2 = temp;
        }

        if (numar2 > numar3)
        {
            int temp = numar2;
            numar2 = numar3;
            numar3 = temp;
        }

        if (numar3 > numar4)
        {
            int temp = numar3;
            numar3 = numar4;
            numar4 = temp;
        }

        if (numar4 > numar5)
        {
            int temp = numar4;
            numar4 = numar5;
            numar5 = temp;
        }

        if (numar1 > numar2)
        {
            int temp = numar1;
            numar1 = numar2;
            numar2 = temp;
        }

        if (numar2 > numar3)
        {
            int temp = numar2;
            numar2 = numar3;
            numar3 = temp;
        }

        if (numar3 > numar4)
        {
            int temp = numar3;
            numar3 = numar4;
            numar4 = temp;
        }

        if (numar1 > numar2)
        {
            int temp = numar1;
            numar1 = numar2;
            numar2 = temp;
        }

        if (numar2 > numar3)
        {
            int temp = numar2;
            numar2 = numar3;
            numar3 = temp;
        }

        if (numar1 > numar2)
        {
            int temp = numar1;
            numar1 = numar2;
            numar2 = temp;
        }
        Console.WriteLine($"Numerele in ordine crescatoare: {numar1}, {numar2}, {numar3}, {numar4}, {numar5}");
    }
}
*/

/*//set1 17 
using System;
class Program
{
    static int CMMC(int a, int b)
    {
        while(b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int CMM(int a, int b)
    {
        return (a * b) / CMM(a, b);
    }

    static void Main()
    {
        Console.WriteLine("Da-mi doua numere: ");

        Console.Write("Primul numar: ");
        int numar1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Al doilea numar: ");
        int numar2 = Convert.ToInt32(Console.ReadLine());

        int cmmc = CMMC(numar1, numar2);
        int cmm = CMM(numar1, numar2);

        Console.WriteLine($"Cel mai mare divizor comun al {numar1} și {numar2} este: {cmmc}");
        Console.WriteLine($"Cel mai mic multiplu comun al {numar1} și {numar2} este: {cmm}");
    }
}
*/

/*//set1 18
using System;
class Program
{
    static void FactoriPrimi(int n)
    {
        Console.WriteLine($"Descompunerea in factori primi a numarului: {n}");

        for(int i = 2; i <= n; i++)
        {
            int count = 0;

            while(n % i == 0)
            {
                count++;
                n /= 1;
            }

            if(count > 0)
            {
                Console.Write($"{i}^{count}");

                if (n > 1)
                {
                    Console.Write(" x ");
                }
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Introduceti un numar pentru a-l descompune in factori primi: ");
        int numar = Convert.ToInt32(Console.ReadLine());

        FactoriPrimi(numar);
    }
}*/

/*//set1 19
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti un numar: ");
        int numar = Convert.ToInt32(Console.ReadLine());

        if (AreDoarDouaCifre(numar))
        {
            Console.WriteLine($"Numarul {numar} este format doar cu doua cifre care se pot repeta.");
        }
        else
        {
            Console.WriteLine($"Numarul {numar} nu este format doar cu doua cifre care se pot repeta.");
        }
    }

    static bool AreDoarDouaCifre(int numar)
    {
        string numarString = numar.ToString();

        return numarString.Distinct().Count() == 2;
    }
}
*/

/*//set1 ex21
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ghiceste numarul intre 1 si 1024!");

        int limitaInferioara = 1;
        int limitaSuperioara = 1024;

        while (limitaInferioara <= limitaSuperioara)
        {
            int guess = (limitaInferioara + limitaSuperioara) / 2;

            Console.WriteLine($"Numarul este mai mare sau egal cu {guess}? (da/nu)");
            string raspuns = Console.ReadLine().ToLower();

            if (raspuns == "da")
            {
                limitaInferioara = guess + 1;
            }
            else if (raspuns == "nu")
            {
                limitaSuperioara = guess - 1;
            }
            else
            {
                Console.WriteLine("Te rog sa raspunzi cu 'da' sau 'nu'.");
            }
        }

        Console.WriteLine($"Numarul este: {limitaSuperioara}");
    }
}

*/


