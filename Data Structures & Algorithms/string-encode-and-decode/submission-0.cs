public class Solution {

    public string Encode(IList<string> strs) {

        var encodedString = "";

        foreach(var str in strs){
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(str);
            var encoded = System.Convert.ToBase64String(plainTextBytes);
            encodedString += $"{encoded.Length}#{encoded}";
        }   

        return encodedString;
    }   

    public List<string> Decode(string s) {
        List<string> decodedStrings = new List<string>();
        int index = 0;
        while(index < s.Length)
        {
            //trouver le prochain #
            int hashIndex = s.IndexOf('#', index);

            //prendre tout ce qui est entre notre index et le # et c'est notre nombre
            string stringLength = s.Substring(index, hashIndex - index);
            int wordLength = int.Parse(stringLength);

            //trouver le substring 
            string encodedWord = s.Substring(hashIndex + 1, wordLength);
            byte[] decodedBytes = System.Convert.FromBase64String(encodedWord);
            string decodedString = System.Text.Encoding.UTF8.GetString(decodedBytes);

            decodedStrings.Add(decodedString);
            index = hashIndex + wordLength + 1;
        }

        return decodedStrings;
   }
}
