using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Search
    {   /// <summary>
        /// Search of element by binary search
        /// </summary>
        /// <typeparam name="T">type of objects</typeparam>
        /// <param name="arr">sorted array of objects</param>
        /// <param name="value">element to be searched</param>
        /// <param name="comparer">logic of compearing elements</param>
        /// /// <exception cref="ArgumentNullException"> arr is null</exception>
        /// <returns>index of element</returns>
        public static int BinarySearch<T>(T[] arr, T value) => BinarySearch(arr, value, null);
        /// <summary>
        /// Search of element by binary search
        /// </summary>
        /// <typeparam name="T">type of objects</typeparam>
        /// <param name="arr">sorted array of objects</param>
        /// <param name="value">element to be searched</param>
        /// <param name="comparer">logic of compearing elements</param>
        /// /// <exception cref="ArgumentNullException"> arr is null</exception>
        /// <returns>index of element</returns>
        public static int BinarySearch<T>(T[] arr, T value, Comparison<T> comparer)
        {
            if (arr==null) throw new ArgumentNullException($"{nameof(arr)} must not be null");
            if (arr.Length == 0) return -1;

            if (comparer == null) comparer = Comparisions.Default;
            if(!CheckOrder(arr,comparer)) throw new ArgumentException($"{nameof(arr)} is not an ordered array");
            

            int left = 0;
            int right = arr.Length;
            int mid = 0;

            while (left < right)
            {
                mid = left + (right - left) / 2;

                if (comparer(arr[mid], value) == 0)
                    return mid;

                if (comparer(arr[mid], value) > 0)
                    right = mid;
                else
                    left = mid + 1;
            }

            return -(1 + left);
        }

        private static bool CheckOrder<T>(T[] arr,Comparison<T> comparer)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (comparer(arr[i],arr[i+1])>0) return false;
            }
            return true;
        }
    }
}
