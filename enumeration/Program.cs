// See https://aka.ms/new-console-template for more information
ChestOptions chestState = ChestOptions.Locked;

while (true)
{
    Console.Write($"The chest is {chestState}. What do you want to do? ");
    string input = Console.ReadLine();
    if (chestState == ChestOptions.Locked && input == "unlock") { 
        chestState = ChestOptions.Closed; 
    }
    if (chestState == ChestOptions.Closed && input == "open") {
        chestState = ChestOptions.Open; 
    }
    if (chestState == ChestOptions.Open && input == "close") {
        chestState = ChestOptions.Closed; 
    }
    if (chestState == ChestOptions.Closed && input == "lock") {
        chestState = ChestOptions.Locked;
    }
}

enum ChestOptions { Open, Closed, Locked };


