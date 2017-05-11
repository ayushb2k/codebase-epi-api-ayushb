using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Type
{
    public class Node
    {
        public Node Next { get; set; }
        public Object Data { get; set; }

        public Node(Node next, Object data)
        {
            this.Next = next;
            this.Data = data;
        }

        public Node(Object data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
