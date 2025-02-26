// Console.WriteLine("Enter the shape (square, rectangle, triangle, circle):");
// string shape = Console.ReadLine();

// double area, perimeter = 0;

// switch (shape)
// {
//     case "square":
//         Console.WriteLine("Enter the side length of the square:");
//         double side = Convert.ToDouble(Console.ReadLine());
//         area = side * side;
//         perimeter = 4 * side;
//         Console.WriteLine($"The area of the square is {area} and the perimeter is {perimeter}");
//         break;
//     case "rectangle":
//         Console.WriteLine("Enter the length of the rectangle:");
//         double length = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Enter the width of the rectangle:");
//         double width = Convert.ToDouble(Console.ReadLine());
//         area = length * width;
//         perimeter = 2 * (length + width);
//         Console.WriteLine($"The area of the rectangle is {area} and the perimeter is {perimeter}");
//         break;
//     case "triangle":
//         Console.WriteLine("Enter the base of the triangle:");
//         double shape_base = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Enter the height of the triangle:");
//         double height = Convert.ToDouble(Console.ReadLine());
//         area = 0.5 * shape_base * height;
//         Console.WriteLine($"The area of the triangle is {area} and the perimeter is {perimeter}");
//         break;
//     case "circle":
//         Console.WriteLine("Enter the radius of the circle:");
//         double radius = Convert.ToDouble(Console.ReadLine());
//         area = Math.PI * radius * radius;
//         double circumference = 2 * Math.PI * radius;
//         Console.WriteLine($"The area of the circle is {area} and the circumference is {circumference}");
//         break;
//     default:
//         Console.WriteLine("Invalid shape");
//         break;
// }
