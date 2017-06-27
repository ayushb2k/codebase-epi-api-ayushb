using Contract.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.AlgorithmProvider
{
    public interface ITreeProvider
    {
        bool IsBalanced(Tree tree);
        bool IsSymmetric(Tree tree);
    }
}
