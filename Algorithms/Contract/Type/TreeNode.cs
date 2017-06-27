using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Type
{
    public class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public Object Data { get; set; }

        public bool IsLocked { get; set; }
        public TreeNode Parent { get; set; }
        public int NumOfLockedNodes { get; set; }

        public TreeNode(TreeNode value, Object data, bool isLeft = true)
        {
            this.Left = isLeft ? value : null;
            this.Right = !isLeft ? value : null;
            this.Data = data;
        }
        
        public TreeNode(TreeNode left, TreeNode right, Object data)
        {
            this.Left = left;
            this.Right = right;
            this.Data = data;
        }

        public TreeNode(Object data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }
    }
}
