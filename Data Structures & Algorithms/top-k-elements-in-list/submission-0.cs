public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var key = nums[i];
            if(dic.ContainsKey(key))
                dic[key] += 1;
            else
                dic[key] = 1;
        }

        return dic.OrderByDescending(c => c.Value).Take(k).Select(x => x.Key).ToArray();
    }
}
