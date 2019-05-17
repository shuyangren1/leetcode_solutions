public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle.Length==0){return 0;}
        if(haystack.Length < needle.Length){return -1;}
        try{
            for(int i=0; i<haystack.Length; i++){
                for(int j=0; j<needle.Length; j++){
                    if (haystack[i+j] != needle[j]){
                        goto Failed;
                    }
                }
                return  i;
                Failed:;
            }
        } catch (IndexOutOfRangeException){
            return -1;
        }
        return -1;
    }
}