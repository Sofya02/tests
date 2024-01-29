using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Сортировка массива + ввод/вывод с клавиатуры
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Введите число: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numbers);

        Console.WriteLine("Отсортированный массив:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // 2. Рекурсивная функция (числа Фибоначчи)
        int n = 10;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }

        // 3. Передача параметров в функцию по ссылке/значению
        int a = 10;
        ChangeValue(a); // передача по значению
        Console.WriteLine(a); // выведет 10

        ChangeValue(ref a); // передача по ссылке
        Console.WriteLine(a); // выведет 20

        // 4. Сверка с референсом
        string str1 = "Hello";
        string str2 = "Hello";

        Console.WriteLine(ReferenceEquals(str1, str2)); // выведет True

        // 5. В логических операциях деление на 0 и exception
        int numerator = 10;
        int denominator = 0;

        bool result = denominator != 0 && numerator / denominator > 0;

        Console.WriteLine(result); // выведет False
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
