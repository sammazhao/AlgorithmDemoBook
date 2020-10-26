using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonaDemos.algorithmDemo
{
    //定义一个单链表
    public class DLinkListActionDemo
    {
        private LinkListNode head;
        private int length;

        public LinkListNode Head
        { get; set; }

        public int Length
        { get; set; }

        public DLinkListActionDemo()
        {
            Head = null;
            Length = 0;
        }

        public DLinkListActionDemo(LinkListNode headNode)
        {
            Head = headNode;
        }

        //查找操作- 根据索引查找 - 实现1
        public LinkListNode GetNodeByIndex(int index)
        {
            if (index < 0 || index > Length)
            {
                throw new Exception("Index out of bound");
            }
            else
            {
                LinkListNode tmpNode = Head;
                for (int i = 0; i < Length; i++, tmpNode = tmpNode.Next)
                {
                    if (i == index)
                    {
                        return tmpNode;
                    }
                }
                return null;
            }
        }

        //查找操作- 根据索引查找 - 实现2
        public LinkListNode GetNodeByIndex2(int index)
        {
            if (index < 0 || index > Length)
            {
                throw new Exception("Index out of bound");
            }
            else
            {
                LinkListNode tmpNode = head;
                for (int i = 0; i < index; i++)
                {
                    tmpNode = tmpNode.Next;
                }

                return tmpNode;
            }
        }

        #region 插入操作
        //给单链表添加结点 - 尾部插入
        public void AddNodeToLinkList(LinkListNode node)
        {
            //先判断当前链表是否非空
            if (Head == null)
            {
                Head = node;
                Length++;
                return;

            }
            else
            {
                LinkListNode currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next; //遍历这个单链表，直到currentNode到达最后一个结点
                }
                currentNode.Next = node; //将要加入的node加入到链表的结尾,即将最后一个节点的指针域指向新节点
                Length++;
            }
        }

        //单链表添加结点 - 头部插入, 单链表顺序反过来了
        public void AddNodeToLinkListFromHead(LinkListNode node)
        {
            if (Head == null)
            {
                Head = node;
                Length++;
                return;
            }
            else
            {
                node.Next = Head;
                Head = node;
                Length++;
            }
        }

        //指定位置插入node
        //思路：这里需要判断是否是在第一个节点进行插入，如果是则再次判断头结点是否为空。
        public void AddNodeInSpecifiedLocation(int index, LinkListNode node)
        {
            if (index < 0 || index > this.Length)
            {
                throw new Exception("indexOutOfBound");
            }
            else if (index == 0)   ////是否在头部插入
            {
                if (Head == null)    ////头节点是否为空
                {
                    Head = node;
                    Length++;
                }
                else
                {
                    node.Next = Head;
                    Head = node;
                    Length++;
                }
            }
            else   ////在指定位置插入
            {
                LinkListNode preNode = this.GetNodeByIndex(index - 1);
                LinkListNode nextNode = this.GetNodeByIndex(index);
                preNode.Next = node;
                node.Next = nextNode;
                Length++;
            }
            //// question： 是否需要支持， 在尾部插入？ https://baijiahao.baidu.com/s?id=1636398353128474117&wfr=spider&for=pc
        }
        #endregion


        //显示单链表
        public void DisplayLinkList()
        {
            LinkListNode currentNode = Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next; //遍历单链表
            }
        }

        //判断是否有环
        public bool HasCycle(LinkListNode head)
        {
            LinkListNode fast = head;
            LinkListNode slow = head;
            while (slow != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }

        //单链表翻转
        public LinkListNode ReverseLinkList(LinkListNode head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            LinkListNode nextNode = null;
            LinkListNode preNode = null;
            LinkListNode currencNode = head;
            while (currencNode != null)
            {
                //currencNode.setNext(preNode); //将当前node的next域指向preNode
                currencNode.Next = preNode;
                preNode = currencNode; //移动指针，下一个操作preNode
                currencNode = nextNode;
            }

            return preNode;

        }

        #region 删除操作
        //移除某个节点只需将其之前的节点的Next指针指向要移除节点的后一个节点即可
        public void DeleteNodeAt(int index)
        {
            if (index == 0)
            {
                head = Head.Next;
            }
            else
            {
                LinkListNode preDeleteNode = this.GetNodeByIndex(index - 1);
                if (preDeleteNode.Next == null)
                {
                    throw new Exception("Index out of bound");
                }

                LinkListNode deleteNode = preDeleteNode.Next;
                preDeleteNode.Next = deleteNode.Next;
                deleteNode = null;
            }

            length--;
        }


        // 删除中间节点, 思路： 方法是用要删除节点的下一个位置，去替代要删除的节点
        public void DeleteMiddleNode(DLinkListActionDemo linkList, LinkListNode node)
        {
            node.Next = node.Next.Next;
            node.Data = node.Next.Data;
        }
        #endregion
    }
}
