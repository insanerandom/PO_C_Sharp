using System;

namespace zDSR_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZADANIE 2.1");
            double F, C;
            Console.WriteLine("Podaj temperature w stopniach Celsjusza");
            C = double.Parse(Console.ReadLine());
            F = 32 + ((9 / 5d) * C); //5d istotny typ literału dla komputera
            Console.WriteLine(F);
            Console.WriteLine("Temperatura w Fahrenheitach: " + F);
            Console.WriteLine("\nZADANIE 2.2");
            double A, B, delta;
            Console.WriteLine("Podaj nastepujaco: A, B i C");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            delta = (B * B) - 4d * A * C;
            Console.WriteLine("Delta rowna sie: " + delta);
            Console.WriteLine("\nZADANIE 2.3");
            double kilo, height, BMI;
            Console.WriteLine("Prosze podac wartosci nastepujaco kilogramy oraz wzrost");
            kilo = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            BMI = (kilo / Math.Pow(height, 2)) * 10000;
            Console.WriteLine("BMI = {0:F2} kg/m^2", BMI);
            Console.WriteLine("\nZADANIE 2.4");
            int x = 100;
            Console.WriteLine(++x * 2);
            Console.WriteLine("Odpowiedz A, wyswietli się liczba 202.");
            Console.WriteLine("\nZADANIE 2.5");
            x = 2;
            int y = 3;
            x *= y * 2;
            Console.WriteLine(x);
            Console.WriteLine("Odpowiedz D, wyswietli sie liczba 12.");
            Console.WriteLine("\nZADANIE 2.6");
            x = 4;
            y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine("x bedzie sie rownal 3, y rowny 2");
            Console.WriteLine("x = " + x + ", y = " + y);
            Console.WriteLine("\nZADANIE 2.7");
            x = 5;
            y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
            Console.WriteLine("x i y beda rownaly sie 7");
            Console.WriteLine("x = " + x + ", y = " + y);
            Console.WriteLine("\nZADANIE 2.8");
            bool x8;
            int z = 1;
            y = 1;
            x8 = (y == 1 && z++ == 1);
            Console.WriteLine("Odpowiedz A, x = " + x8 + ", y = " + y + ", z = " + z);
            Console.WriteLine("\nZADANIE 2.9");
            Console.WriteLine("a)");
            int x9 = 1, y9 = 4, z9 = 2;
            bool wynik9 = (x9++ > 1 && y9++ == 4 && z9-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik9, x9, y9, z9);
            Console.WriteLine("b)");
            x9 = 1;
            y9 = 4;
            z9 = 2;
            wynik9 = (x9++ > 1 & y9++ == 4 && z9-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik9, x9, y9, z9);
            Console.WriteLine("c)");
            x9 = 1;
            y9 = 4;
            z9 = 2;
            wynik9 = (x9++ > 1 & y9++ == 4 & z9-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik9, x9, y9, z9);
            Console.WriteLine("d)");
            x9 = 1;
            y9 = 3;
            z9 = 4;
            wynik9 = (x9 == 1 || y9++ > 2 || ++z9 > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik9, x9, y9, z9);
            Console.WriteLine("e)");
            x9 = 1;
            y9 = 3;
            z9 = 4;
            wynik9 = (x9 == 1 | y9++ > 2 || ++z9 > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik9, x9, y9, z9);
            Console.WriteLine("f)");
            x9 = 1;
            y9 = 3;
            z9 = 4;
            wynik9 = (x9 == 1 | y9++ > 2 | ++z9 > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik9, x9, y9, z9);
            Console.WriteLine("\nZADANIE 2.10");
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / powierzchnia; //nalezy dodac w tej linijce (double), jest to RZUTOWANIE z zmiennej z typu int na double
            Console.WriteLine(gestoscZaludnienia);
            Console.ReadKey();
        }
    }
}
