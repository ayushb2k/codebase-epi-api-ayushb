using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Type
{
    public class LinkedList
    {
        private Node Head;

        public LinkedList()
        {
            this.Head = null;
        }

        public LinkedList(Node head)
        {
            this.Head = head;
        }

        public void PrintAllNodes()
        {
            Node cur = this.Head;
            while (cur != null)
            {
                Console.WriteLine(cur.Data.ToString());
                cur = cur.Next;
            }
        }

        public Node GetHead()
        {
            return this.Head;
        }

        public Node GetTail()
        {
            Node tail = this.Head;
            while (tail != null && tail.Next != null)
            {
                tail = tail.Next;
            }
            return tail;
        }

        public void AppendList(List<int> array)
        {
            Node newNode = new Node(array[0]);
            Node tail = this.GetTail();
            if (tail == null)
            {
                this.Head = tail = newNode;
            }

            for (int i = 1; i < array.Count; i++)
            {
                Node temp = new Node(array[i]);
                tail.Next = temp;
                tail = temp;
            }
        }

        public void AddBegin(Object data)
        {
            Node newNode = new Node(data);
            Node temp = this.Head;
            newNode.Next = temp;
            this.Head = newNode;
        }

        public void AddEnd(Object data)
        {
            Node newNode = new Node(data);
            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                Node temp = this.Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public void Reverse()
        {
            Node currHead = this.Head;
            Node newHead = null;
            while (currHead != null)
            {
                Node test = currHead;
                currHead = currHead.Next;                
                test.Next = newHead;
                newHead = test;
                
            }
            this.Head = newHead;
        }

        public Node IsCycleAndReturnNode()
        {
            Node fast = this.Head;
            Node slow = this.Head;

            while (fast != null && fast.Next != null && fast.Next.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
                if (slow == fast)
                {
                    //there is a cycle since the 2 pointers currently equal
                    int cycleLength = 0;
                    do
                    {
                        cycleLength++;
                        fast = fast.Next;
                    } while (slow != fast);


                    //now find the start of cycle.
                    //to do that first create a new head .. move it forward by cycle length.
                    //then start the 2 back head and fwd head 1 by 1. 
                    Node fwdHead = this.Head;
                    while (cycleLength > 0)
                    {
                        fwdHead = fwdHead.Next;
                    }

                    Node bckHead = this.Head;
                    while (bckHead != fwdHead)
                    {
                        bckHead = bckHead.Next;
                        fwdHead = fwdHead.Next;
                    }
                    return bckHead;
                   

                }
            }

            return null; 
        }
    }
}
