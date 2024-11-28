// // 1) Obliczanie pola prostokąta, kwadratu, trapezu. Napisz program w C#, który pobierze od użytkownika potrzebne dane, a następnie obliczy i wyświetli pole prostokąta, kwadratu i trapeza. Użytkownik najpierw powinien podać co chce obliczyć za pomocą if’a lub switch’a.

// int a, b, h;

// Console.WriteLine("Co chcesz obliczyć: ");
// Console.WriteLine("1 - pole prostokąta");
// Console.WriteLine("2 - pole kwadratu");
// Console.WriteLine("3 - pole trapezu");

// int figura = int.Parse(Console.ReadLine());

// switch (figura)
// {
//     case 1:
//         Console.WriteLine("Bok a: ");
//         a = int.Parse(Console.ReadLine());
//         Console.WriteLine("Bok b: ");
//         b = int.Parse(Console.ReadLine());
//         Console.WriteLine(a * b);
//         break;
//     case 2:
//         Console.WriteLine("Bok a: ");
//         a = int.Parse(Console.ReadLine());
//         Console.WriteLine(a * a);
//         break;
//     case 3:
//         Console.WriteLine("Bok a: ");
//         a = int.Parse(Console.ReadLine());
//         Console.WriteLine("Bok b: ");
//         b = int.Parse(Console.ReadLine());
//         Console.WriteLine("Wysokość h: ");
//         h = int.Parse(Console.ReadLine());
//         Console.WriteLine(((a + b) * h) / 2);
//         break;
//     default:
//         Console.WriteLine("Nie ma takiej opcji");
//         break;
// }

// // 2) Prosty Kalkulator. Napisz program w C#, który pobierze od użytkownika dwie liczby i wykonuje jedno z prostych działań matematycznych, takich jak dodawanie, odejmowanie, mnożenie lub dzielenie. Wyświetl wynik na ekranie.

// int liczba1, liczba2;

// Console.WriteLine("Podaj pierwszą liczbę: ");
// liczba1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj drugą liczbę: ");
// liczba2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Wybierz działanie: ");
// Console.WriteLine("+ - dodawanie");
// Console.WriteLine("- - odejmowanie");
// Console.WriteLine("* - mnożenie");
// Console.WriteLine("/ - dzielenie");

// char dzialanie = char.Parse(Console.ReadLine());

// switch (dzialanie)
// {
//     case '+':
//         Console.WriteLine(liczba1 + liczba2);
//         break;
//     case '-':
//         Console.WriteLine(liczba1 - liczba2);
//         break;
//     case '*':
//         Console.WriteLine(liczba1 * liczba2);
//         break;
//     case '/':
//         Console.WriteLine(liczba1 / liczba2);
//         break;
//     default:
//         Console.WriteLine("Nie ma takiej opcji");
//         break;
// }

// // 3) Konwerter jednostek. Stwórz program w C#, który umożliwi użytkownikowi przeliczanie jednostek, na przykład między kilometrami a milami. (mile = kilometry * 0.621371; kilometry = mile * 1.60934)

// double mile, kilometry;

// Console.WriteLine("Co chcesz przeliczyć: ");
// Console.WriteLine("1 - kilometry na mile");
// Console.WriteLine("2 - mile na kilometry");

// int wybor = int.Parse(Console.ReadLine());

// switch (wybor)
// {
//     case 1:
//         Console.WriteLine("Ile kilometrów: ");
//         kilometry = double.Parse(Console.ReadLine());
//         mile = kilometry * 0.621371;
//         Console.WriteLine($"{mile} mil");
//         break;
//     case 2:
//         Console.WriteLine("Ile mil: ");
//         mile = double.Parse(Console.ReadLine());
//         kilometry = mile * 1.60934;
//         Console.WriteLine($"{kilometry} kilometrów");
//         break;
//     default:
//         Console.WriteLine("Nie ma takiej opcji");
//         break;
// }

// // 4) Konwersja temperatury. Napisz program w C#, który pobierze od użytkownika temperaturę w stopniach Celsiusza i przeliczy ją na stopnie Fahrenheit lub odwrotnie. Wykorzystaj odpowiednie formuły konwersji. TempF = (tempC *9 / 5) + 32 TempC = (tempF – 32)*5 / 9

// double tempC, tempF;

// Console.WriteLine("Co chcesz przeliczyć: ");
// Console.WriteLine("1 - Celsjusz na Fahrenheita");
// Console.WriteLine("2 - Fahrenheit na Celsjusza");

// int przeliczenie = int.Parse(Console.ReadLine());

// switch (przeliczenie)
// {
//     case 1:
//         Console.WriteLine("Stopnie Celsjusza: ");
//         tempC = double.Parse(Console.ReadLine());
//         tempF = (tempC * 9 / 5) + 32;
//         Console.WriteLine($"{tempF} Fahrenheita");
//         break;
//     case 2:
//         Console.WriteLine("Stopnie Fahrenheita: ");
//         tempF = double.Parse(Console.ReadLine());
//         tempC = (tempF - 32) * 5 / 9;
//         Console.WriteLine($"{tempC} Celsjusza");
//         break;
//     default:
//         Console.WriteLine("Nie ma takiej opcji");
//         break;
// }

// // 5) Sprawdzanie podzielności przez 3 i 5. Napisz program w C#, który pobierze od użytkownika liczbę i sprawdzi, czy jest ona podzielna zarówno przez 3, jak i przez 5. Wyświetl odpowiedni komunikat na ekranie.

// int liczba;

// Console.WriteLine("Liczba: ");
// liczba = int.Parse(Console.ReadLine());

// if (liczba % 3 == 0 && liczba % 5 == 0)
// {
//     Console.WriteLine("Podzielna przez 3 i 5");
// }
// else
// {
//     Console.WriteLine("Nie podzielna przez 3 i 5");
// }

// // 6) Obliczanie średniej arytmetycznej. Napisz program w C#, który pobierze od użytkownika serię liczb i obliczy średnią arytmetyczną. Wyświetl wynik na ekranie.

// int n;
// double suma = 0;

// Console.WriteLine("Ile liczb chcesz wprowadzić: ");
// n = int.Parse(Console.ReadLine());

// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine("Liczba: ");
//     suma += double.Parse(Console.ReadLine());
// }

// Console.WriteLine($"Średnia: {suma / n}");

// // 7) Liczenie sumy elementów tablicy. Napisz program w C#, który pobierze od użytkownika tablicę liczb całkowitych i obliczy sumę wszystkich jej elementów. Wyświetl wynik na ekranie.

// int[] tablica = new int[5];
// int sum = 0;

// for (int i = 0; i < tablica.Length; i++)
// {
//     Console.WriteLine("Liczba: ");
//     tablica[i] = int.Parse(Console.ReadLine());
//     sum += tablica[i];
// }

// Console.WriteLine($"Suma: {sum}");

// // 8) Lista zakupów. Napisz program, który pozwoli użytkownikowi tworzyć listę zakupów, dodawać do niej przedmioty i wyświetlać pełną listę zakupów. List<string> listaZakupow = new List<string>();

// List<string> listaZakupow = new List<string>();

// while (true)
// {
//     Console.WriteLine("Co chcesz zrobić: ");
//     Console.WriteLine("1 - dodaj przedmiot");
//     Console.WriteLine("2 - wyświetl listę zakupów");
//     Console.WriteLine("3 - usuń przedmiot");

//     int choice = int.Parse(Console.ReadLine());

//     switch (choice)
//     {
//         case 1:
//             Console.WriteLine("Przedmiot: ");
//             listaZakupow.Add(Console.ReadLine());
//             break;
//         case 2:
//             foreach (var przedmiot in listaZakupow)
//             {
//                 Console.WriteLine(przedmiot);
//             }
//             break;
//         case 3:
//             Console.WriteLine("Który przedmiot chcesz usunąć: ");
//             string przedmiotDoUsuniecia = Console.ReadLine();
//             listaZakupow.Remove(przedmiotDoUsuniecia);
//             break;
//         default:
//             Console.WriteLine("Nie ma takiej opcji");
//             break;
//     }
// }

// // ***) Kalkulator BMI. Napisz program w C#, który pobierze od użytkownika wagę i wzrost (w metrach np. 1,8), a następnie obliczy i wyświetli wartość BMI oraz jej interpretację (np. "Niedowaga", „Prawidłowa waga", "Nadwaga", "Otyłość"). Wzór obliczenie bmi = waga / (wzrost*wzrost) niedowaga = bmi < 18.5; prawidlowa waga < 24.9; nadwaga < 29.9; powyżej 29.9 to już otyłość

// double waga, wzrost, bmi;

// Console.WriteLine("Podaj wagę: ");
// waga = double.Parse(Console.ReadLine());
// Console.WriteLine("Podaj wzrost: ");
// wzrost = double.Parse(Console.ReadLine());

// bmi = waga / (wzrost * wzrost);

// if (bmi < 18.5)
// {
//     Console.WriteLine("Niedowaga");
// }
// else if (bmi < 24.9)
// {
//     Console.WriteLine("Prawidłowa waga");
// }
// else if (bmi < 29.9)
// {
//     Console.WriteLine("Nadwaga");
// }
// else
// {
//     Console.WriteLine("Otyłość");
// }