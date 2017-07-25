using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using NUnit.Framework;

namespace BinarySearch.Tests
{
    [TestFixture]
    public class SearchTests
    {
        [TestCase(new[] {1,4,61,64,71,431 }, 64, ExpectedResult = 3)]
        [TestCase(new[] {1,4,12,424,523,526 }, 1, ExpectedResult = 0)]
        [TestCase(new[] { -421,4,45,63,124,532,612,4444 }, 612, ExpectedResult = 6)]
        [TestCase(new[] { 21,42,4124,5555,66634 }, 66634, ExpectedResult = 4)]
        [TestCase(new[] { -421, 4, 6, 8, 122, 445, 615 }, 4, ExpectedResult = 1)]
        [TestCase(new[] { 1, 4, 7, 10, 14, 415, 655 }, 3, ExpectedResult = -2)]
        [TestCase(new int[0], 3, ExpectedResult = -1)]
        public static int BinarySearch_ArrayWithDefaultComparison_Index(int[] arr, int value)
        {
            return Search.BinarySearch(arr, value,null);
        }

        [TestCase(new[] {1,4,5,7,0},4)]
        public static void BinarySearch_NotOrderdArray_ArgumentException(int[]arr, int value)
        {
            var ex = Assert.Catch <ArgumentException> (() => Search.BinarySearch(arr, value));

            StringAssert.Contains($"{nameof(arr)} is not an ordered array",ex.Message);
        }
    }
}
