namespace Problems.Common
{
    public enum NodePosition
    {
        left,
        right,
        center
    }

    public class TreeNode
    {
        public int item;
        public TreeNode left;
        public TreeNode right;

        public TreeNode( int item )
        {
            this.item = item;
        }

        private void PrintValue( string value, NodePosition nodePosition )
        {
            switch ( nodePosition )
            {
                case NodePosition.left:
                    PrintLeftValue( value );
                    break;
                case NodePosition.right:
                    PrintRightValue( value );
                    break;
                case NodePosition.center:
                    Console.WriteLine( value );
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void PrintLeftValue( string value )
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write( "L:" );
            Console.ForegroundColor = value == "-" ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine( value );
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void PrintRightValue( string value )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( "R:" );
            Console.ForegroundColor = value == "-" ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine( value );
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void PrintPretty( string indent, NodePosition nodePosition, bool last, bool empty )
        
        {
            Console.Write( indent );
            if ( last )
            {
                Console.Write( "└─" );
                indent += "  ";
            }
            else
            {
                Console.Write( "├─" );
                indent += "| ";
            }

            string stringValue = empty ? "-" : item.ToString();
            PrintValue( stringValue, nodePosition );

            if ( !empty && ( left != null || right != null ) )
            {
                if ( left != null )
                {
                    left.PrintPretty( indent, NodePosition.left, false, false );
                }
                else
                {
                    PrintPretty( indent, NodePosition.left, false, true );
                }

                if ( right != null )
                {
                    right.PrintPretty( indent, NodePosition.right, true, false );
                }
                else
                {
                    PrintPretty( indent, NodePosition.right, true, true );
                }
            }
        }
    }

    public class BTree
    {
        private readonly IComparer<int> _comparer = Comparer<int>.Default;
        private int _count;
        private TreeNode _root;


        public BTree()
        {
            _root = null;
            _count = 0;
        }


        public bool Add( int Item )
        {
            if ( _root == null )
            {
                _root = new TreeNode( Item );
                _count++;
                return true;
            }

            return Add_Sub( _root, Item );
        }

        private bool Add_Sub( TreeNode Node, int Item )
        {
            if ( _comparer.Compare( Node.item, Item ) < 0 )
            {
                if ( Node.right == null )
                {
                    Node.right = new TreeNode( Item );
                    _count++;
                    return true;
                }

                return Add_Sub( Node.right, Item );
            }

            if ( _comparer.Compare( Node.item, Item ) > 0 )
            {
                if ( Node.left == null )
                {
                    Node.left = new TreeNode( Item );
                    _count++;
                    return true;
                }

                return Add_Sub( Node.left, Item );
            }

            return false;
        }

        public void Print()
        {
            _root.PrintPretty( "", NodePosition.center, true, false );
        }
    }
}