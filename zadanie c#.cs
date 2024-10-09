using System;
using System.Xml.Linq;
using System.Runtime.InteropServices;
namespace praktyki2024
{
    internal class Program
    {
        //zadanie 1 i 2
        static void Zadanie1i2()
        {
            int liczbaint1 = 3, liczbaint2 = 4, liczbaint3 = 5;
            float liczbafloat1 = 0.1f, liczbafloat2 = 5.5f, liczbafloat3 = 10.10f;
            string imie1 = "Rafał", imie2 = "Mateusz", imie3 = "Maciek";
            char litera1 = 'A', litera2 = 'B', litera3 = 'C';
            char[] litery1 = { 'A', 'B', 'C'};
            char[] litery2 = { 'D', 'E', 'F'};
            char[] litery3 = { 'G', 'H', 'I'};


            Console.WriteLine($"Int: {liczbaint1}, {liczbaint2}, {liczbaint3}");
            Console.WriteLine($"Float: {liczbafloat1}, {liczbafloat2}, {liczbafloat3}");
            Console.WriteLine($"String: {imie1}, {imie2}, {imie3}");
            Console.WriteLine($"Char: {litera1}, {litera2}, {litera3}");
            Console.WriteLine($"Char: {new string(litery1)}");
            Console.WriteLine($"Char: {new string(litery2)}");
            Console.WriteLine($"Char: {new string(litery3)}");

        }
        //zadanie 3 i 4
        static void Zadanie3i4()
        {
            string imie, plec;
            int wiek, rokUrodzenia;

            Console.Write("Podaj swoje imię: ");
            imie = Console.ReadLine();

            Console.Write("Podaj swój wiek: ");
            wiek = int.Parse(Console.ReadLine());

            Console.Write("Podaj rok urodzenia: ");
            rokUrodzenia = int.Parse(Console.ReadLine());

            Console.Write("Podaj swoją płeć (m/k): ");
            plec = Console.ReadLine();

            bool blad = false;

            if (wiek <= 16 || wiek > 100)
            {
                Console.WriteLine("Błąd: niepoprawny wiek.");
                blad = true;
            }
            if (rokUrodzenia > 2010)
            {
                Console.WriteLine("Błąd: niepoprawny rok urodzenia.");
                blad = true;
            }
            if (plec != "m" && plec != "k")
            {
                Console.WriteLine("Błąd: niepoprawna płeć.");
                blad = true;
            }

            if (!blad)
            {
                Console.WriteLine($"Imię: {imie}");
                Console.WriteLine($"Wiek: {wiek}");
                Console.WriteLine($"Rok urodzenia: {rokUrodzenia}");
                Console.WriteLine($"Płeć: {plec}");
            }
        }
        //zadanie 5
        static void Zadanie5()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"for: {i}");
            }

            var l = new[] { 'h', '@', 'i', 'K' };
            foreach (int znaki in l)
            {
                Console.WriteLine($"Foreach: {znaki}");
            }

            var j = 1;
            do
            {
                Console.WriteLine($"do-while: {j}");
                j++;
            } while (j > 5);

            var k = 5;
            while (k < 10) 
            {
                Console.WriteLine($"while: {k}");
                k++;
            } 
        }


        static void Zadanie5b()
        {
            int kod;
            do
            {
                Console.Write("Podaj czterocyfrowy kod: ");
                kod = int.Parse(Console.ReadLine());
            } while (kod != 1234);

            Console.WriteLine("Poprawny kod! Wyszedłeś z pętli.");
        }


        static void Zadanie5c()
        
        {
            Console.WriteLine("Pętla while: użytkownik nie dał żadenj liczby więc warunek jest fałszywy");
            int licznik1 = 2;
            while (licznik1 < 2)
            {
                Console.WriteLine($"Licznik1 = {licznik1}");
            }
            

            Console.WriteLine("Pętla do-while:");
            int licznik2 = 2;
            do
            {
                Console.WriteLine($"Licznik2 = {licznik2} - użytkownik nie musiał nic wpisywać bo do-while najpierw wykonuje ciało pętli a później sprawdza warunek");
            } while (licznik2 < 2);
        }


        static void Zadanie5d()
        {
            Console.Write("Podaj wysokość choinki: ");
            int wysokosc = int.Parse(Console.ReadLine());

            for (int i = 1; i <= wysokosc; i++)
            {
                for (int j = 1; j <= wysokosc - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = wysokosc - 1; i >= 1; i--)
            {
                for (int j = 1; j <= wysokosc - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //zad 6
        static void Main(string[] args)
        {

            Zadanie1i2();
            Zadanie3i4();
            Zadanie5();
            Zadanie5b();
            Zadanie5c();
            Zadanie5d();
        }

    }
}