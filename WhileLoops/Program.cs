
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; 

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess. What number am I thinking of, between 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Correct, congrats!!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Nope, try again.");
    }
}

Console.WriteLine("G'day");