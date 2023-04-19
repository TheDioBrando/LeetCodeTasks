using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Easy
{
    public class VersionControl
    {
        public bool IsBadVersion(int num)
        {
            return false;
        }
    }
    public class SolutionFirstBadVersion : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int left = 0, right = n;
            int mid;
            while (left < right)
            {
                mid = (right - left) / 2 + left;
                if (IsBadVersion(mid))
                    right = mid;
                else
                    left = mid + 1;

            }
            if (IsBadVersion(right))
                return right;
            return -1;
        }
    }
}
