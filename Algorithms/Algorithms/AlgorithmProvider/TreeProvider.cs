using Contract.AlgorithmProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.Type;

namespace Algorithms.AlgorithmProvider
{
    public class TreeProvider : ITreeProvider
    {
        public TreeProvider()
        {
            //init a tree if required.
        }

        public bool IsBalanced(Tree tree)
        {
            return tree.IsBalanced();
        }

        public bool IsSymmetric(Tree tree)
        {
            return tree.IsSymmetric();
        }
    }
}
