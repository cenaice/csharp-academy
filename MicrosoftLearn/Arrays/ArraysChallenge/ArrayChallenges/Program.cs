// See https://aka.ms/new-console-template for more information
string[] arr = {"B123","C234","A345","C153","B177","G3003","C235","B179"}; 

foreach (string item in arr) {
    if (item.StartsWith("B")) {
        Console.WriteLine($"Item starts with B! {item}");
    }
}

