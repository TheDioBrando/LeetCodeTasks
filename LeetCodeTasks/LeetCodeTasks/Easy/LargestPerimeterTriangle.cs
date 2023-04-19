namespace LeetCodeTasks.Easy
{
    public class SolutionLargestPerimeterTriangle
    {
        public int LargestPerimeter(int[] nums)
        {
            Sort(nums);
            for (var i = nums.Length - 3; i >= 0; i--)
            {
                if (nums[i] + nums[i + 1] > nums[i + 2])
                    return nums[i] + nums[i + 1] + nums[i + 2];
            }
            return 0;
        }

        private void Sort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);

        }
        private void QuickSort(int[] array, int start, int end)
        {
            if (end == start)
                return;
            var pivot = array[end];
            var storeIndex = start;
            for (int i = start; i <= end - 1; i++)
                if (array[i] < pivot)
                {
                    var t = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = t;
                    storeIndex++;
                }

            var n = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = n;
            if (storeIndex > start) QuickSort(array, start, storeIndex - 1);
            if (storeIndex < end) QuickSort(array, storeIndex + 1, end);
        }
    }
}
