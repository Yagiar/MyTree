namespace MyTree
{
    internal class MyTreeNode<T>
    {
        T value;
        public MyTreeNode<T> left;
        public MyTreeNode<T> right;
        int count;
        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public MyTreeNode()
        {

        }
        public MyTreeNode(T key)
        {
            value = key;
        }
    }
}