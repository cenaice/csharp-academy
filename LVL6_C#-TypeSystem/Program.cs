// // To properly convert input read in from user

// Console.Write("What is your favorite number?");
// var input = Convert.ToInt32(Console.ReadLine());

// // We can always use Int64 for LARGE numbers but that is unnecessary

// int[] arr = { input };
// Console.Write(input);
// Console.WriteLine(arr[0]);

// // Alternatively we can use Parse
// Console.Write("What is your least favorite number?");
// var newInput = int.Parse(Console.ReadLine());
// int number = int.Parse("9000")


// Write code that counts down from 10 to 1 using a recursive method.

void recursive_count(int n) {
    // Base Case
    if (n < 1) {
        Console.WriteLine("Base Case achieved");
    }

    else {
        Console.WriteLine(n);
        recursive_count(n - 1);
    }
}

recursive_count(10);



