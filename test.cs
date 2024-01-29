using System;

class Program
{
     static void Main(string[] args)
     {
         // 1. Array sorting + keyboard input/output
         int[] numbers = new int[5];
         for (int i = 0; i < numbers.Length; i++)
         {
             Console.Write("Enter a number: ");
             numbers[i] = Convert.ToInt32(Console.ReadLine());
         }

         Array.Sort(numbers);

         Console.WriteLine("Sorted array:");
         foreach (int number in numbers)
         {
             Console.WriteLine(number);
         }

         // 2. Recursive function (Fibonacci numbers)
         int n = 10;
         for (int i = 0; i < n; i++)
         {
             Console.WriteLine(Fibonacci(i));
         }

         // 3. Passing parameters to a function by reference/value
         int a = 10;
         ChangeValue(a); // passing by value
         Console.WriteLine(a); // will print 10

         ChangeValue(ref a); // passing by reference
         Console.WriteLine(a); // will print 20

         // 4. Verification with reference
         string str1 = "Hello";
         string str2 = "Hello";

         Console.WriteLine(ReferenceEquals(str1, str2)); // will print True

         // 5. In logical operations, division by 0 and exception
         int numerator = 10;
         int denominator = 0;

         bool result = denominator != 0 && numerator / denominator > 0;

         Console.WriteLine(result); // will print False
     }

     static int Fibonacci(int n)
     {
         if (n <= 1)
             return n;
         else
             return Fibonacci(n - 1) + Fibonacci(n - 2);
     }

     static void ChangeValue(int x)
     {
         x += 10;
     }

     static void ChangeValue(ref int x)
     {
         x += 10;
     }
}