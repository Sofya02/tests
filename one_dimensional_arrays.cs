// Одномерные массивы (или контейнеры), 
// операция доступа к элементу массива
using System;

class Program
{
    struct BOOK
    {
        public string title; // book title
        public string author; // name of the author of the book
        public int year; // the year of publishing
        public float price; // price
    }

    // class that describes a point on the coordinate plane
    class MyPoint
    {
        // point coordinates
        int x;
        int y;

        // properties
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }

    public static void WorkWithArray(int[] arr)
    {        
        arr[0] = 123;
    }
    static void Main()
    {
        // declaration and use of a one-dimensional array of structures
        BOOK[] B; // declaration of a variable of type "array of BOOK structures"
        B = new BOOK[5]; // allocate memory for 5 structures of type BOOK

        // filling array B with values
        B[0].title = "Beginning. Microsoft. Visual C# 2008.";
        B[0].author = "Karli Watson, Christian Nagel, Jacob Hammer Pedersen, Jon D. Reid";
        B[0].year = 2008;
        B[0].price = 9.99f;

        B[1].title = "Pro C# 2010 and the .Net Planform. Fifth edition";
        B[1].author = "Andrew Troelsen";
        B[1].year = 2010;
        B[1].price = 9.99f;


        // declaration of an array of 5 objects of type class "MyPoint"
        // allocate memory for the array
        MyPoint[] MP = new MyPoint[5];

        // memory allocation for any object is mandatory!
        for (int i = 0; i < 5; i++)
            MP[i] = new MyPoint();

        // use an array of objects in the program
        // filling the array with arbitrary values
        for (int i = 0; i < 5; i++)
        {
            MP[i].X = i * 3;
            MP[i].Y = i * i - 2;
        }


        // Declare and initialize an array of objects
        object[] arrByObject = { true, 10, "Hello", 13.7m };

        // Print the type of each array member to the console
        foreach (object me in arrByObject)
            Console.WriteLine("Type {0} - {1}",me,me.GetType());

        Console.ReadLine();


        // Create a one-dimensional array
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

        // Access to array elements
        Console.WriteLine("Array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int[] array = new int[5];
        string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

        Console.WriteLine(weekDays[0]);
        Console.WriteLine(weekDays[1]);
        Console.WriteLine(weekDays[2]);
        Console.WriteLine(weekDays[3]);
        Console.WriteLine(weekDays[4]);
        Console.WriteLine(weekDays[5]);
        Console.WriteLine(weekDays[6]);

        int[] nums2 = new int[4] { 1, 2, 3, 5 };
 
        int[] nums3 = new int[] { 1, 2, 3, 5 };
        
        int[] nums4 = new[] { 1, 2, 3, 5 };
        
        int[] nums5 = { 1, 2, 3, 5 };

        int[] numbers = { 3, 5, 1, 8, 2, 9, 4 };

        int max = numbers[0];
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"Maximum value: {max}");
        Console.WriteLine($"Minimum value: {min}");

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of elements: {sum}");

        int[] firstArray = { 1, 3, 5 };
        int[] secondArray = { 2, 4, 6 };
        int[] mergedArray = new int[firstArray.Length + secondArray.Length];
        Array.Copy(firstArray, mergedArray, firstArray.Length);
        Array.Copy(secondArray, 0, mergedArray, firstArray.Length, secondArray.Length);

        bool[] ba1 = new bool[3];
        Console.WriteLine("ba1[0]: " + ba1[0].ToString());  

        string[] sa1 = new string[3];
        sa1[0] = "abc";
        sa1[1] = "def";
        sa1[2] = "ghi";
        Console.WriteLine($"sa1: {sa1[0]}, {sa1[1]}, {sa1[2]}");

        double[] da1 = new double[3] {0.1, 0.2, 0.3};
        Console.WriteLine($"da1: {da1[0]}, {da1[1]}, {da1[2]}");

        double[] da2 = {0.4, 0.5, 0.6};
        Console.WriteLine($"da2: {da2[0]}, {da2[1]}, {da2[2]}");

        int[] na4 = {1, 2, 3, 4, 5};
        Console.WriteLine($"na4[0]: {na4[0]}");
        for(int i = 0; i < na4.Length; i++)
        {
            Console.Write(na4[i].ToString() + " ");
        }

        int[] na5 = {1, 2, 3, 4, 5};           
        foreach(int v in na5) 
            Console.Write(v + " ");
                
        Console.WriteLine();

        WorkWithArray(na5);

        foreach(int v in na5) 
            Console.Write(v + " ");

    }
}