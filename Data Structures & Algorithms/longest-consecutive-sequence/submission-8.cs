public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        var hash = new HashSet<int>(nums);

        int count = 1;
        int maxCount = 1;

        foreach (var item in hash)
        {
            if (!hash.Contains(item - 1))
            {
                int current = item;
                while (hash.Contains(current + 1))
                {
                    count++;
                    current++;
                }
                
                if (count > maxCount)
                {
                    maxCount = count;
                }
                count = 1;
            }
        }

        if(count > maxCount) maxCount = count; 

        return maxCount;
    }
}
