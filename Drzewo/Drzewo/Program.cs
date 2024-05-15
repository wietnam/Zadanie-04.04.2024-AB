internal class Program
{
    private static void Main(string[] args)
    {
        TreeNode root = new TreeNode(5);
        root.Add(8);
        root.Add(5);
        root.Add(4);
        root.Add(7);
        root.Add(3);
        root.Add(1);
        root.Add(6);
        root.Add(2);

        Console.WriteLine(root.Search(7).Value);
    }
    public class TreeNode
    {
        public int Value { get; private set; }
        public TreeNode Left { get; private set; }
        public TreeNode Right { get; private set; }

        public TreeNode(int value)
        {
            Value = value;
        }

        public void Add(int value)
        {
            if (value % 2 == 0)
            {
                if (Left == null)
                {
                    Left = new TreeNode(value);
                }
                else
                {
                    Left.Add(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new TreeNode(value);
                }
                else
                {
                    Right.Add(value);
                }
            }
        }

        public TreeNode Search(int value)
        {
            if (Value == value)
            {
                return this;
            }
            else if (value % 2 == 0 && Left != null)
            {
                return Left.Search(value);
            }
            else if (value % 2 != 0 && Right != null)
            {
                return Right.Search(value);
            }
            else
            {
                return null;
            }
        }
    }

}