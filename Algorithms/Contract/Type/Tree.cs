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
    }
}
