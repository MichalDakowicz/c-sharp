// // zad1
// // Napisz program w C#, który pobierze od użytkownika długość i szerokość prostokąta, a następnie obliczy i wyświetli jego pole.

// double a, b;

// a = double.Parse(Console.ReadLine());
// b = double.Parse(Console.ReadLine());

// Console.WriteLine(a * b);

// // zad2
// // Napisz funkcję w C#, która sprawdzi, czy podana liczba jest parzysta. Wykorzystaj operator modulo (%) do sprawdzenia, czy reszta z dzielenia przez 2 wynosi 0.

// int c = int.Parse(Console.ReadLine());

// if (c % 2 == 0)
// {
//     Console.WriteLine("Liczba jest parzysta");
// }
// else
// {
//     Console.WriteLine("Liczba nie jest parzysta");
// }

// // zad3
// // Zamiana miejscami dwóch zmiennych Napisz program w C#, który zamieni miejscami wartości dwóch zmiennych. Wykorzystaj dodatkową zmienną tymczasową lub operacje arytmetyczne.

// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());

// int temp = x;
// x = y;
// y = temp;

// Console.WriteLine("x = {0}, y = {1}", x, y);

// // zad4
// // Kalkulator BMI: Napisz program w C#, który pobierze od użytkownika wagę i wzrost, a następnie obliczy i wyświetli wartość BMI oraz jej interpretację (np. "Niedowaga", "Prawidłowa waga", "Nadwaga", "Otyłość"). wzór obliczenie bmi = waga / (wzrost*wzrost) niedowaga = bmi < 18.5; prawidlowa waga < 24.9; nadwaga < 29.9; powyżej 29.9 to już nadwaga

// double waga = double.Parse(Console.ReadLine());
// double wzrost = double.Parse(Console.ReadLine());

// double bmi = waga / (wzrost * wzrost);

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

// // zad5
// // Konwerter jednostek: Stwórz program w C#, który umożliwi użytkownikowi przeliczanie jednostek, na przykład między kilometrami a milami. mile = kilometry * 0.621371; kilometry = mile * 1.60934;

// double mile = double.Parse(Console.ReadLine());
// double kilometry = mile * 1.60934;

// Console.WriteLine("Kilometry = {0}", kilometry);
