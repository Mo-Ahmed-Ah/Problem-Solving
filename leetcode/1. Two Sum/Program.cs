/// <summary>
/// Finds two distinct indices in the given array such that their values sum up to the target.
/// </summary>
/// <param name="nums">An array of integers to search through.</param>
/// <param name="target">The target sum to find using two numbers from the array.</param>
/// <returns>
/// An array of two integers representing the indices of the two numbers whose sum is equal to the target.
/// Returns [-1, -1] if no such pair exists.
/// </returns>
/// <example>
/// Input: nums = [2, 7, 11, 15], target = 9  
/// Output: [0, 1] // Because nums[0] + nums[1] = 2 + 7 = 9
/// </example>


namespace _1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var ret = new int[2] { -1, -1 };
            if (nums == null || nums.Length <= 1) return ret;

            Dictionary<int, int> cache = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (cache.ContainsKey(target - nums[i]))
                {
                    ret[0] = cache[target - nums[i]];
                    ret[1] = i;
                    break;
                }
                else
                {
                    if (!cache.ContainsKey(nums[i]))
                    {
                        cache.Add(nums[i], i);
                    }
                }
            }
            return ret;
        }
    }
}
