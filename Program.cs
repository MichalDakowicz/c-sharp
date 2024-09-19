// Zadaniem jest napisanie programu, który dla trzech liczb, a, b, c, wprowadzonych z klawiatury sprawdza, czy tworzą one trójkę pitagorejską.

/*int a, b, c;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

if (a * a + b * b == c * c)
{
    Console.WriteLine("Liczby {0}, {1} i {2} są trójką pitagorejską", a, b, c);
}
else
{
    Console.WriteLine("Liczby {0}, {1} i {2} nie są trójką pitagorejską", a, b, c);
}*/

// Zadaniem jest napisanie programu, który z wykorzystaniem instrukcji if oblicza pierwiastki równania kwadratowego ax^2 + bx + c = 0, w którym zmienne a, b, c to liczby rzeczywiste wprowadzane z klawiatury. Wszystkie zmienne wyświetlamy na ekranie z dokładnością do dwóch miejsc po przecinku.

/*double a, b, c;

a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Wprowadzone wartości: a = {0}, b = {1}, c = {2}", a, b, c);

double delta = b * b - 4 * a * c;

if (delta > 0)
{
    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("Dwa różne pierwiastki: x1 = {0}, x2 = {1}", x1, x2);
}
else if (delta == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine("Jeden pierwiastek: x = {0}", x);
}
else
{
    Console.WriteLine("Brak pierwiastków rzeczywistych");
}*/

// Zadaniem jest napisanie programu, który z wykorzystaniem instrukcji switch oblicza pierwiastki równania kwadratowego ax^2 + bx + c = 0, w którym zmienne a, b, c to liczby rzeczywiste wprowadzane z klawiatury. Wszystkie zmienne wyświetlamy z dokładnością do dwóch miejsc po przecinku.

double a, b, c;

a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Wprowadzone wartości: a = {0}, b = {1}, c = {2}", a, b, c);

double delta = b * b - 4 * a * c;
int caseSwitch = delta > 0 ? 1 : (delta == 0 ? 2 : 3);

switch (caseSwitch)
{
    case 1:
        double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Dwa różne pierwiastki: x1 = {0}, x2 = {1}", x1, x2);
        break;
    case 2:
        double x = -b / (2 * a);
        Console.WriteLine("Jeden pierwiastek: x = {0}", x);
        break;
    case 3:
        Console.WriteLine("Brak pierwiastków rzeczywistych");
        break;
}