using System;

namespace MonaDemos.algorithmDemo
{
    public class LinkListNode
    {
        //https://www.cnblogs.com/liufei88866/archive/2010/09/02/1816048.html
        private object data;
        private LinkListNode next;

        public object Data
        { get; set; }

        public LinkListNode Next
        { get; set; }

        public LinkListNode(object nodeData, LinkListNode node)
        {
            Data = nodeData;
            Next = node;
        }

        public LinkListNode()
        {
            Data = 0;
            Next = null;
        }

        public void setNext(LinkListNode next)
        {
            Next = next;
        }
    }
}




