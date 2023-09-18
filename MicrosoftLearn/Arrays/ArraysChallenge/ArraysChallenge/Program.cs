// Exercise - Complete a challenge activity for nested iteration and selection statements
// https://learn.microsoft.com/en-us/training/modules/csharp-arrays/4-challenge

string[] arr = {
    "B123",
    "C234",
    "A345",
    "C15,,
    "B177",
    "G3003",
    "C235",
    "B179"}; 

foreach (string item in arr) {
    if (item.StartsWith("B")) {
        Console.WriteLine($"Item starts with B! {item}");
    }
}


