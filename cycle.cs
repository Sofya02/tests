using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("������ �� ����������:");
        foreach(int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        BubbleSort(arr);

        Console.WriteLine("������ ����� ����������:");
        foreach(int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.ReadLine();
    }


    //�������� ����� while
    int i = 0;
    while (i < 5)
    {
        Console.WriteLine(i);
        i++;
    }

    //�������� ����� do - while
    int i = 0;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i < 5);

    //�������� ����� for
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(i);
    }

    //�������� ����� foreach(��� ��������� �����)
    int[] numbers = { 1, 2, 3, 4, 5 };
    foreach(int number in numbers)
    {
        Console.WriteLine(number);
    }


    //�������� ����� foreach (��� ��������� �����)
    string[] names = { "John", "Jane", "Bob", "Alice" };
    foreach(string name in names)
    {
        Console.WriteLine(name);
    }
}
