using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Type
{
    public class Tree
    {
        private TreeNode Root;

        public Tree()
        {
            this.Root = null;
        }

        public Tree(TreeNode root)
        {
            this.Root = root;
        }

        /// <summary>
        /// we can do both recursive and iterative
        /// for recursive we dont need any extra data-struture like STACK since the recursive call will use function call stack to store the values
        /// for iterative we do need a stack for storing the values.
        /// </summary>
        public void InOrderRecursive(TreeNode currRoot)
        {
            if (currRoot.Left != null)
            {
                InOrderRecursive(currRoot.Left);
            }
            Console.Write(currRoot.Data.ToString());
            if (currRoot.Right != null)
            {
                InOrderRecursive(currRoot.Right);
            }
        }

        public void InOrderIterative()
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = this.Root;
            bool isDone = false;
            while (!isDone)
            {
                if (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.Left;
                }
                else
                {
                    if (stack.Any())
                    {
                        curr = stack.Pop();
                        Console.Write(curr.Data.ToString());
                        curr = curr.Right;
                    }
                    else
                    {
                        isDone = true;
                    }
                }
            }
        }

        public void PreOrderRecursive(TreeNode currRoot)
        {
            Console.Write(currRoot.Data.ToString());
            if (currRoot.Left != null)
            {
                PreOrderRecursive(currRoot.Left);
            }
            
            if (currRoot.Right != null)
            {
                PreOrderRecursive(currRoot.Right);
            }
        }

        public void PreOrderIterative()
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(this.Root);
            while (stack.Any())
            {
                TreeNode temp = stack.Pop();
                Console.Write(temp.Data.ToString());
                if (temp.Right != null)
                {
                    stack.Push(temp.Right);
                    //continue;
                }
                if (temp.Left != null)
                {
                    stack.Push(temp.Left);
                    //continue;
                }                
            }
        }

        public void PostOrderRecursive(TreeNode currRoot)
        {            
            if (currRoot.Left != null)
            {
                PostOrderRecursive(currRoot.Left);
            }

            if (currRoot.Right != null)
            {
                PostOrderRecursive(currRoot.Right);
            }
            Console.Write(currRoot.Data.ToString());
        }

        /// <summary>
        /// not working.  need to understand the 2 stack and 1 stack approach
        /// </summary>
        public void PostOrderIterative()
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            //stack.Push(this.Root);
            TreeNode curr = this.Root;

            do
            {
                while (curr != null)
                {
                    if (curr.Right != null)
                    {
                        stack.Push(curr.Right);
                    }
                    stack.Push(curr);
                    curr = curr.Left;
                       
                }

                curr = stack.Pop();
                if (curr.Right == stack.Peek().Right)
                {
                    stack.Pop();
                    stack.Push(curr);
                    curr = curr.Right;
                }
                else
                {
                    Console.WriteLine(curr.Data.ToString());
                    curr = null;
                }

            } while (stack.Any());
        }

        public bool IsBalanced()
        {
            return IsBalancedHelper(this.Root).Key;
        }

        private KeyValuePair<bool, int> IsBalancedHelper(TreeNode node)
        {
            if (node == null)            
            {
                return new KeyValuePair<bool, int>(true, -1);
            }

            KeyValuePair<bool, int> leftResult = IsBalancedHelper(node.Left);
            if (!leftResult.Key)
                return new KeyValuePair<bool, int>(false, 0);

            KeyValuePair<bool, int> rightResult = IsBalancedHelper(node.Right);
            if (!rightResult.Key)
                return new KeyValuePair<bool, int>(false, 0);


            bool isBalanced = Convert.ToInt32(Math.Abs(leftResult.Value - rightResult.Value)) <= 1;
            int height = Math.Max(leftResult.Value, rightResult.Value) + 1;
            return new KeyValuePair<bool, int>(isBalanced, height);
        }

        public bool IsSymmetric()
        {
            if (this.Root == null)
            {
                return true;
            }
            else
            {
                return IsSymmetricHelper(this.Root.Left, this.Root.Right);
            }
        }

        private bool IsSymmetricHelper(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;
            else if (left != null && right != null)
                return left.Data == right.Data && IsSymmetricHelper(left.Left, right.Right) && IsSymmetricHelper(left.Right, right.Left);
            else
                return false;
            
        }

        public TreeNode LCA(TreeNode a, TreeNode b)
        {
            return LCAHelper(this.Root, a, b).Value;
        }

        /// <summary>
        /// the key is the number of nodes matching either a or b under a node.
        /// the value is the exact node which has exactly both the matching nodes
        /// check for nulls, check for left tree and right tree, if either has length of 2 then return that one.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private KeyValuePair<int, TreeNode> LCAHelper(TreeNode node, TreeNode a, TreeNode b)
        {
            if (node == null)
                return new KeyValuePair<int, TreeNode>(0, null);

            var leftResult = LCAHelper(node.Left, a, b);
            if (leftResult.Key == 2)
                return leftResult;

            var rightResult = LCAHelper(node.Right, a, b);
            if (rightResult.Key == 2)
                return rightResult;

            var temp = (node == a || node == b) ? 1 : 0;
            int numOfTargetNode = rightResult.Key + leftResult.Key + temp;

            return new KeyValuePair<int, TreeNode>(numOfTargetNode, numOfTargetNode == 2 ? node : null);
        }

        public void PopulateNextPointer()
        {
            var curr = this.Root;
            while (curr != null)
            {
                PopulateNext(curr);
                curr = curr.Left;
            }
        }

        private void PopulateNext(TreeNode node)
        {

        }
    }
}
