// Composite Formatting
string first5 = "Hello";
string second5 = "World";
Console.WriteLine("{1} {0}!", first5, second5);
Console.WriteLine("{0} {0} {0}!", first5, second5);


// String interpolation
string first4 = "Hello";
string second4 = "World";
Console.WriteLine($"{first4} {second4}!");
Console.WriteLine($"{second4} {first4}!");
Console.WriteLine($"{first4} {first4} {first4}!");

Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage\n\t*******************************");
Console.WriteLine("\n**************************************************************\n");

decimal price9 = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price9:C} (Save {discount:C})");
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);


Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage\n\t*******************************");
Console.WriteLine("\n**************************************************************\n");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage\n\t*******************************");
Console.WriteLine("\n**************************************************************\n");

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage\n\t*******************************");
Console.WriteLine("\n**************************************************************\n");

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

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

Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage\n\t*******************************");
Console.WriteLine("\n**************************************************************\n");

comparisonMessage = currentProduct.PadRight(20);
Console.WriteLine(comparisonMessage);

comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
Console.WriteLine(comparisonMessage);

comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);
Console.WriteLine(comparisonMessage);

/*

Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage\n\t*******************************");
Console.WriteLine("\n**************************************************************\n");

Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage\n\t*******************************");
Console.WriteLine("\n**************************************************************\n");

*/
