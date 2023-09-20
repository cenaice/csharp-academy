// Code project 1 - write code that validates integer input

string? readResult;
int val = 0;
int val_2 = 0;
Console.WriteLine("Enter an integer value between 5 and 10");
val = int.TryParse(readResult, out val);

while (val > 10 || val < 5) {
    Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
    valid = int.TryParse(readResult, out val);
}

Console.WriteLine($"You entered {val}. Please enter a numbeer between 5 and 10.");
    val_2 = int.TryParse(readResult, out val_2);

while (val_2 > 10 || val_2 < 5) {
    Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
    val_2 = int.TryParse(readResult, out val_2);
}

Console.ReadLine($"Your input value ({val_2}) has been accepted.");