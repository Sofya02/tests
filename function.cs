//Функции (процедуры)
//в C# нет функций, только статические методы классов

//simple static method
public class MathUtils
{
     public static int Add(int a, int b)
     {
         return a + b;
     }
}

// Method call
int sum = MathUtils.Add(5, 3); // sum will be equal to 8

//Static method using static variables
public class Counter
{
     private static int count = 0;

     public static void Increment()
     {
         count++;
     }

     public static int GetCount()
     {
         return count;
     }
}

// Calling methods
Counter.Increment();
Counter.Increment();
int currentCount = Counter.GetCount(); // currentCount will be equal to 2

//Static method that operates on class objects
public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public static double DistanceBetween(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
    }
}

// Method call
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = new Point { X = 4, Y = 6 };
double distance = Point.DistanceBetween(p1, p2);

//Static constructor and static fields
public class DatabaseSettings
{
     public static string ConnectionString { get; private set; }

     static DatabaseSettings()
     {
         // There may be logic here to initialize the connection string
         ConnectionString = "Server=myServer;Database=myDB;User Id=myUser;Password=myPass;";
     }
}

// Using a static field
string connectionString = DatabaseSettings.ConnectionString;

//Static method with default parameters
public class Calculator
{
     public static int Multiply(int a, int b = 2)
     {
         return a * b;
     }
}

// Calling methods
int result1 = Calculator.Multiply(3, 4); // result1 will be equal to 12
int result2 = Calculator.Multiply(3); // result2 will be 6 since b defaults to 2

//Class describing the student
class Student
{
     //Normal (non-static) class constructor
     public Student(string aName)
     {
        name = aName;
     }
 
     //Ordinary (non-static) class property
     public string Name { get { return name; } set { name = value; } }
 
     //Static property of the class
     public static string About { get { return about; } }
 
     //Ordinary (not static) class field
     private string name; //Student name
 
     //Static class field
     private static string about = "Class to represent simple students in programs written in C#";
}

class Vector
{
   private float x;
   private float y;
   public Vector()
   {
   }
   private static float Length (float x0, float y0, float x1, float y1)
   {
     /* ... */
   }
  
   public float Length()
   {
     // You can call a static method from a non-static method.
     return Length(0, 0, x, y);
   }
   public static Vector Sum (Vector a, Vector b)
   {
      Vector sum = new Vector();
      // Static methods, like non-static ones,
      // has access to fields, including private ones
      // objects of the same class:
     sum.x = a.x + b.x;
      sum.y = a.y + b.y;
      return sum;
   }
}


public class Settings
{
   public string TempWorkspacePath() { /* ... */ }
   public static Settings Singleton = new Settings();
}
// Usage:
string path = Settings.Singleton.TempWorkspacePath();
// Option 2
public class Settings
{
   public string TempWorkspacePath() { /* ... */ }
 
   private static Settings singleton;
   private Settings()
   {
     singleton = new Settings();
   }
   public SettingsGet()
   {
     if (singleton == null)
       singleton = new Settings();
     return singleton;
   }
}
// Usage:
string path = Settings.Get().TempWorkspacePath();


public static class TemperatureConverter
{
    public static double CelsiusToFahrenheit(string temperatureCelsius)
    {
        // Convert argument to double for calculations.
        double celsius = Double.Parse(temperatureCelsius);

        // Convert Celsius to Fahrenheit.
        double fahrenheit = (celsius * 9 / 5) + 32;

        return fahrenheit;
    }

    public static double FahrenheitToCelsius(string temperatureFahrenheit)
    {
        // Convert argument to double for calculations.
        double fahrenheit = Double.Parse(temperatureFahrenheit);

        // Convert Fahrenheit to Celsius.
        double celsius = (fahrenheit - 32) * 5 / 9;

        return celsius;
    }
}

class TestTemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Please select the convertor direction");
        Console.WriteLine("1. From Celsius to Fahrenheit.");
        Console.WriteLine("2. From Fahrenheit to Celsius.");
        Console.Write(":");

        string? selection = Console.ReadLine();
        double F, C = 0;

        switch (selection)
        {
            case "1":
                Console.Write("Please enter the Celsius temperature: ");
                F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine() ?? "0");
                Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                break;

            case "2":
                Console.Write("Please enter the Fahrenheit temperature: ");
                C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine() ?? "0");
                Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                break;

            default:
                Console.WriteLine("Please select a convertor.");
                break;
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
