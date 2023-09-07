namespace DFSDemo
{
    public class TreeNode
    {
        public TreeNode(int val)
        {
            Val = val;
            Left = null;
            Right = null;
        }

        public int Val { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }
}