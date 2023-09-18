// See https://aka.ms/new-console-template for more information

// To declare a new array
string[] arr = new string[3]; // new operator creates a new instance of an array in computers memory that can hold 3 string values

// To assign values to an array
arr[0] = "Hello";
arr[1] = "World";
arr[2] = "!";

// To initialize an array
string[] arr_init = {"Hello", "World", "!"};
Console.WriteLine(arr_init);

// Looping through array with for each
foreach (string word in arr_init) {
    Console.WriteLine(word);
}


int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;
foreach (int item in inventory) {
    sum+=item;
    bin++;
    Console.WriteLine($"Bin: {bin} - {sum} is the current total of all the inventory items.");
}

// Using a traditional for loop
for (int i = 0; i < 5; i++) {
    Console.WriteLine(inventory[i]);
}



