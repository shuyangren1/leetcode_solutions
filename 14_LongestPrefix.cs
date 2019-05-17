public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string answer = "";
        try{
            int i = 0;
            while (true){
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++){
                    if (strs[j][i] != c){
                        return answer;
                    }
                }
                answer += c;
                i++;
            }
        } catch {
            return answer;
        }
    }
}