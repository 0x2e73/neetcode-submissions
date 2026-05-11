public class Solution {
      public List<List<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, List<string>>();

        foreach(var word in strs)
        {
            int[] count = new int[26];
            foreach(char c in word)
            {
                count[c - 'a']+=1;
            }

            string key = string.Join(",", count);

            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }
            groups[key].Add(word);
        }

        return groups.Values.ToList();
    }
}
