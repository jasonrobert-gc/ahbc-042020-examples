using System;
using System.Collections.Generic;
using System.Linq;

namespace Class27
{
    public class Program
    {
        static void Main(string[] args)
        {
            var unsorted = new int[] { 3, 2, 5, 1, 7, 9};
            //var sorted = BubbleSort(unsorted);
            var sorted = MergeSort(new List<int>(unsorted));

            var found = LinearSearch(sorted, 4);
        }

        public static bool LinearSearch(List<int> sorted, int value)
        {
            if (sorted == null)
            {
                return false;
            }

            foreach (var item in sorted)
            {
                if (item == value)
                {
                    return true;
                }
            }

            return false;
        }

        public  static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            // Split
            var left = new List<int>();
            var right = new List<int>();

            var middle = unsorted.Count / 2;
            
            // Populate Left
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            // Populate Right
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                // left and right has contents
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right.First());
                        right.RemoveAt(0);
                    }
                }

                // only left has contents, right is empty
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }

                // only right has contents, left is empty
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }

            return result;
        }

        public static int[] BubbleSort(int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = i; j < unsorted.Length; j++)
                {
                    if (unsorted[j] < unsorted[i])
                    {
                        // Swap
                        var temp = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }

            return unsorted;
        }
    }
}
