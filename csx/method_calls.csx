Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
Console.WriteLine("***************");

Console.WriteLine(dice.Next(1, 7));
dice.Next(1, 7);
Console.WriteLine("***************");

Random dice2 = new();
roll = dice2.Next(9, 11);
Console.WriteLine(roll);
roll = dice2.Next(9, 11);
Console.WriteLine(roll);
roll = dice2.Next(9, 11);
Console.WriteLine(roll);
roll = dice2.Next(9, 11);
Console.WriteLine(roll);
Console.WriteLine("***************");


// Create instance of stateful spin
Random spin = new Random();
int rouletteSpin = spin.Next(0, 38);
Console.WriteLine(rouletteSpin);
rouletteSpin = spin.Next(0, 38);
Console.WriteLine(rouletteSpin);
rouletteSpin = spin.Next(0, 38);
Console.WriteLine(rouletteSpin);
rouletteSpin = spin.Next(0, 38);
Console.WriteLine(rouletteSpin);
rouletteSpin = spin.Next(0, 38);
Console.WriteLine(rouletteSpin);
rouletteSpin = spin.Next(0, 38);
Console.WriteLine(rouletteSpin);
rouletteSpin = spin.Next(0, 38);
Console.WriteLine(rouletteSpin);
Console.WriteLine("***************");


Random dice3 = new Random();
int roll1 = dice3.Next();
int roll2 = dice3.Next(101);
int roll3 = dice3.Next(50, 101);
Console.WriteLine("***************");

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
Console.WriteLine("***************");

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
Console.WriteLine("***************");s