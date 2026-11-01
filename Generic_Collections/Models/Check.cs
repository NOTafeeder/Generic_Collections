using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Collections.Models
{
    public class Check<T>
    {
        public static bool CheckEqual(T item, T item2)
        {
            return EqualityComparer<T>.Default.Equals(item, item2);
        }
    }
}
