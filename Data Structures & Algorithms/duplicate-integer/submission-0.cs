public class Solution {
    public bool hasDuplicate(int[] nums) {
        var vus = new HashSet<int>();
        foreach(var val in nums){
            if(vus.Contains(val))
                return true;
            vus.Add(val);
        }
        return false;
    }
}