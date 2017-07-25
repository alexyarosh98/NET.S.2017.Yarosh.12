using System;
using System.Collections.Generic;
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
    }
}
