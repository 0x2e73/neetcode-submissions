public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;

        var sorted = nums.OrderBy(x => x).Distinct().ToArray();

        int currentCount = 1;
        int maxCount = 1;

        for (int i = 0; i < sorted.Length - 1; i++)
        {

            if (sorted[i]+1 == sorted[i + 1])
            {
                currentCount++;
            }
            else {
                if(currentCount > maxCount){
                    maxCount = currentCount;
                }
                currentCount = 1;
            }
        }

        if(currentCount > maxCount) maxCount = currentCount; 

        return maxCount;
    }
}
