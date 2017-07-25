using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Comparisions
    {
        public static int Default<T>(T arr,T arr2) => arr.GetHashCode().CompareTo(arr2.GetHashCode());
        
    }
}
