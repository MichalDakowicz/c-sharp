// using System.Collections;

// Zadanie 1. Napisz program, który w tablicy jednowymiarowej 100-elementowej o nazwie dane umieszcza liczby od 1 do 100, a następnie je sumuje.

// ArrayList dane = new ArrayList();
// int sum = 0;
// for (int i = 1; i <= 100; i++)
// {
//     dane.Add(i);
// }
// foreach (int i in dane)
// {
//     sum += i;
// }
// Console.WriteLine(sum);

// Zadanie 2. Napisz program, który w tablicy jednowymiarowej 100-elementowej o nazwie dane umieszcza liczby od 1 do 100, a następnie sumuje liczby parzyste i nieparzyste znajdujące się w tym przedziale.

// ArrayList dane = new ArrayList();
// int sumEven = 0;
// int sumOdd = 0;
// for (int i = 1; i <= 100; i++)
// {
//     dane.Add(i);
// }
// foreach (int i in dane)
// {
//     if (i % 2 == 0)
//     {
//         sumEven += i;
//     }
//     else
//     {
//         sumOdd += i;
//     }
// }
// Console.WriteLine($"Suma liczb parzystych: {sumEven}");
// Console.WriteLine($"Suma liczb nieparzystych: {sumOdd}");

// Zadanie 3. Korzystając z właściwości kolekcji ArrayList(), napisz program, który do kolekcji tego typu dodaje 6 liczb, a następnie je sortuje. Po wykonaniu tej operacji należy dokonać usunięcia drugiego elementu z listy, dodać nowy element do listy i dokonać ponownego sortowania.

// ArrayList list = new ArrayList();
// list.Add(5);
// list.Add(3);
// list.Add(1);
// list.Add(6);
// list.Add(4);
// list.Add(2);
// list.Sort();
// foreach (int i in list)
// {
//     Console.WriteLine(i);
// }
// list.RemoveAt(1);
// list.Add(7);
// list.Sort();
// foreach (int i in list)
// {
//     Console.WriteLine(i);
// }

// Zadanie 4. Korzystając z właściwości kolekcji ArrayList(), napisz program, który do kolekcji tego typu dodaje 6 imion, a następnie je sortuje.

// ArrayList list = new ArrayList();
// list.Add("Jan");
// list.Add("Anna");
// list.Add("Piotr");
// list.Add("Zofia");
// list.Add("Krzysztof");
// list.Add("Maria");
// list.Sort();
// foreach (string i in list)
// {
//     Console.WriteLine(i);
// }



// Zad1. Napisz program, który za pomocą instrukcji while sumuje liczby całkowite od 1 do 100.

// int sum = 0;
// int i = 1;
// while (i <= 100)
// {
//     sum += i;
//     i++;
// }
// Console.WriteLine(sum);

// Zad2. Napisz program, który za pomocą instrukcji for sumuje liczby parzyste od 1 do 100. Należy skorzystać z właściwości operatora modulo %.

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// Zad3. Napisz program, który za pomocą instrukcji do ... while sumuje liczby parzyste od 1 do 100. Należy skorzystać z właściwości operatora modulo %.

// int sum = 0;
// int i = 1;
// do
// {
//     if (i % 2 == 0)
//     {
//         sum += i;
//     }
//     i++;
// } while (i <= 100);
// Console.WriteLine(sum);

// Zad4. Napisz program, który za pomocą instrukcji while sumuje liczby parzyste z przedziału od 1 do 100. Należy skorzystać z właściwości operatora modulo %.

// int sum = 0;
// int i = 1;
// while (i <= 100)
// {
//     if (i % 2 == 0)
//     {
//         sum += i;
//     }
//     i++;
// }
// Console.WriteLine(sum);

// Zad5. Napisz program, który za pomocą instrukcji for sumuje liczby nieparzyste od 1 do 100. Należy skorzystać z właściwości operatora modulo % i oznaczonego symbolem ! operatora negacji.

// int sum = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 2 != 0)
//     {
//         sum += i;
//     }
// }
// Console.WriteLine(sum);

// Zad6. Napisz program, który za pomocą instrukcji do ... while sumuje liczby nieparzyste w przedziale od 1 do 100.

// int sum = 0;
// int i = 1;
// do
// {
//     if (i % 2 != 0)
//     {
//         sum += i;
//     }
//     i++;
// } while (i <= 100);
// Console.WriteLine(sum);

// Zad7. Napisz program, który za pomocą instrukcji for dla danych wartości x zmieniających się w przedziale od 0 do 10 obliczy wartość funkcji y = 3x.

// for (int x = 0; x <= 10; x++)
// {
//     Console.WriteLine(3 * x);
// }

// Zad8. Napisz program, który za pomocą instrukcji do ... while dla danych wartości x zmieniających się od 0 do 10 oblicza wartość funkcji y = 3x

// int x = 0;
// do
// {
//     Console.WriteLine(3 * x);
//     x++;
// } while (x <= 10);

// Zad9. Napisz program, który za pomocą instrukcji for wyświetla liczby całkowite od 1 do 20.

// for (int i = 1; i <= 20; i++)
// {
//     Console.WriteLine(i);
// }

// Zad10. Napisz program, który za pomocą instrukcji do ... while wyświetla liczby całkowite od 1 do 20.

// int i = 1;
// do
// {
//     Console.WriteLine(i);
//     i++;
// } while (i <= 20);

// Zad11. Napisz program, który za pomocą instrukcji while wyświetla liczby całkowite od 1 do 20.

// int i = 1;
// while (i <= 20)
// {
//     Console.WriteLine(i);
//     i++;
// }

// Zad12. Napisz program, który za pomocą instrukcji for sumuje liczby całkowite od 1 do 100.

// int sum = 0;
// for (int i = 1; i <= 100; i++)
// {
//     sum += i;
// }
// Console.WriteLine(sum);

// Zad13. Napisz program, który za pomocą instrukcji do ... while sumuje liczby całkowite od 1 do 100.

// int sum = 0;
// int i = 1;
// do
// {
//     sum += i;
//     i++;
// } while (i <= 100);
// Console.WriteLine(sum);

// Zad14. Napisz program, który za pomocą instrukcji while sumuje liczby całkowite od 1 do 100.

// int sum = 0;
// int i = 1;
// while (i <= 100)
// {
//     sum += i;
//     i++;
// }
// Console.WriteLine(sum);
