using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483_playground.Scenarios
{
    class BinarySearchArray
    {
        static int BinarySearch(int[] sortedArray, int value)
        {
            int min = 0;
            int max = sortedArray.Length - 1;

            while(true)
            {
                int mid = min + (max - min) / 2;

                if(min > max)
                    return -1;
                else if(sortedArray[mid] < value)
                    min = mid + 1;
                else if(sortedArray[mid] > value)
                    max = mid - 1;
                else
                    return mid;
            }
        }

        static void Main(string[] args)
        {
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.WriteLine($"Found at index: {BinarySearch(sortedArray, 21)}");
            Console.ReadKey();
        }
    }
}
