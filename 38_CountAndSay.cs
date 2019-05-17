public class Solution {
    public string CountAndSay(int n) {
        string ans = "1";
        while (n>1){
            ans = Helper(ans);
            n--;
        }
        return ans;
    }
    public string Helper(string s){//returns the next term of of count and say sequence
        string ans = "";
        int i = 0;
        while (i<s.Length) {
            char curr = s[i];
            int count = 1;
            for (int j = i+1; j<s.Length; j++){
                if (s[j] == curr){
                    count++;
                } else {
                    break;
                }
            }
            ans += count.ToString();
            ans += curr;
            i += count;
        }
        return ans;
    }
}