using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingAlgorithms
{
    class Program
    {
        public static void exchange(int[] data, int m, int n)
        {
            int temporary;
            // Appreciation to anh.cs.luc.edu/
            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Loading file...");
            int[] list = readFromFile();
            Console.WriteLine("File loaded.");
            Console.WriteLine("Choose a sorting algorithm:");
            Console.WriteLine();
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.WriteLine();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bubbleSort(list);
                    break;
                case "2":
                    insertionSort(list);
                    break;
                default:
                    Console.WriteLine("Not a valid choice.");
                    break;

            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        static int[] readFromFile() // thank you Cameron for writing this out before!
        {
            {
                string fileContents = File.ReadAllText("C:\\dev\\data\\unsorted-numbers.txt");

                string[] numbersAsStrings = fileContents.Split(',');

                int[] numbers = new int[numbersAsStrings.Length];

                for (int i = 0; i < numbersAsStrings.Length; i++)
                {
                    numbers[i] = int.Parse(numbersAsStrings[i]);
                }

                return numbers;
            }
        }

        static void bubbleSort(int[] list)
        {
            printList("Unsorted List", list);
            int ichi, ni;
            int List = list.Length;

            for (ni = List - 1; ni > 0; ni--)
            {
                for (ichi = 0; ichi < ni; ichi++)
                {
                    if (list[ichi] > list[ichi + 1])
                        exchange(list, ichi, ichi + 1);
                }
            }
            printList("Sorted List", list);
        }

        static void insertionSort(int[] list)
        {
            printList("Unsorted List", list);
            int uno, dos;
            int List = list.Length;

            for (dos = 1; dos < List; dos++)
            {
                for (uno = dos; uno > 0 && list[uno] < list[uno - 1]; uno--)
                {
                    exchange(list, uno, uno - 1);
                }

            }
            printList("Sorted List", list);
        }

        static void printList(string listName, int[] list)
        {
            Console.WriteLine("-- " + listName + " --");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}

