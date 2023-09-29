// --------------------------- Hunting the Manticore --------------------------- //

/* 
Two Users,
User 1 first establishes (secretly) how far the Manticore is from 1 to 100
The program then has the second player repeatedly attempt to destroy (guess the number) the Manticore
Each round the player is told if they overshoot or not.

If turn number is a multiple of 3, fire blast deals 3 damage
If turn number is a multiple of 5, electric blast deals 3
If turn umber is 3 and 5, mighty fire-electric blast deals 10 points of damage
Manticore is destroyed after taking 10 points of damage
Every turn manticore survives it deals 1 point of damage to the city. City has 15HP.
*/

// Game starts with prompting Player 1

using System.Reflection.Metadata.Ecma335;

Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
int manticorePosition = int.Parse(Console.ReadLine());
int cityHP = 15;
int manticoreHP = 10;
int roundNumber = 1;


Console.WriteLine("Player 2, it is your turn.");

while (cityHP != 0 || manticoreHP != 0) {
    Console.WriteLine("-------------------------------------");
    // Game On

    // Display Game Stats
    Console.WriteLine($"Status Round: {roundNumber} City: {cityHP}/15 Manticore {manticoreHP}/10");
    Console.WriteLine($"The cannon is expected to deal {turnDamage(roundNumber)} damage this round");
    Console.Write("Enter desired cannon range: ");
    int cannonRange = int.Parse(Console.ReadLine());


    if (cannonRange == manticorePosition)
    {
        manticoreHP -= turnDamage(roundNumber);
        Console.WriteLine("That round was a DIRECT HIT!");
    }

    else if (cannonRange > manticorePosition)
    {
        Console.WriteLine("That round OVERSHOT the Manticore!");
    }

    else
    {
        Console.WriteLine("That round fell SHORT of the Manticore!");
    }


    roundNumber += 1;
    cityHP -= 1;
}


if (cityHP > manticoreHP) {
    Console.WriteLine("The Manticore has been destroyed! The city is saved!");
}

else
{
    Console.WriteLine("The city been destroyed bruh. YOU LOST. GAME OVER!");
}


//void string DisplayGameStats(int roundNumber, int manticoreHP, int cityHP,) {
//    Console.WriteLine($"Status Round: {} City: {}/15 Manticore {}/10");
    
//    // Output depends on roundNumber
//    Console.WriteLine($"The cannon is expected to deal {} damage this round")
//}

int turnDamage(int roundNumber) {
    // FizzBuzz approach
    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
    {
        return 10;
    } else if (roundNumber % 3 == 0)
    {
        return 3;
    } else if (roundNumber % 5 == 0)
    {
        return 3;
    } else
    {
        return 1;
    }   
}

