// static void Cezar()
// {
//     Console.WriteLine("Podaj słowo do zaszyfrowania: ");
//     string slowo = Console.ReadLine();
//     Console.WriteLine("Podaj przesunięcie: ");
//     int x = int.Parse(Console.ReadLine());

//     Console.WriteLine("Co chcesz zrobić? (zaszyfruj/odszyfruj)");

//     switch (Console.ReadLine())
//     {
//         case "zaszyfruj":
//             Console.WriteLine(Zaszyfruj(slowo, x));
//             break;
//         case "odszyfruj":
//             Console.WriteLine(Odszyfruj(slowo, x));
//             break;
//         default:
//             Console.WriteLine("Nieprawidłowa komenda");
//             break;
//     }

//     static string Zaszyfruj(string slowo, int x)
//     {
//         string wynik = "";
//         for (int i = 0; i < slowo.Length; i++)
//         {
//             char znak = slowo[i];
//             if (znak >= 'A' && znak <= 'Z')
//             {
//                 znak = (char)(znak + x);
//                 if (znak > 'Z')
//                 {
//                     znak = (char)(znak - 26);
//                 }
//                 if (znak < 'A')
//                 {
//                     znak = (char)(znak + 26);
//                 }
//             }
//             if (znak >= 'a' && znak <= 'z')
//             {
//                 znak = (char)(znak + x);
//                 if (znak > 'z')
//                 {
//                     znak = (char)(znak - 26);
//                 }
//                 if (znak < 'a')
//                 {
//                     znak = (char)(znak + 26);
//                 }
//             }
//             wynik += znak;
//         }
//         return wynik;
//     }
//     static string Odszyfruj(string slowo, int x)
//     {
//         return Zaszyfruj(slowo, -x);
//     }
// }

// Cezar();