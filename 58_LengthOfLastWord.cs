public class Solution {
    public int LengthOfLastWord(string s) {
        string[] words = s.Split(" ");
        for (int i = words.Length-1; i>=0; i--){
            if (words[i].Length != 0){
                return words[i].Length;
            }
        }
        return 0;
    }
}