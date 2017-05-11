using Contract.AlgorithmProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.Type;

namespace Algorithms.AlgorithmProvider
{
    public class LinkedListProvider : ILinkedListProvider
    {
        public LinkedListProvider()
        {
            //something might go here .. e.g. initialize a list with a dummy head.
        }

        public Node MergeTwoSortedLists(Node a, Node b)
        {
            Node returnHead = null, currP = null;
            if (a == null && b == null)
            {
                return null;
            }
            else if (a != null && b == null)
            {
                return a;
            }
            else if (a == null && b != null)
            {
                return b;
            }
            else if ((int)a.Data < (int)b.Data)
            {
                returnHead = currP = a;
                a = a.Next;
            }
            else
            {
                returnHead = currP = b;
                b = b.Next;
            }

            //Node aCur = a;
            //Node bCur = b;
            while (a != null && b != null)
            {
                if ((int)a.Data < (int)b.Data)
                {
                    currP.Next = a;
                    currP = a;
                    a = a.Next;
                }
                else
                {
                    currP.Next = b;
                    currP = b;
                    b = b.Next;
                }
            }


            currP.Next = a ?? b;

            return returnHead;
        }

        public void ReverseLinkedList(LinkedList a)
        {
            //throw new NotImplementedException();
            a.Reverse();
        }
    }
}
