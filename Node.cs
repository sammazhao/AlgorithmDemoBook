using System;

public class Node
{
    private object data;
    private Node next;
    public Node(object data, Node next)
    {
        this.data = data;
        this.next = next;
    }

    public Node getNext(Node node)
    {
        return node.next;

    }

    public void setNext(Node node, Node next)
    {
        node.next = next;
    }

    public Node ReverseLinkList(Node head)
    {
        //链表为空或只有head
        if (head.next == null || head.data == null)
        {
            return head;
        }
        else
        {
            Node nextNode = node.getNext(node);
            Node preNode = null;
            Node currentNode = head;
            currentNode.next = preNode;
            preNode = currentNode;
            currentNode = nextNode;
        }

    }
}


