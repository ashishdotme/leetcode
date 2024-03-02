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
            foreach ( T item in list )
            {
                action( item );
            }
        }

        public static string PrintList<T>( this List<T> list )
        {
            return "[" + string.Join( ", ", list ) + "]";
        }

        public static void Print( this int[] list )
        {
            Console.WriteLine( "[" + string.Join( ", ", list ) + "]" );
        }

        public static void Print<T>( this List<T> list )
        {
            Console.WriteLine( "[" + string.Join( ", ", list ) + "]" );
        }

        public static void Print<T>( this List<List<T>> listOfLists )
        {
            Console.WriteLine( "[" + string.Join( ", ", listOfLists.Select( l => l.PrintList() ) ) + "]" );
        }
    }
}