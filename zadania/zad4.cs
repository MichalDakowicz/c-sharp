// // 1.Wyświetlenie napisu: Napisz program, który wyświetli na ekranie "Hello, World!".

// Console.WriteLine("Hello, World!");

// // 2. Dodawanie dwóch liczb: Napisz program, który prosi użytkownika o dwie liczby i wyświetla ich sumę.

// Console.WriteLine("Podaj pierwszą liczbę:");
// int firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj drugą liczbę:");
// int secondNumber = int.Parse(Console.ReadLine());
// int sum = firstNumber + secondNumber;
// Console.WriteLine($"Suma podanych liczb to: {sum}");

// // 3. Wiek użytkownika: Stwórz program, który pyta użytkownika o jego wiek i wyświetla go na ekranie.

// Console.WriteLine("Ile masz lat?");
// int age = int.Parse(Console.ReadLine());
// Console.WriteLine($"Masz {age} lat.");

// // 4. Mnożenie liczby przez 2: Napisz program, który przyjmuje liczbę od użytkownika, mnoży ją przez 2 i wyświetla wynik.

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// int result = number * 2;
// Console.WriteLine($"Podwojona liczba to: {result}");

// // 5. Długość tekstu: Napisz program, który przyjmuje tekst od użytkownika i wyświetla liczbę znaków w tym tekście.

// Console.WriteLine("Podaj tekst:");
// string text = Console.ReadLine();
// int length = text.Length;
// Console.WriteLine($"Podany tekst ma {length} znaków.");

// // 6. Porównanie liczb: Stwórz program, który prosi użytkownika o dwie liczby i informuje, która z nich jest większa lub czy są równe.

// Console.WriteLine("Podaj pierwszą liczbę:");
// int firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj drugą liczbę:");
// int secondNumber = int.Parse(Console.ReadLine());
// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Pierwsza liczba jest większa.");
// }
// else if (firstNumber < secondNumber)
// {
//     Console.WriteLine("Druga liczba jest większa.");
// }
// else
// {
//     Console.WriteLine("Podane liczby są równe.");
// }

// // 7. Powtarzanie tekstu: Napisz program, który przyjmuje tekst i liczbę n, a następnie wyświetla tekst n razy.

// Console.WriteLine("Podaj tekst:");
// string text = Console.ReadLine();
// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// for (int i = 0; i < number; i++)
// {
//     Console.WriteLine(text);
// }

// // 8. Obliczenie pola kwadratu: Stwórz program, który przyjmuje długość boku kwadratu i oblicza jego pole.

// Console.WriteLine("Podaj długość boku kwadratu:");
// int side = int.Parse(Console.ReadLine());
// int area = side * side;
// Console.WriteLine($"Pole kwadratu o boku {side} wynosi: {area}");

// // 9. Sprawdzenie znaku liczby: Napisz program, który sprawdza, czy liczba podana przez użytkownika jest dodatnia, ujemna, czy zerowa.

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// if (number > 0)
// {
//     Console.WriteLine("Podana liczba jest dodatnia.");
// }
// else if (number < 0)
// {
//     Console.WriteLine("Podana liczba jest ujemna.");
// }
// else
// {
//     Console.WriteLine("Podana liczba jest równa zero.");
// }

// // 10. Zmiana wielkości liter: Napisz program, który przyjmuje tekst od użytkownika i wyświetla go zamienionego na wielkie litery.

// Console.WriteLine("Podaj tekst:");
// string text = Console.ReadLine();
// string upperCase = text.ToUpper();
// Console.WriteLine(upperCase);

// // 11. Parzystość liczby: Napisz program, który sprawdza, czy podana liczba jest parzysta, czy nieparzysta.

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.WriteLine("Podana liczba jest parzysta.");
// }
// else
// {
//     Console.WriteLine("Podana liczba jest nieparzysta.");
// }

// // 12. Maksimum z dwóch liczb: Stwórz funkcję, która przyjmuje dwie liczby i zwraca większą z nich.

// int Max(int a, int b)
// {
//     if (a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }

// Console.WriteLine("Podaj pierwszą liczbę:");
// int firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj drugą liczbę:");
// int secondNumber = int.Parse(Console.ReadLine());
// int max = Max(firstNumber, secondNumber);
// Console.WriteLine($"Większa liczba to: {max}");

// // 13. Kwadraty liczb: Napisz program, który wyświetli kwadraty liczb od 1 do 10.

// for (int i = 1; i <= 10; i++)
// {
//     int square = i * i;
//     Console.WriteLine($"{i}^2 = {square}");
// }

// // 14. Liczby pierwsze: Napisz program, który sprawdza, czy dana liczba jest liczbą pierwszą.

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// bool isPrime = true;
// if (number < 2)
// {
//     isPrime = false;
// }
// for (int i = 2; i <= Math.Sqrt(number); i++)
// {
//     if (number % i == 0)
//     {
//         isPrime = false;
//         break;
//     }
// }
// if (isPrime)
// {
//     Console.WriteLine("Podana liczba jest liczbą pierwszą.");
// }
// else
// {
//     Console.WriteLine("Podana liczba nie jest liczbą pierwszą.");
// }

// // 15. Odwrócony tekst: Utwórz funkcję, która przyjmuje tekst i zwraca go odwrócony.

// string Reverse(string text)
// {
//     char[] charArray = text.ToCharArray();
//     Array.Reverse(charArray);
//     return new string(charArray);
// }

// Console.WriteLine("Podaj tekst:");
// string text = Console.ReadLine();
// string reversedText = Reverse(text);
// Console.WriteLine(reversedText);

// // 16. Suma liczb: Napisz program, który obliczy sumę liczb od 1 do n (gdzie n jest podane przez użytkownika).

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= number; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Suma liczb od 1 do {number} wynosi: {sum}");

// // 17. Fibonacci: Napisz program, który wyświetla n liczb ciągu Fibonacciego.

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// int a = 0;
// int b = 1;
// for (int i = 0; i < number; i++)
// {
//     Console.WriteLine(a);
//     int temp = a;
//     a = b;
//     b = temp + b;
// }

// // 18. Silnia: Stwórz funkcję, która przyjmuje liczbę i zwraca jej silnię.

// int Factorial(int n)
// {
//     if (n == 0)
//     {
//         return 1;
//     }
//     else
//     {
//         return n * Factorial(n - 1);
//     }
// }

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// int factorial = Factorial(number);
// Console.WriteLine($"Silnia z {number} wynosi: {factorial}");

// // 19. Policz samogłoski: Napisz funkcję, która liczy liczbę samogłosek w podanym ciągu znaków.

// int CountVowels(string text)
// {
//     int count = 0;
//     foreach (char c in text)
//     {
//         if ("aeiouAEIOU".Contains(c))
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine("Podaj tekst:");
// string text = Console.ReadLine();
// int vowels = CountVowels(text);
// Console.WriteLine($"Liczba samogłosek w tekście: {vowels}");

// // 20. Odwrotna kolejność słów: Stwórz program, który odwraca kolejność słów w zdaniu podanym przez użytkownika.

// Console.WriteLine("Podaj zdanie:");
// string sentence = Console.ReadLine();
// string[] words = sentence.Split(' ');
// Array.Reverse(words);
// string reversedSentence = string.Join(" ", words);
// Console.WriteLine(reversedSentence);

// // 21. Liczby podzielne przez 3: Napisz program, który wypisuje liczby od 1 do 50, które są podzielne przez 3.

// for (int i = 1; i <= 50; i++)
// {
//     if (i % 3 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// // 22. Proste sortowanie: Stwórz listę liczb i napisz kod, który je posortuje (bez użycia funkcji sort).

// int[] numbers = { 5, 2, 8, 1, 9, 4 };
// for (int i = 0; i < numbers.Length - 1; i++)
// {
//     for (int j = i + 1; j < numbers.Length; j++)
//     {
//         if (numbers[i] > numbers[j])
//         {
//             int temp = numbers[i];
//             numbers[i] = numbers[j];
//             numbers[j] = temp;
//         }
//     }
// }

// // 23. Kalkulator: Napisz prosty kalkulator, który wykonuje dodawanie, odejmowanie, mnożenie i dzielenie dwóch liczb.

// Console.WriteLine("Podaj pierwszą liczbę:");
// int firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj drugą liczbę:");
// int secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Wybierz operację:");
// Console.WriteLine("1. Dodawanie");
// Console.WriteLine("2. Odejmowanie");
// Console.WriteLine("3. Mnożenie");
// Console.WriteLine("4. Dzielenie");
// int choice = int.Parse(Console.ReadLine());
// switch (choice)
// {
//     case 1:
//         Console.WriteLine($"Wynik dodawania: {firstNumber + secondNumber}");
//         break;
//     case 2:
//         Console.WriteLine($"Wynik odejmowania: {firstNumber - secondNumber}");
//         break;
//     case 3:
//         Console.WriteLine($"Wynik mnożenia: {firstNumber * secondNumber}");
//         break;
//     case 4:
//         if (secondNumber == 0)
//         {
//             Console.WriteLine("Nie można dzielić przez zero.");
//         }
//         else
//         {
//             Console.WriteLine($"Wynik dzielenia: {firstNumber / secondNumber}");
//         }
//         break;
//     default:
//         Console.WriteLine("Nieprawidłowy wybór.");
//         break;
// }

// // 24. Równanie kwadratowe: Napisz funkcję, która rozwiązuje równanie kwadratowe dla podanych współczynników a, b i c.

// void SolveQuadraticEquation(double a, double b, double c)
// {
//     double delta = b * b - 4 * a * c;
//     if (delta > 0)
//     {
//         double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//         double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//         Console.WriteLine($"Rozwiązania równania: x1 = {x1}, x2 = {x2}");
//     }
//     else if (delta == 0)
//     {
//         double x = -b / (2 * a);
//         Console.WriteLine($"Rozwiązanie równania: x = {x}");
//     }
//     else
//     {
//         Console.WriteLine("Równanie nie ma rozwiązań rzeczywistych.");
//     }
// }

// Console.WriteLine("Podaj współczynniki a, b i c równania kwadratowego:");
// double a = double.Parse(Console.ReadLine());
// double b = double.Parse(Console.ReadLine());
// double c = double.Parse(Console.ReadLine());
// SolveQuadraticEquation(a, b, c);

// // 25. Oblicz średnią: Napisz funkcję, która przyjmuje listę liczb i zwraca ich średnią arytmetyczną.

// double Average(List<int> numbers)
// {
//     int sum = 0;
//     foreach (int number in numbers)
//     {
//         sum += number;
//     }
//     return (double)sum / numbers.Count;
// }

// List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 4 };
// double average = Average(numbers);
// Console.WriteLine($"Średnia liczb: {average}");

// // 26. Liczba w zakresie: Napisz program, który sprawdza, czy podana liczba mieści się w określonym przedziale (np. od 1 do 100).

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// if (number >= 1 && number <= 100)
// {
//     Console.WriteLine("Podana liczba mieści się w zakresie od 1 do 100.");
// }
// else
// {
//     Console.WriteLine("Podana liczba nie mieści się w zakresie od 1 do 100.");
// }

// // 27. Liczby doskonałe: Napisz program, który sprawdza, czy podana liczba jest liczbą doskonałą (suma jej dzielników poza nią samą jest równa tej liczbie).

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i < number; i++)
// {
//     if (number % i == 0)
//     {
//         sum += i;
//     }
// }
// if (sum == number)
// {
//     Console.WriteLine("Podana liczba jest liczbą doskonałą.");
// }
// else
// {
//     Console.WriteLine("Podana liczba nie jest liczbą doskonałą.");
// }

// // 28. Zliczanie liczb parzystych i nieparzystych: Stwórz program, który zlicza, ile w podanej przez użytkownika liście liczb jest parzystych, a ile nieparzystych.

// Console.WriteLine("Podaj listę liczb oddzielonych spacją:");
// string input = Console.ReadLine();
// string[] numbers = input.Split(' ');
// int evenCount = 0;
// int oddCount = 0;
// foreach (string number in numbers)
// {
//     int n = int.Parse(number);
//     if (n % 2 == 0)
//     {
//         evenCount++;
//     }
//     else
//     {
//         oddCount++;
//     }
// }
// Console.WriteLine($"Liczba liczb parzystych: {evenCount}");
// Console.WriteLine($"Liczba liczb nieparzystych: {oddCount}");

// // 29. Generowanie listy kwadratów: Napisz funkcję, która przyjmuje liczbę n i generuje listę kwadratów liczb od 1 do n.

// List<int> GenerateSquares(int n)
// {
//     List<int> squares = new List<int>();
//     for (int i = 1; i <= n; i++)
//     {
//         squares.Add(i * i);
//     }
//     return squares;
// }

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// List<int> squares = GenerateSquares(number);
// Console.WriteLine("Kwadraty liczb od 1 do {number}:");
// foreach (int square in squares)
// {
//     Console.WriteLine(square);
// }

// // 30. Sumowanie cyfr liczby: Napisz program, który oblicza sumę cyfr w podanej liczbie.

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// int sum = 0;
// while (number > 0)
// {
//     sum += number % 10;
//     number /= 10;
// }
// Console.WriteLine($"Suma cyfr w podanej liczbie wynosi: {sum}");

// // 31. Znajdowanie najdłuższego słowa: Napisz funkcję, która przyjmuje listę słów i zwraca najdłuższe słowo.

// string LongestWord(List<string> words)
// {
//     string longestWord = "";
//     foreach (string word in words)
//     {
//         if (word.Length > longestWord.Length)
//         {
//             longestWord = word;
//         }
//     }
//     return longestWord;
// }

// List<string> words = new List<string> { "apple", "banana", "cherry", "date" };
// string longestWord = LongestWord(words);
// Console.WriteLine($"Najdłuższe słowo: {longestWord}");

// // 32. Obliczanie procentu: Stwórz program, który oblicza określony procent danej liczby.

// Console.WriteLine("Podaj liczbę:");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj procent:");
// int percent = int.Parse(Console.ReadLine());
// double result = number * percent / 100.0;
// Console.WriteLine($"{percent}% liczby {number} to: {result}");

// // 33. Zamiana stopni: Napisz funkcję, która przelicza temperaturę z Celsjusza na Fahrenheita i odwrotnie.

// double CelsiusToFahrenheit(double celsius)
// {
//     return celsius * 9 / 5 + 32;
// }

// double FahrenheitToCelsius(double fahrenheit)
// {
//     return (fahrenheit - 32) * 5 / 9;
// }

// Console.WriteLine("Podaj temperaturę w stopniach Celsjusza:");
// double celsius = double.Parse(Console.ReadLine());
// double fahrenheit = CelsiusToFahrenheit(celsius);
// Console.WriteLine($"Temperatura w stopniach Fahrenheita: {fahrenheit}");

// Console.WriteLine("Podaj temperaturę w stopniach Fahrenheita:");
// double fahrenheit = double.Parse(Console.ReadLine());
// double celsius = FahrenheitToCelsius(fahrenheit);
// Console.WriteLine($"Temperatura w stopniach Celsjusza: {celsius}");

// // 34. Losowanie liczby: Napisz program, który losuje liczbę z zakresu 1-10 i prosi użytkownika o jej odgadnięcie.

// Random random = new Random();
// int number = random.Next(1, 11);
// int guess = 0;
// while (guess != number)
// {
//     Console.WriteLine("Zgadnij liczbę (1-10):");
//     guess = int.Parse(Console.ReadLine());
//     if (guess < number)
//     {
//         Console.WriteLine("Za mało.");
//     }
//     else if (guess > number)
//     {
//         Console.WriteLine("Za dużo.");
//     }
// }

// // 35. Usuwanie duplikatów: Napisz funkcję, która przyjmuje listę i zwraca nową listę z usuniętymi duplikatami.

// List<int> RemoveDuplicates(List<int> numbers)
// {
//     List<int> uniqueNumbers = new List<int>();
//     foreach (int number in numbers)
//     {
//         if (!uniqueNumbers.Contains(number))
//         {
//             uniqueNumbers.Add(number);
//         }
//     }
//     return uniqueNumbers;
// }

// List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 4, 2, 8, 1 };
// List<int> uniqueNumbers = RemoveDuplicates(numbers);
// Console.WriteLine("Unikalne liczby:");
// foreach (int number in uniqueNumbers)
// {
//     Console.WriteLine(number);
// }