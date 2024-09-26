//1  Napisz program, który oblicza pole prostokąta. Wartości boków a i b wprowadzamy z klawiatury. W programie należy przyjąć, że zmienne a, b oraz pole są typu double (typu rzeczywistego).

double a, b;

a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());

Console.WriteLine(a * b);

// podpowiedz
// Console.Write("a = {0}, b = {1}", zmienna_a, zmienna_b);
// Ten zapis pozwala nam wypisać w komunikacie wartości zmiennych, {0} wyświetli
// wartośc zmienna_a, a {1} wartośc zmienna_b

// 2 Napisz program, który wyświetla na ekranie komputera pierwiastek kwadratowy z wartości predefiniowanej π = 3,14... z dokładnością do dwóch miejsc po przecinku.

Console.WriteLine("Wartość = {0:#.##}", Math.Sqrt(Math.PI));

// podpowiedz
// Math.Pi
// Math.Sqrt()
// Console.WriteLine(Wartość = {0:#.##}", zmienna );

// 3 Napisz program, który oblicza objętość kuli o promieniu r. Wartość promienia r wprowadzamy z klawiatury. W programie należy przyjąć, że zmienne promień r i objetosc są typu double (typu rzeczywistego). Dla tych zmiennych należy przyjąć format wyświetlania ich na ekranie z dokładnością do dwóch miejsc po przecinku.


double r = double.Parse(Console.ReadLine());

Console.WriteLine("Wartość = {0:N2}", 4.0 * Math.PI * r * r * r / 3);


// podpowiedz
// Console.WriteLine("wartośc a = {0:##.##}", zmienna_a);
// Używając zapisu {0:##.##} lub {0:N2} uzyskamy dokładność dwóch miejsc po przecinku
// wzór - 4.0*Math.PI*r*r*r/3;

// 4 Napisz program, który oblicza sumę, różnicę, iloczyn i iloraz dla dwóch liczb x i y wprowadzanych z klawiatury. W programie przyjmujemy, że zmienne x i y są typu double (typu rzeczywistego). Wszystkie zmienne należy wyświetlić z dokładnością do dwóch miejsc po przecinku.

double x, y;

x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());

Console.WriteLine("Suma = {0:N2}", x + y);
Console.WriteLine("Różnica = {0:N2}", x - y);
Console.WriteLine("Iloczyn = {0:N2}", x * y);
Console.WriteLine("Iloraz = {0:N2}", x / y);

// podpowiedz
// Console.ReadLine() wprowadzenie z klawaitury
// double.Parse(zmienna); konwersja do typu double

// 5*) Sprawdzanie podzielności przez 3 i 5. Napisz program w C#, który pobierze od użytkownika liczbę i sprawdzi, czy jest ona podzielna zarówno przez 3, jak i przez 5. Wyświetl odpowiedni komunikat na ekranie.

int liczba = int.Parse(Console.ReadLine());

if (liczba % 3 == 0 && liczba % 5 == 0)
{
    Console.WriteLine("Liczba jest podzielna przez 3 i 5");
}
else
{
    Console.WriteLine("Liczba nie jest podzielna przez 3 i 5");
}
