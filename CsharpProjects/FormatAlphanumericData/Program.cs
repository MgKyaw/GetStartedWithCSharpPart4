// Unit 2

// string first = "Hello";
// string second = "World";

// // Composite Formatting
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// // String Interpolation
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// // Formatting numbers
// decimal measurement = 123456.78912m;
// // Console.WriteLine($"Measurement: {measurement:N} units");
// Console.WriteLine($"Measurement: {measurement:N4} units");

// // Formatting percentage
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!";

Console.WriteLine(yourDiscount);
