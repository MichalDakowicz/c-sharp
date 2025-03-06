// Console.WriteLine("Podaj tekst: ");
// string tekst = Console.ReadLine();

// while (true)
// {

//     Console.WriteLine("Podaj opcje: ");
//     Console.WriteLine("1: Ilość śłów");
//     Console.WriteLine("2: Ilość znaków");
//     Console.WriteLine("3: Ilość podanych liter");
//     Console.WriteLine("4: Zakończ");
//     int opcja = int.Parse(Console.ReadLine());

//     switch (opcja)
//     {
//         case 1:
//             Console.WriteLine($"Ilość słów: {tekst.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length}");
//             break;
//         case 2:
//             Console.WriteLine($"Ilość znaków: {tekst.Replace(" ", "").Replace("\t", "").Replace("\n", "").Replace("\r", "").Length}");
//             break;
//         case 3:
//             Console.WriteLine("Podaj literę: ");
//             char litera = char.Parse(Console.ReadLine());
//             int ilosc = 0;
//             foreach (char c in tekst)
//             {
//                 if (c == litera)
//                 {
//                     ilosc++;
//                 }
//             }
//             Console.WriteLine($"Ilość liter {litera}: {ilosc}");
//             break;
//         case 4:
//             return;
//     }

// }
