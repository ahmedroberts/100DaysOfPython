using System;

namespace ConsoleApp001
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Watching YouTubes: https://www.youtube.com/watch?v=M5ugY7fWydE Derek Banas
            // & https://www.youtube.com/watch?v=0QUgvfuKvWU Microsoft Developer
            // $ https://www.youtube.com/watch?v=wxznTygnRfQ Bro Code
            // Also Microsoft C# New Year | New Certification C#
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.Clear();
            Console.WriteLine("\n***********************************\n");
            Console.WriteLine("    Jumbo, Rafiki\n    Raikage Training");
            Console.WriteLine("\n***********************************\n");

            // initialize variables - graded assignments 
            Console.WriteLine("\n***********************************\n");
            Console.WriteLine("    Guided Project\n    Calculate and Print Student Grades");
            Console.WriteLine("\n***********************************\n");
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            int sophiaSum = 0;
            int nicolasSum = 0;
            int zahirahSum = 0;
            int jeongSum = 0;

            sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            Console.WriteLine("Sophia: " + sophiaSum);
            Console.WriteLine("Nicolas: " + nicolasSum);
            Console.WriteLine("Zahirah: " + zahirahSum);
            Console.WriteLine("Jeong: " + jeongSum);

            decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal)jeongSum / currentAssignments;

            Console.WriteLine("Sophia: " + sophiaScore + " A");
            Console.WriteLine("Nicolas: " + nicolasScore + " B");
            Console.WriteLine("Zahirah: " + zahirahScore + " B");
            Console.WriteLine("Jeong: " + jeongScore + " A");

            Console.WriteLine("\n\nStudent\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
            Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
            Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
            Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

            Console.WriteLine("\n***********************************\n");
            Console.WriteLine("    Guided Project\n    Calculate final GPA");
            Console.WriteLine("\n***********************************\n");
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            int totalCreditHours = 0;
            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            int totalGradePoints = 0;
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

            Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

            Console.WriteLine($"\nFinal GPA:\t\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");


            /*
            string project1Name = "First-Project";
            Console.WriteLine($@"C:\Output\{project1Name}\Data");

            //Console.WriteLine("What is your name?");
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //string? userName = Console.ReadLine();
            //Console.WriteLine($"Ohayo, {userName}!");

            Console.WriteLine("c:\\source\\repos");
            Console.WriteLine(@"    c:\source\repos    
                    (this is where your code goes)");
            // Kon'nichiwa World
            // **Nihongo**
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            // **Nihongo**
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");

            string firstName = "Bob";
            string message = $"Hello {firstName}!";
            Console.WriteLine(message);

            string projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

            // Variables

            bool canIVote = true;
            Console.WriteLine("Can you vote?: {0}", canIVote);
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            decimal decPiValu = 3.141592653589793284626433832M;
            decimal decBigNum = 3.000000000011000000000000009M;
            Console.WriteLine("Decimacl (DEC) : PI + bigNum = {0}", decPiValu + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
            Console.WriteLine("Smallest Decimal : {0}", Decimal.MinValue);

            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            Console.WriteLine("Biggest Double : {0}", Double.MaxValue);
            double dblPiValu = 3.14159265358979;
            double dblBigNum = 3.00000000001109;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiValu + dblBigNum);

            Console.WriteLine("Biggest Float : {0}", float.MaxValue);
            double fltPiValu = 3.141592F;
            double fltBigNum = 3.000009F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiValu + fltBigNum);

            // 21:39 Derek Banas

            Console.WriteLine("\n\nAhmed's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2, or 3: ");
            string? userValue = Console.ReadLine();

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            string? prizeMessage = "";
            if (userValue == "1")
                prizeMessage = "You won a cupcake!";
            else if (userValue == "2")
                prizeMessage = "You won ice cream!";
            else if (userValue == "3")
                prizeMessage = "You won a watch!";
            else
                prizeMessage = "Apologies. That's not the game.";
            Console.WriteLine(prizeMessage);
            Console.ReadLine();
            

            Console.WriteLine("\nRaikage's Big Give Away");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string? userValue = Console.ReadLine();

            string prizeMessage = (userValue == "1") ? "cupcake" : "ice cream";
            Console.Write("You won a ");
            Console.Write(prizeMessage);
            Console.Write("!");
            Console.ReadLine();

            int value = 0;     // value is now 0.
            value = value + 5; // value is now 5.
            value += 5;        // value is now 10.

            value = 0;     // value is now 0.
            value = value + 1; // value is now 1.
            value++;           // value is now 2.

            value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);

            value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine($"Second: {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));

            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");
            */

        }
    }
}