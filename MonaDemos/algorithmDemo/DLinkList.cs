using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonaDemos.algorithmDemo
{
    //定义一个单链表
    public class DLinkList
    {
        private LinkListNode next;

        public LinkListNode Head
        { get; set; }

        public int Length
        { get; set; }

        public DLinkList()
        {
            Head = null;
            Length = 0;
        }

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
                currentNode.Next = node; //将要加入的node加入到链表的结尾
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
            }
        }

        //查找操作- 按值查找
        // to do

        //显示单链表
        public void DisplayLinkList()
        {
            LinkListNode currentNode = Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
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
            LinkListNode node = new LinkListNode(head, next);
            if (node == null || node.Next == null)
            {
                return node;
            }

            LinkListNode nextNode = null;
            LinkListNode preNode = null;
            LinkListNode currencNode = node;
            while (currencNode != null)
            {
                currencNode.setNext(preNode); //将当前node的next域指向preNode
                preNode = currencNode; //移动指针，下一个操作preNode
                currencNode = nextNode;
            }

            return preNode;

        }

        // 删除中间节点
        // 思路： 方法是用要删除节点的下一个位置，去替代要删除的节点
        public void DeleteMiddleNode(DLinkList linkList, LinkListNode node)
        {
            node.Next = node.Next.Next;
            node.Data = node.Next.Data;
        }
    }
}
