using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.AlgorithmProvider
{
    public interface IArrayProvider
    {
        void DutchFlagPartition(int pivotIndex, List<int> array);
        void DutchFlagPartitionV1(List<int> array);
        void DutchFlagPartitionV3(List<bool> array);
        void IncrementBigInt(List<int> array);
        bool CanReachBoardGame(List<int> array);
    }
}
