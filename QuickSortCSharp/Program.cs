using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSortCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nProgram for sorting a numeric array using Quick Sorting");

            Console.Write("\n\nEnter number of elements: ");

            int max = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");

                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input int array  : ");

            Console.Write("\n");

            for (int k = 0; k < max; k++)
            {
                Console.Write(numbers[k] + " ");

                Console.Write("\n");
            }

            Console.WriteLine("QuickSort By Recursive Method");

            SortQuick(numbers, 0, max - 1);

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();

        }

        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];

            while (true)
            {
                while (numbers[left] < pivot)
                {
                    left++;
                }

                while (numbers[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    int temp = numbers[right];

                    numbers[right] = numbers[left];

                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public void SortQuick(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    SortQuick(arr, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    SortQuick(arr, pivot + 1, right);
                }
            }

        }
    }
}

//int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

//int temp = 0;

//for (int write = 0; write < arr.Length; write++) {
//    for (int sort = 0; sort < arr.Length - 1; sort++) {
//        if (arr[sort] > arr[sort + 1]) {
//            temp = arr[sort + 1];
//            arr[sort + 1] = arr[sort];
//            arr[sort] = temp;
//        }
//    }
//}

//for (int i = 0; i < arr.Length; i++)
//    Console.Write(arr[i] + " ");

//Console.ReadKey();







//using System;
//namespace SortingExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] number = { 89, 76, 45, 92, 67, 12, 99 };
//            bool flag = true;
//            int temp;
//            int numLength = number.Length;

//            //sorting an array
//            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
//            {
//                flag = false;
//                for (int j = 0; j < (numLength - 1); j++)
//                {
//                    if (number[j + 1] > number[j])
//                    {
//                        temp = number[j];
//                        number[j] = number[j + 1];
//                        number[j + 1] = temp;
//                        flag = true;
//                    }
//                }
//            }

//            //Sorted array
//            foreach (int num in number)
//            {
//                Console.Write("\t {0}",num);
//            }
//            Console.Read();
//        }
//    }
//}