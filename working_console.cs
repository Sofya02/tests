// Классы/функции для работы с консолью (ввод/вывод базовых типов данных)

Console.Write("Enter the string: ");
string userInput = Console.ReadLine();

Console.Write("Enter an integer: ");
int intInput = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a floating point number: ");
double doubleInput = Convert.ToDouble(Console.ReadLine());


string outputString = "Hello, world!";
Console.WriteLine(outputString);

string name = "John";
int age = 25;
Console.WriteLine($"Name: {name}, Age: {age}");

int result = 42;
Console.WriteLine("Result: " + result);


int num = 10;
string str = "Hello, world!";
Console.WriteLine("The number is: " + num);
Console.WriteLine("The string is: " + str);

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!");

int age = 25;
Console.Write("Your age is: ");
Console.Write(age);

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.WriteLine("Key pressed!");

Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
Console.WriteLine("The square of the number is: " + (number * number));

Console.WriteLine("Enter a decimal number:");
string input = Console.ReadLine();
double number = Convert.ToDouble(input);
Console.WriteLine("The square root of the number is: " + Math.Sqrt(number));

Console.WriteLine("Press any key to clear the console...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Console cleared!");


string hello = "Hello world";
Console.WriteLine(hello);
Console.WriteLine("Welcome to C#!");
Console.WriteLine("Until the world...");
Console.WriteLine(24.5);

string name = "Tom";
int age = 34;
double height = 1.7;
Console.WriteLine(name,age,height);

