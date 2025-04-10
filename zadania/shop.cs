// class Shop
// {
//     public ShoppingCart cart = new ShoppingCart();
//     public List<Product> products = new List<Product>();

//     public Shop()
//     {
//         products.Add(new Product("Apple", 1.00, 10));
//         products.Add(new Product("Banana", 0.50, 20));
//         products.Add(new Product("Orange", 0.75, 15));
//         products.Add(new Product("Grapes", 2.00, 5));
//         products.Add(new Product("Mango", 1.50, 8));
//         products.Add(new Product("Pineapple", 3.00, 3));
//         products.Add(new Product("Strawberry", 2.50, 12));
//         products.Add(new Product("Blueberry", 2.75, 7));
//         products.Add(new Product("Watermelon", 4.00, 2));
//         products.Add(new Product("Peach", 1.25, 6));
//         products.Add(new Product("Kiwi", 1.75, 4));
//     }

//     public Product? FindProductByName(string name)
//     {
//         return products.FirstOrDefault(p => p.name.Equals(name, StringComparison.OrdinalIgnoreCase));
//     }
// }

// class Product
// {
//     public string name;
//     public double price;
//     public int quantity;

//     public Product(string name, double price, int quantity)
//     {
//         this.name = name;
//         this.price = price;
//         this.quantity = quantity;
//     }

// }

// class ShoppingCart
// {
//     public List<Product> cart = new List<Product>();

//     public void AddProduct(Product productTypeToAdd, int quantityToAdd)
//     {
//         if (quantityToAdd <= 0) return;

//         Product? existingCartItem = cart.FirstOrDefault(p => p.name.Equals(productTypeToAdd.name, StringComparison.OrdinalIgnoreCase));

//         if (existingCartItem != null)
//         {
//             existingCartItem.quantity += quantityToAdd;
//         }
//         else
//         {
//             Product cartProduct = new Product(productTypeToAdd.name, productTypeToAdd.price, quantityToAdd);
//             cart.Add(cartProduct);
//         }
//     }

//     public void RemoveProduct(Product productInCart, int quantityToRemove)
//     {
//         if (quantityToRemove <= 0) return;
//         if (cart.Contains(productInCart))
//         {
//             if (productInCart.quantity > quantityToRemove)
//             {
//                 productInCart.quantity -= quantityToRemove;
//             }
//             else
//             {
//                 cart.Remove(productInCart);
//             }
//         }
//     }

//     public double GetTotal()
//     {
//         double total = 0;
//         foreach (Product product in cart)
//         {
//             total += product.price * product.quantity;
//         }
//         return total;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Shop shop = new Shop();
//         Console.Clear();

//         while (true)
//         {
//             Console.Clear();
//             Console.WriteLine("===================================");
//             Console.WriteLine("Welcome to the shop!");
//             Console.WriteLine("1. Add Product to Cart");
//             Console.WriteLine("2. Remove Product from Cart");
//             Console.WriteLine("3. View Cart");
//             Console.WriteLine("4. Checkout");
//             Console.WriteLine("5. Exit");
//             Console.WriteLine("===================================");
//             Console.Write("Choose an option: ");

//             string choice = Console.ReadLine() ?? string.Empty;
//             Console.Clear();

//             switch (choice)
//             {
//                 case "1":
//                     Console.WriteLine("Available products:");
//                     if (shop.products.Count == 0)
//                     {
//                         Console.WriteLine("No products available in the shop.");
//                         break;
//                     }
//                     for (int i = 0; i < shop.products.Count; i++)
//                     {
//                         Console.WriteLine($"{i + 1}. {shop.products[i].name} - ${shop.products[i].price:F2} (Stock: {shop.products[i].quantity})");
//                     }
//                     Console.Write("Enter the product number to add to cart: ");
//                     try
//                     {
//                         if (!int.TryParse(Console.ReadLine(), out int addChoiceIndex) || addChoiceIndex <= 0 || addChoiceIndex > shop.products.Count)
//                         {
//                             Console.WriteLine("Invalid product number.");
//                             break;
//                         }
//                         int actualIndex = addChoiceIndex - 1;
//                         Product selectedShopProduct = shop.products[actualIndex];

//                         Console.Write($"Enter the quantity of {selectedShopProduct.name} to add: ");
//                         if (!int.TryParse(Console.ReadLine(), out int quantityToAdd) || quantityToAdd <= 0)
//                         {
//                             Console.WriteLine("Invalid quantity. Please enter a positive number.");
//                             break;
//                         }

//                         if (selectedShopProduct.quantity == 0)
//                         {
//                             Console.WriteLine($"Sorry, {selectedShopProduct.name} is out of stock.");
//                             break;
//                         }

//                         if (selectedShopProduct.quantity < quantityToAdd)
//                         {
//                             Console.WriteLine($"Not enough stock. Available quantity for {selectedShopProduct.name} is {selectedShopProduct.quantity}.");
//                             break;
//                         }

//                         shop.cart.AddProduct(selectedShopProduct, quantityToAdd);

//                         selectedShopProduct.quantity -= quantityToAdd;
//                         Console.WriteLine($"{quantityToAdd} {selectedShopProduct.name}(s) added to cart. Remaining stock: {selectedShopProduct.quantity}");
//                     }
//                     catch (FormatException)
//                     {
//                         Console.WriteLine("Invalid input format. Please enter numbers where required.");
//                     }
//                     catch (Exception ex)
//                     {
//                         Console.WriteLine($"An error occurred: {ex.Message}");
//                     }
//                     break;

//                 case "2":
//                     if (shop.cart.cart.Count == 0)
//                     {
//                         Console.WriteLine("Your cart is empty. Nothing to remove.");
//                         break;
//                     }

//                     Console.WriteLine("Your cart:");
//                     for (int i = 0; i < shop.cart.cart.Count; i++)
//                     {
//                         Console.WriteLine($"{i + 1}. {shop.cart.cart[i].name} - ${shop.cart.cart[i].price:F2} (Quantity: {shop.cart.cart[i].quantity})");
//                     }
//                     Console.Write("Enter the product number to remove from cart: ");
//                     try
//                     {
//                         if (!int.TryParse(Console.ReadLine(), out int removeChoiceIndex) || removeChoiceIndex <= 0 || removeChoiceIndex > shop.cart.cart.Count)
//                         {
//                             Console.WriteLine("Invalid product number.");
//                             break;
//                         }
//                         int actualIndex = removeChoiceIndex - 1;
//                         Product productToRemoveFromCart = shop.cart.cart[actualIndex];

//                         Console.Write($"Enter the quantity of {productToRemoveFromCart.name} to remove (Current: {productToRemoveFromCart.quantity}): ");
//                         if (!int.TryParse(Console.ReadLine(), out int quantityToRemove) || quantityToRemove <= 0)
//                         {
//                             Console.WriteLine("Invalid quantity. Please enter a positive number.");
//                             break;
//                         }

//                         Product? shopProduct = shop.FindProductByName(productToRemoveFromCart.name);
//                         int actualRemovedQuantity = Math.Min(quantityToRemove, productToRemoveFromCart.quantity);
//                         if (shopProduct != null)
//                         {
//                             shopProduct.quantity += actualRemovedQuantity;
//                         }

//                         string productName = productToRemoveFromCart.name;
//                         int initialQuantity = productToRemoveFromCart.quantity;

//                         shop.cart.RemoveProduct(productToRemoveFromCart, quantityToRemove);

//                         Product? remainingItem = shop.cart.cart.FirstOrDefault(p => p.name.Equals(productName, StringComparison.OrdinalIgnoreCase));
//                         if (remainingItem == null)
//                         {
//                             Console.WriteLine($"Removed all {initialQuantity} {productName}(s) from cart.");
//                         }
//                         else
//                         {
//                             Console.WriteLine($"Removed {Math.Min(quantityToRemove, initialQuantity)} {productName}(s) from cart. Remaining quantity: {remainingItem.quantity}.");
//                         }

//                     }
//                     catch (FormatException)
//                     {
//                         Console.WriteLine("Invalid input format. Please enter numbers where required.");
//                     }
//                     catch (Exception ex)
//                     {
//                         Console.WriteLine($"An error occurred: {ex.Message}");
//                     }
//                     break;

//                 case "3":
//                     Console.WriteLine("Your cart:");
//                     if (shop.cart.cart.Count == 0)
//                     {
//                         Console.WriteLine("Cart is empty.");
//                     }
//                     else
//                     {
//                         foreach (Product product in shop.cart.cart)
//                         {
//                             Console.WriteLine($"{product.name} - ${product.price:F2} (Quantity: {product.quantity})");
//                         }
//                         Console.WriteLine("-----------------------------------");
//                         Console.WriteLine($"Total: ${shop.cart.GetTotal():F2}");
//                     }
//                     break;

//                 case "4":
//                     Console.WriteLine("Checking out...");
//                     if (shop.cart.cart.Count == 0)
//                     {
//                         Console.WriteLine("Your cart is empty.");
//                     }
//                     else
//                     {
//                         Console.WriteLine("Final Cart:");
//                         foreach (Product product in shop.cart.cart)
//                         {
//                             Console.WriteLine($"- {product.name} x{product.quantity} (AT ${product.price:F2} EACH)");
//                         }
//                         Console.WriteLine("-----------------------------------");
//                         Console.WriteLine($"Total amount: ${shop.cart.GetTotal():F2}");
//                         Console.WriteLine("Thank you for shopping with us!");
//                     }
//                     return;

//                 case "5":
//                     Console.WriteLine("Exiting the shop. Goodbye!");
//                     return;

//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }

//             Console.WriteLine("\nPress Enter to continue...");
//             Console.ReadLine();
//             Console.Clear();

//         }
//     }
// }