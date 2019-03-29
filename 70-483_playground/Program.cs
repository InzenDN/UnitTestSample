using System;
using System.Diagnostics;

namespace Playground
{
    public class SortAlgorithm
    {
        public void SelectionSort(IComparable[] a)
        {
            int N = a.Length;

            for(int i = 0; i < N; i++)
            {
                int min = i;
                for(int j = i + 1; j < N; j++)
                    if(Compare(a[j], a[min]))
                        min = j;
                Exchange(a, i, min);
            }
        }

        public bool Compare(IComparable x, IComparable y)
        {
            return x.CompareTo(y) < 0;
        }

        public void Exchange(IComparable[] a, int i, int j)
        {
            IComparable t = a[i];
            a[i] = a[j];
            a[j] = t;
        }

        public void Print(IComparable[] a)
        {
            for(int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]} ");
            Console.WriteLine();
        }

        public bool IsSorted(IComparable[] a)
        {
            for(int i = 1; i < a.Length; i++)
                if(Compare(a[i], a[i - 1]))
                    return false;
            return true;
        }
    }

    class Program
    {        
        static void Main(string[] args)
        {
            var sort = new SortAlgorithm();
            var bacon = new string[] { "I", "A", "H", "C", "F", "E", "D", "G", "B" };

            sort.SelectionSort(bacon);
            Debug.Assert(sort.IsSorted(bacon) == true);
        }
    }
}