using Contract.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.AlgorithmProvider
{
    public interface ILinkedListProvider
    {
        Node MergeTwoSortedLists(Node a, Node b);

        void ReverseLinkedList(LinkedList a);
    }
}
