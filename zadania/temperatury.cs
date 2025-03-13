// static void Main()
// {
//     Console.WriteLine("Podaj z czego chesz przeliczyć: (C - celciusz, F - fahrenheit) ");
//     string op = Console.ReadLine();

//     double wynik = 0;

//     switch (op)
//     {
//         case "C":
//             Console.WriteLine("Podaj temperaturę w stopniach Celcjusza: ");
//             double c = double.Parse(Console.ReadLine());
//             wynik = CnaF(c);
//             break;
//         case "F":
//             Console.WriteLine("Podaj temperaturę w stopniach Fahrenheita: ");
//             double f = double.Parse(Console.ReadLine());
//             wynik = FnaC(f);
//             break;
//         default:
//             Console.WriteLine("Nieprawidłowy wybór");
//             break;
//     }

//     Console.WriteLine("Wynik: " + wynik);

//     static double CnaF(double c)
//     {
//         return c * 9 / 5 + 32;
//     }
//     static double FnaC(double f)
//     {
//         return (f - 32) * 5 / 9;
//     }
// }

// Main();