public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        int[] counter = new int[26];

        for(int i = 0; i < s.Length; i++) {
            // Pour s, on incrémente
            int index_s = s[i] - 'a';  
            counter[index_s] = counter[index_s] + 1;
            
            // Pour t, on décrémente
            int index_t = t[i] - 'a';
            counter[index_t] = counter[index_t] - 1;
        }

        foreach(var count in counter) {
            if(count != 0)
                return false;
        }

        return true;
    }
}
