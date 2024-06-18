namespace Assignment_7._2._1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of elements: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Enter element {i + 1}: ");
                    arr[i] = int.TryParse(Console.ReadLine(), out int num) ? num : 0;
                }

                ShellSort(arr);

                Console.WriteLine("Sorted array:");
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        static void ShellSort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i], j = i;
                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }
                    arr[j] = temp;
                }
            }
        }
    }
}