// Unit 1,2

// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reversed(pallets);

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- pallet");
// }

// Unit 3

// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Unit 4

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);  // 321cba
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach ( string item in items)
// {
//     Console.WriteLine(item);
// }

// Unit 5

// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] items = pangram.Split(' ');

// string[] revertedItems = new string[items.Length];

// for(int i=0; i < items.Length; i++)
// {
//     char[] chars = items[i].ToCharArray();
//     Array.Reverse(chars);
//     revertedItems[i] = new string(chars);
// }

// string result = String.Join(' ', revertedItems);
// Console.WriteLine(result);

// Unit 7

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
int validOrderIDLength = 4;

string[] orderIDs = orderStream.Split(',');

Array.Sort(orderIDs);

foreach (string orderID in orderIDs)
{
    if(orderID.Length == validOrderIDLength)
    {
        Console.WriteLine($"{orderID}");
    }
    else
    {
        Console.WriteLine($"{orderID}\t- Error");
    }
}
