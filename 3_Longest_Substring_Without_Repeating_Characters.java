//3. Longest Substring Without Repeating Characters
class Solution {
    public int lengthOfLongestSubstring(String s) {
        int i = 0;
        int j = 0;
        int max = 0;
        while (j < s.length()){
            for (int a = i; a < j; a ++){
                if (s.charAt(a) == s.charAt(j)){
                    i = a+1;
                }
            }
            j++;
            String current = s.substring(i, j);
            int l = current.length();
            if (l > max){
                max = l;
            }
        }
        return max;
    }
}