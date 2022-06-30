using System;

namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            Console.WriteLine("\nZadanie 1");
            int a;
            int b;
            Console.WriteLine("Wprowadź dwie liczby i sprawdź czy są równe");
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            Console.WriteLine($"Wartość a = {a}, wartość b = {b}");
            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} nie są równe");
            }

            //Zadanie 2
            Console.WriteLine("\nZadanie 2");

            int c = 15;
            Console.WriteLine("Wprowadź liczbę i sprawdź czy jest liczbą parzystą");
            Int32.TryParse(Console.ReadLine(), out c);
            int wynik;
            wynik = c % 2;
            Console.WriteLine($"Reszta z dzielenia przez 2: {wynik}");
            if (wynik == 1)
            {
                Console.WriteLine($"Liczba {c} jest liczbą nieparzystą");
            }
            else
            {
                Console.WriteLine($"Liczba {c} jest liczbą parzystą");
            }

            //Zadanie 3

            Console.WriteLine("\nZadanie 3");
            int valEx3;
            Console.WriteLine("Wprowadź liczbę i sprawdź czy jest liczbą dodatnią");
            Int32.TryParse(Console.ReadLine(), out valEx3);
            Console.WriteLine($"Dane testowe {valEx3}");
            if (valEx3 >= 0)
            {
                Console.WriteLine("Liczba 14 jest liczbą dodatnią");
            }
            else
            {
                Console.WriteLine("Liczba 14 jest liczbą ujemną");
            }

            //Zadanie 4

            Console.WriteLine("\nZadanie 4");
            int valEx4 = 2016;
            Console.WriteLine(valEx4);

            if (valEx4 % 4 == 0)
                Console.WriteLine("Rok 2016 jest rokiem przestępnym");
            else
                Console.WriteLine("Rok 2016 nie jest rokiem przestępnym");

            //Zadanie 5
            Console.WriteLine("\nZadanie 5");
            short wiek;
            Console.WriteLine("Podaj swoj wiek");
            Int16.TryParse(Console.ReadLine(), out wiek);
            Console.WriteLine($"Twój wiek to: {wiek}");
            if (wiek >= 21)
                Console.WriteLine("Możesz zostać posłem");
            else
                Console.WriteLine("Nie możesz zostać posłem jesteś za młody");

            //Zadanie 6
            Console.WriteLine("\nZadanie 6");
            short wzrost;
            Console.WriteLine("Podaj swoj wzrost");
            Int16.TryParse(Console.ReadLine(), out wzrost);
            if (wzrost <= 160)
            {
                Console.WriteLine("Jesteś krasnoludem masz mniej jak 150cm wzrostu");
            }
            else if (wzrost > 185)
                Console.WriteLine("Jesteś wysoki");
            else
            {
                Console.WriteLine("Masz normalny wzrost");
            }

            //Zadanie 7
            Console.WriteLine("\nZadanie 7");
            int val1Ex7 = 90;
            int val2Ex7 = 40;
            int val3Ex7 = 60;
            Console.WriteLine("Podaj pierwszą liczbę");
            Int32.TryParse(Console.ReadLine(), out val1Ex7);
            Console.WriteLine("Podaj drugą liczbę");
            Int32.TryParse(Console.ReadLine(), out val2Ex7);
            Console.WriteLine("Podaj trzecią liczbę");
            Int32.TryParse(Console.ReadLine(), out val3Ex7);
            Console.WriteLine("Sprawdzam która jest największa");

            if (val1Ex7 > val2Ex7 && val1Ex7 > val3Ex7)
            {
                Console.WriteLine($"Największa wartość to: {val1Ex7}");
            }
            else if (val2Ex7 > val1Ex7 && (val2Ex7 > val3Ex7))
            {
                Console.WriteLine($"Największa wartość to: {val2Ex7}");
            }
            else
            {
                Console.WriteLine($"Największa wartość to: {val3Ex7}");
            }

            //Zadanie 8
            Console.WriteLine("\nZadanie 8");
            int matma = 80;
            int physic = 50;
            int chemist = 51;
            Console.WriteLine("Podaj wynik matematyki");
            Int32.TryParse(Console.ReadLine(), out matma);
            Console.WriteLine("Podaj wynik fizyki");
            Int32.TryParse(Console.ReadLine(), out physic);
            Console.WriteLine("Podaj wynik chemi");
            Int32.TryParse(Console.ReadLine(), out chemist);
            Console.WriteLine("Sprawdzam która jest największa");
            int suma;
            suma = matma + physic + chemist;

            if ((matma > 70 && physic > 45 && chemist > 45 && suma > 180) || matma + physic > 150 || matma + chemist > 150)
            {
                Console.WriteLine("Kandydat został dopuszczony do rekrutacji");
            }
            else
                Console.WriteLine("Zabrakło punktów rekrutacyjnych");

            //Zadanie 9
            Console.WriteLine("\nZadanie 9");
            Console.WriteLine("Wpisz temperature");
            int temp = int.Parse(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Mróz i piździ");
            }
            else if (temp > 0 && temp <= 10)
            {
                Console.WriteLine("Zimno");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("Chłodno");
            }
            else if (temp > 20 && temp <= 25)
            {
                Console.WriteLine("W sam raz");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("Gorąco");
            }
            else
            {
                Console.WriteLine("Jadę na Alaskę");
            }

            //Zadanie 10
            Console.WriteLine("\nZadanie 10");
            int val1Ex10;
            int val2Ex10;
            int val3Ex10;
            Console.WriteLine("Wprowadź krótki bok trójkąta");
            Int32.TryParse(Console.ReadLine(), out val1Ex10);
            Console.WriteLine("Wprowadź krótki bok trójkąta");
            Int32.TryParse(Console.ReadLine(), out val2Ex10);
            Console.WriteLine("Wprowadź najdłuższy bok trójkąta");
            Int32.TryParse(Console.ReadLine(), out val3Ex10);

            if (val1Ex10 + val2Ex10 > val3Ex10)
                Console.WriteLine("Mozna zbudować trójkąt z podanych boków");
            else
                Console.WriteLine("Nie można zbudować trójkąta");

            //Zadanie 11
            Console.WriteLine("\nZadanie 11");
            Console.WriteLine("Podaj swoją ocenę (1-6): ");
            byte mark;
            Byte.TryParse(Console.ReadLine(), out mark);

            switch (mark)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;

                case 3:
                    Console.WriteLine("Dostateczny");
                    break;

                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;

                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    break;

            }

            //Zadanie 12
            Console.WriteLine("\nZadanie 12");
            byte day;
            Console.WriteLine("Podaj dzień tygodnia po numerze (1-7), a wyświetlę Ci jego nazwę");
            Byte.TryParse(Console.ReadLine(), out day);
            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwortek :D");
                    break;
                case 5:
                    Console.WriteLine("Piątek piąteczek piątunio");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    break;
            }

            //Zadanie 13
            Console.WriteLine("\nZadanie 13");
            int val1Ex13;
            int val2Ex13;
            double result = 0;
            Console.WriteLine("Podaj pierwszą liczbę");
            Int32.TryParse(Console.ReadLine(), out val1Ex13);
            Console.WriteLine("Podaj drugą liczbę");
            Int32.TryParse(Console.ReadLine(), out val2Ex13);

            Console.WriteLine("Podaj numer operacji \n1. Dodawanie \n2. Odejmowanie \n3. Mnożenie \n4. Dzielenie");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    result = val1Ex13 + val2Ex13;
                    Console.WriteLine($"Twój wynik to {result}");
                    break;
                case "2":
                    result = val1Ex13 - val2Ex13;
                    Console.WriteLine($"Twój wynik to {result}");
                    break;
                case "3":
                    result = val1Ex13 * val2Ex13;
                    Console.WriteLine($"Twój wynik to {result}");
                    break;
                case "4":
                    result = val1Ex13 / val2Ex13;
                    Console.WriteLine($"Twój wynik to {result}");
                    break;
                default:
                    break;
            }

            Console.WriteLine("Koniec programu, proszę o feedback co jest źle co można poprawić na co zwrócić uwagę :) \r\nPozdrawiam");
        }
    }
}