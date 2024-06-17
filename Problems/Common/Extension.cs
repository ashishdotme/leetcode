using System.Text;

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

        public static string PrintList<T>( this IList<T> list )
        {
            return "[" + string.Join( ", ", list ) + "]";
        }

        public static void Print( this int[] list )
        {
            TestContext.WriteLine( "[" + string.Join( ", ", list ) + "]" );
        }

        public static void Print( this char[] list )
        {
            TestContext.WriteLine( "[" + string.Join( ", ", list ) + "]" );
        }

        public static void Print<T>( this List<T> list )
        {
            TestContext.WriteLine( "[" + string.Join( ", ", list ) + "]" );
        }

        public static void Print<T>( this List<List<T>> listOfLists )
        {
            TestContext.WriteLine( "[" + string.Join( ", ", listOfLists.Select( l => l.PrintList() ) ) + "]" );
        }

        public static void Print<T>( this IList<IList<T>> listOfLists )
        {
            TestContext.WriteLine( "[" + string.Join( ", ", listOfLists.Select( l => l.PrintList() ) ) + "]" );
        }

        public static void Print<T>( this List<IList<T>> listOfLists )
        {
            TestContext.WriteLine( "[" + string.Join( ", ", listOfLists.Select( l => l.PrintList() ) ) + "]" );
        }

        public static string ToMatrixString<T>( this T[,] matrix, string delimiter = "\t" )
        {
            var s = new StringBuilder();

            for ( var i = 0; i < matrix.GetLength( 0 ); i++ )
            {
                for ( var j = 0; j < matrix.GetLength( 1 ); j++ )
                {
                    s.Append( matrix[i, j] ).Append( delimiter );
                }

                s.AppendLine();
            }

            return s.ToString();
        }

    }
}