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

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!";

// Console.WriteLine(yourDiscount);

// // Unit 3

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"    Shares: {productShares:N3} Product");
// Console.WriteLine($"        Sub Total: {subtotal:C}");
// Console.WriteLine($"            Tax: {taxPercentage:P2}");
// Console.WriteLine($"        Total Billed: {total:C}");

// // Unit 4

// // string input = "Pad this";
// // Console.WriteLine(input.PadLeft(12));
// // Console.WriteLine($"{input.PadRight(12)}.");

// // Console.WriteLine(input.PadLeft(12, '-'));
// // Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

// Unit 5

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName}");
// Console.WriteLine("As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.");
// Console.WriteLine("");
// Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
// Console.WriteLine("");
// Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.");
// Console.WriteLine("");
// Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// comparisonMessage += $"{currentProduct.PadRight(20)}{currentReturn:P2}  {currentProfit:C2}\n";
// comparisonMessage += $"{newProduct.PadRight(20)}{newReturn:P2}  {newProfit:C2}\n";

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
