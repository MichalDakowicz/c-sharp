// static void Kalkulator()
// {
//     while (true)
//     {
//         Console.WriteLine("Wybierz opcję: (+, -, *, / lub q aby zakończyć)");
//         string wybor = Console.ReadLine();

//         if (wybor == "q")
//         {
//             return;
//         }

//         Console.WriteLine("Podaj pierwszą liczbę:");
//         double a = double.Parse(Console.ReadLine());

//         Console.WriteLine("Podaj drugą liczbę:");
//         double b = double.Parse(Console.ReadLine());

//         double wynik = 0;

//         switch (wybor)
//         {
//             case "+":
//                 wynik = Dodawanie(a, b);
//                 break;
//             case "-":
//                 wynik = Odejmowanie(a, b);
//                 break;
//             case "*":
//                 wynik = Mnozenie(a, b);
//                 break;
//             case "/":
//                 wynik = Dzielenie(a, b);
//                 break;
//             default:
//                 Console.WriteLine("Nieprawidłowy wybór");
//                 break;
//         }

//         Console.WriteLine("Wynik: " + wynik);

//     }

//     static double Dodawanie(double a, double b)
//     {
//         return a + b;
//     }

//     static double Odejmowanie(double a, double b)
//     {
//         return a - b;
//     }

//     static double Mnozenie(double a, double b)
//     {
//         return a * b;
//     }

//     static double Dzielenie(double a, double b)
//     {
//         if (b == 0)
//         {
//             Console.WriteLine("Nie można dzielić przez 0");
//             return 0;
//         }
//         else
//         {
//             return a / b;
//         }
//     }
// }

// Kalkulator();