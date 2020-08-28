using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonaDemos.algorithmDemo
{
    //二叉链表结点类
    public class BTreeNode<T>
    {
        private T data; //数据域
        private BTreeNode<T> lchild;
        private BTreeNode<T> rchild;

        public BTreeNode(T value, BTreeNode<T> lc, BTreeNode<T> rc)
        {
            data = value;
            lchild = lc;
            rchild = rc;
        }

        public BTreeNode(BTreeNode<T> lc, BTreeNode<T> rc)
        {
            data = default(T);
            lchild = lc;
            rchild = rc;
        }

        public BTreeNode<T> Lchild
        {
            get { return lchild; }
            set { rchild = value; }
        }

        public BTreeNode<T> Rchild
        {
            get { return rchild; }
            set { rchild = value; }
        }

        public T Data

        {
            get { return data; }
            set { data = value; }
        }

        //先序遍历： rootData -> lchild -> rchild
        public static void PreOrder<T>(BTreeNode<T> rootNode)
        {
            if (rootNode != null)
            {
                Console.WriteLine(rootNode.Data);
                PreOrder<T>(rootNode.Lchild);
                PreOrder<T>(rootNode.Rchild);
            }
        }

        //中序遍历： lchild -> rootData - > rchild
        public static void MidOrder<T>(BTreeNode<T> rootNode)
        {
            if (rootNode != null)
            {
                MidOrder<T>(rootNode.Lchild);
                Console.WriteLine(rootNode.Data);
                MidOrder<T>(rootNode.Rchild);
            }
        }

        //后序遍历： lchild -> rchild -> rootData
        public static void AfterOrder<T>(BTreeNode<T> rootNode)
        {
            if (rootNode != null)
            {
                MidOrder<T>(rootNode.Lchild);
                MidOrder<T>(rootNode.Rchild);
                Console.WriteLine(rootNode.Data);
            }
        }

    }
}
