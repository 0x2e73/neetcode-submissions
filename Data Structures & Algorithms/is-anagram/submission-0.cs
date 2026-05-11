public class Solution {
    public bool IsAnagram(string s, string t) {
         if(s.Length != t.Length)
            return false;

        string sAlph = String.Concat(s.OrderBy(s => s));
        string tAlph = String.Concat(t.OrderBy(t => t));
        return sAlph == tAlph; 
    }
}
