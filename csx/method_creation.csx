Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage");
Console.WriteLine("\n**************************************************************\n");

SayHello();

void SayHello() 
{
    Console.WriteLine("Hello World!");
}

int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage");
Console.WriteLine("\n**************************************************************\n");

Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers() 
{
    Random random = new Random();

    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}

Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage");
Console.WriteLine("\n**************************************************************\n");

Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

TellFortune();
luck = random.Next(100);
TellFortune();

void TellFortune() 
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}


/*

Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage");
Console.WriteLine("\n**************************************************************\n");

Console.WriteLine("\n**************************************************************\n");
Console.WriteLine("\t\t\tAhmed the 9th Raikage");
Console.WriteLine("\n**************************************************************\n");

*/
