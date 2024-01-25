// +Локальные переменные встроенных типов данных:
// •	целые числа (один тип),
// •	символы 
// •	строки
// Выражения с использованием локальных переменных, арифметических операций (4 вида), операций сравнения и присваивания

Вот пример кода на C# с использованием локальных переменных встроенных типов данных:

using System;

class Program
{
    static void Main(string[] args)
    {
        // Локальные переменные целых чисел
        int num1 = 10;
        int num2 = 5;

        // Локальные переменные символов
        char char1 = 'A';
        char char2 = 'B';

        // Локальные переменные строк
        string str1 = "Hello";
        string str2 = "World";

        // Арифметические операции
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        int quotient = num1 / num2;

        // Операции сравнения
        bool isEqual = num1 == num2;
        bool isGreater = num1 > num2;
        bool isLess = num1 < num2;
        bool equal = num1 == num2;
        bool notEqual = num1 != num2;
        bool greater = num1 > num2;
        bool less = num1 < num2;
        bool greaterOrEqual = num1 >= num2;
        bool lessOrEqual = num1 <= num2;
        bool equal = char1 == char2;
        bool notEqual = char1 != char2;
        bool equal = str1 == str2;
        bool notEqual = str1 != str2;

        // Операции присваивания
        int x = sum;
        char ch = char1;
        string message = str1 + " " + str2;


        // Вывод результатов
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Quotient: " + quotient);
        Console.WriteLine("Is Equal: " + isEqual);
        Console.WriteLine("Is Greater: " + isGreater);
        Console.WriteLine("Is Less: " + isLess);
        Console.WriteLine("x: " + x);
        Console.WriteLine("ch: " + ch);
        Console.WriteLine("Message: " + message);
        Console.WriteLine("Are the numbers equal: " + equal);
        Console.WriteLine("Are the numbers not equal: " + notEqual);
        Console.WriteLine("The first number is greater than the second: " + greater);
        Console.WriteLine("The first number is less than the second: " + less);
        Console.WriteLine("The first number is greater than or equal to the second: " + greaterOrEqual);
        Console.WriteLine("The first number is less than or equal to the second: " + lessOrEqual);
        Console.WriteLine("Characters are equal: " + equal);
        Console.WriteLine("Characters are not equal: " + notEqual);
        Console.WriteLine("Lines are equal: " + equal);
        Console.WriteLine("Lines are not equal: " + notEqual);
    }
}