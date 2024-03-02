using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problems.Common
{
    public static class Extension
    {
        public static void MethodEx<T>( this T item )
        {
            Console.WriteLine( item );
        }

        public static void CallForEach<T>( this List<T> list, Action<T> action )
        {
            foreach ( var item in list )
                action( item );
        }

        public static string PrintList<T>( this List<T> list ) => "[" + string.Join( ", ", list ) + "]";
        public static void Print<T>( this List<T> list ) => Console.WriteLine("[" + string.Join( ", ", list ) + "]");
        public static void Print<T>( this List<List<T>> listOfLists ) => Console.WriteLine("[" + string.Join( ", ", listOfLists.Select( l => l.PrintList() ) ) + "]");
    }
}