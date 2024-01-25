using System;

class Program
{
     //while
    int i = 0;
    while (i < 5)
    {
        Console.WriteLine(i);
        i++;
    }

    //do - while
    int i = 0;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i < 5);

    //for
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(i);
    }

    //foreach
    int[] numbers = { 1, 2, 3, 4, 5 };
    foreach(int number in numbers)
    {
        Console.WriteLine(number);
    }

    //foreach 
    string[] names = { "John", "Jane", "Bob", "Alice" };
    foreach(string name in names)
    {
        Console.WriteLine(name);
    }


    //Bubble Sort
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

    //Fibonacci
    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }

        Swap(ref array[i + 1], ref array[high]);
        return i + 1;
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;

            if (array[mid] < target)
                left = mid + 1;

            else
                right = mid - 1;
        }

        return -1;
    }

    class Node
    {
        public int value;
        public List<Node> children = new List<Node>();
    }

    static void DFS(Node node)
    {
        if (node == null)
            return;

        Console.WriteLine(node.value);

        foreach (var child in node.children)
        {
            DFS(child);
        }
    }

    static void BFS(Node root)
    {
        if (root == null)
            return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node node = queue.Dequeue();
            Console.WriteLine(node.value);

            foreach (var child in node.children)
            {
                queue.Enqueue(child);
            }
        }
    }

    static int EuclideanAlgorithm(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }

    class HashTable
    {
        private const int TableSize = 100;
        private LinkedList<KeyValuePair<int, string>>[] table;

        public HashTable()
        {
            table = new LinkedList<KeyValuePair<int, string>>[TableSize];
        }

        private int HashFunction(int key)
        {
            return key % TableSize;
        }

        public void Insert(int key, string value)
        {
            int index = HashFunction(key);
            
            if (table[index] == null)
                table[index] = new LinkedList<KeyValuePair<int, string>>();

            table[index].AddLast(new KeyValuePair<int, string>(key, value));
        }

        public string Search(int key)
        {
            int index = HashFunction(key);

            if (table[index] != null)
            {
                foreach (var item in table[index])
                {
                    if (item.Key == key)
                        return item.Value;
                }
            }

            return null;
        }
    }

    public class Node2
    {
        public int Data;
        public Node2 Left;
        public Node2 Right;

        public Node2(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree
    {
        public Node2 Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Root = InsertRecursive(Root, data);
        }

        private Node2 InsertRecursive(Node2 root, int data)
        {
            if (root == null)
            {
                root = new Node2(data);
                return root;
            }

            if (data < root.Data)
            {
                root.Left = InsertRecursive(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InsertRecursive(root.Right, data);
            }

            return root;
        }
    
        public void PrintInorder()
        {
            InorderTraversal(Root);
        }

        private void InorderTraversal(Node2 root)
        {
            if (root != null)
            {
                InorderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InorderTraversal(root.Right);
            }
        }
    }


    static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Before:");
        foreach(int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        BubbleSort(arr);

        Console.WriteLine("After:");
        foreach(int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.ReadLine();

        int n = 10; // Number of Fibonacci numbers to calculate
        Console.WriteLine("Fibonacci numbers:");
        for (int i = 0; i < n; i++)
        {
            int fibonacciNumber = Fibonacci(i);
            Console.Write(fibonacciNumber + " ");
        }

        //for loop with multiple expressions
        for (int i=0, j=0; i+j<=5; i++, j++)
        {
            Console.WriteLine("i = {0} and j = {1}", i,j);
        }

        //For loop without declaring counter and iterator
        int i = 1;
        for ( ; i<=5; )
        {
            Console.WriteLine("For C# loop: iteration {0}", i);
            i++;
        }

        //Infinite for loop
        for (int i=1 ; i > 0; i++)
        {
            Console.WriteLine("For C# loop: iteration {0}", i);
        }
    }
}
