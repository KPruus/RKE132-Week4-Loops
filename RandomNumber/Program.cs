
Random rnd = new Random();

int myRandomNum;
int randomSum = 0;

for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11); // 0 - 10 tegelikult
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random mumber is: {myRandomNum}");
}

Console.WriteLine($"random sum total:{randomSum}");
