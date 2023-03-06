using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    internal class MyTree<T> where T : IComparable<T>
    {
        MyTreeNode<T> Root;

        List<T> nodeKeys = new List<T>();
        private void TValues(MyTreeNode<T> subtree)
        {
            if (subtree != null)
            {
                nodeKeys.Add(subtree.Value);
                TValues(subtree.left);
                TValues(subtree.right);
            }
        }

        public void BalanceNOW()
        {
            TValues(Root);
            Root = null; //Удаление дерева
            for (int i = 0; i < nodeKeys.Count; i++)
            {
                Root = AddNodeAVL(Root, nodeKeys[i]);
            }
            nodeKeys.Clear();
        }

        //Удаление узла
        public void Remove(T value, bool AVL)
        {
            if (AVL)
            {
                Root = RemoveAVL(Root, value);
            }
            else
            {
                if (Root != null && Root.Value.CompareTo(value) == 0)
                {
                    if (Root.left == null && Root.right == null) { Root = null; return; }
                    if (Root.left == null) { Root = Root.right; return; }
                    if (Root.right == null) { Root = Root.left; return; }
                    MyTreeNode<T> subtree = Root.left;
                    Root = Root.right;
                    MyTreeNode<T> min = Root;
                    while (min.left != null) min = min.left;
                    min.left = subtree;
                    return;
                }
                Remove(value, Root);
            }
        }

        //Удаление узла АВЛ дерева
        private MyTreeNode<T> RemoveAVL(MyTreeNode<T> node, T key)
        {
            if (node == null) return null;
            if (key.CompareTo(node.Value) < 0) node.left = RemoveAVL(node.left, key);
            else if (key.CompareTo(node.Value) > 0) node.right = RemoveAVL(node.right, key);
            else
            {
                MyTreeNode<T> left = node.left;
                MyTreeNode<T> right = node.right;
                if (right == null) return left;
                MyTreeNode<T> min = GetMin(right);
                min.right = RemoveMin(right);
                min.left = left;
                return Balance(min);
            }
            return Balance(node);
        }

        private MyTreeNode<T> GetMin(MyTreeNode<T> subroot)
        {
            if (subroot.left == null) return subroot;
            return GetMin(subroot.left);
        }

        private MyTreeNode<T> RemoveMin(MyTreeNode<T> subroot)
        {
            if (subroot.left == null) return subroot.right;
            subroot.left = RemoveMin(subroot.left);
            return Balance(subroot);
        }

        //Удаление узла НЕ АВЛ дерева
        private void Remove(T value, MyTreeNode<T> subroot)
        {
            if (subroot == null) return;
            MyTreeNode<T> subtree = null;
            if (subroot.left != null && subroot.left.Value.CompareTo(value) == 0)
            {
                //Лист
                if (subroot.left.left == null && subroot.left.right == null) { subroot.left = null; return; }

                //Одно поддерево
                if (subroot.left.left == null) subtree = subroot.left.right;
                if (subroot.left.right == null) subtree = subroot.left.left;
                if (subtree != null) { subroot.left = subtree; return; }

                //Два поддерева
                subtree = subroot.left.left;
                subroot.left = subroot.left.right;
                MyTreeNode<T> min = subroot.left;
                while (min.left != null) min = min.left;
                min.left = subtree;
                return;
            }
            if (subroot.right != null && subroot.right.Value.CompareTo(value) == 0)
            {
                //Лист
                if (subroot.right.left == null && subroot.right.right == null) { subroot.right = null; return; }

                //Одно поддерево
                if (subroot.right.left == null) subtree = subroot.right.right;
                if (subroot.right.right == null) subtree = subroot.right.left;
                if (subtree != null) { subroot.right = subtree; return; }

                //Два поддерева
                subtree = subroot.right.left;
                subroot.right = subroot.right.right;
                MyTreeNode<T> min = subroot.right;
                while (min.left != null) min = min.left;
                min.left = subtree;
                return;
            }
            if (subroot.Value.CompareTo(value) < 0) Remove(value, subroot.right);
            if (subroot.Value.CompareTo(value) > 0) Remove(value, subroot.left);
        }

        //Добавление узла
        public void Add(T key, bool AVL)
        {
            if (AVL)
            {
                Root = AddNodeAVL(Root, key);
            }
            else
            {
                Root = AddNode(Root, key);
            }
        }

        //Добавление АВЛ узла
        private MyTreeNode<T> AddNodeAVL(MyTreeNode<T> node, T key)
        {
            if (node == null)
            {
                return new MyTreeNode<T>(key);
            }
            else if (node.Value.CompareTo(key) > 0)
            {
                node.left = AddNodeAVL(node.left, key);
            }
            else if (node.Value.CompareTo(key) < 0)
            {
                node.right = AddNodeAVL(node.right, key);
            }
            else
            {
                node.Count++;
            }
            return Balance(node);
        }

        // Добавление НЕ АВЛ узла
        private MyTreeNode<T> AddNode(MyTreeNode<T> node, T key)
        {
            if (node == null)
            {
                return new MyTreeNode<T>(key);
            }
            else if (node.Value.CompareTo(key) > 0)
            {
                node.left = AddNode(node.left, key);
            }
            else if (node.Value.CompareTo(key) < 0)
            {
                node.right = AddNode(node.right, key);
            }
            else
            {
                node.Count++;
            }
            return node;
        }

        //Найти узел
        public MyTreeNode<T> findNode(T value)
        {
            return findNode(value, Root);
        }

        private MyTreeNode<T> findNode(T value, MyTreeNode<T> subroot)
        {
            if (Root == null) return null;
            else if (value.CompareTo(subroot.Value) < 0) return findNode(value, subroot.left);
            else if (value.CompareTo(subroot.Value) > 0) return findNode(value, subroot.right);
            else return subroot;
        }

        //Глубина дерева
        public int GetDeep()
        {
            return GetDeep(Root);
        }
        //Глубина узла
        public int GetDeep(MyTreeNode<T> subroot)
        {
            if (subroot == null) return 0;
            return 1 + Math.Max(GetDeep(subroot.left), GetDeep(subroot.right));
        }
        //Количество листьев
        public int GetLeafs()
        {
            return GetLeafs(Root);
        }

        private int GetLeafs(MyTreeNode<T> subroot)
        {
            if (subroot == null) return 0;
            if (subroot.left == null && subroot.right == null) return 1;
            return GetLeafs(subroot.left) + GetLeafs(subroot.right);
        }

        //Количество узлов
        public int GetNodes()
        {
            return GetNodes(Root);
        }

        private int GetNodes(MyTreeNode<T> subroot)
        {
            if (subroot == null) return 0;
            return 1 + GetNodes(subroot.left) + GetNodes(subroot.right);
        }

        //NLR words
        public string NLR_Words()
        {
            return NLR_Words(Root);
        }

        private string NLR_Words(MyTreeNode<T> subroot)
        {
            if (subroot == null) return "";
            return " ;" + subroot.Value + " - " + (subroot.Count + 1) + "; " + NLR_Words(subroot.left) + NLR_Words(subroot.right);
        }

        //LNR
        public string LNR()
        {
            return LNR(Root);
        }

        private string LNR(MyTreeNode<T> subroot)
        {
            if (subroot == null) return "";
            return LNR(subroot.left) + " " + subroot.Value + " " + LNR(subroot.right);
        }

        //NLR
        public string NLR()
        {
            return NLR(Root);
        }

        private string NLR(MyTreeNode<T> subroot)
        {
            if (subroot == null) return "";
            return subroot.Value + " " + NLR(subroot.left) + " " + NLR(subroot.right);
        }

        //LRN
        public string LRN()
        {
            return LRN(Root);
        }

        private string LRN(MyTreeNode<T> subroot)
        {
            if (subroot == null) return "";
            return LRN(subroot.left) + " " + LRN(subroot.right) + " " + subroot.Value;
        }

        //Balancing
        private MyTreeNode<T> rightRotate(MyTreeNode<T> subroot)
        {
            MyTreeNode<T> b = subroot.left;
            subroot.left = b.right;
            b.right = subroot;
            return b;
        }

        private MyTreeNode<T> leftRotate(MyTreeNode<T> subroot)
        {
            MyTreeNode<T> b = subroot.right;
            subroot.right = b.left;
            b.left = subroot;
            return b;
        }

        private MyTreeNode<T> Balance(MyTreeNode<T> subroot)
        {
            if (GetDeep(subroot.right) - GetDeep(subroot.left) == 2)
            {
                if (GetDeep(subroot.right.left) > GetDeep(subroot.right.right))
                {
                    subroot.right = rightRotate(subroot.right);
                }
                return leftRotate(subroot);
            }
            if (GetDeep(subroot.right) - GetDeep(subroot.left) == -2)
            {
                if (GetDeep(subroot.left.right) > GetDeep(subroot.left.left))
                {
                    subroot.left = leftRotate(subroot.left);
                }
                return rightRotate(subroot);
            }
            return subroot;
        }

        //Отрисовка
        Font drawFont = new Font("Arial", 10);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        Pen pen = new Pen(Color.Black);

        public void Draw(Graphics e, int width)
        {
            DrawLine(e, Root, 0, width / 2 - 15, width, 10, 0);
        }

        private void DrawLine(Graphics e, MyTreeNode<T> Root, int xLeft, int xMid, int xRight, int y, int left_mid_right)
        {
            if (Root != null)
            {
                switch (left_mid_right)
                {
                    case -1:
                        e.DrawLine(pen, xMid + 30, y, xRight, y - 50);
                        break;
                    case 1:
                        e.DrawLine(pen, xMid, y, xLeft + 30, y - 50);
                        break;
                    default:
                        break;
                }
                e.DrawRectangle(pen, xMid, y, 30, 30);
                e.DrawString(Convert.ToString(Root.Value), drawFont, drawBrush, new PointF(xMid, y));
                DrawLine(e, Root.left, xLeft, (xMid + xLeft) / 2 - 15, xMid, y + 50, -1);
                DrawLine(e, Root.right, xMid, (xMid + xRight) / 2 - 15, xRight, y + 50, 1);
            }
        }
    
    }
}
