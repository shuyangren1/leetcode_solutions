// Leetcode problem # 9. Palindrome Number
public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0) {return false;}
        int len = GetMagnitude(x);
        int i = 0;
        do {
            if (GetDigit(x, i) != GetDigit(x, len-i)){
                return false;
            }
            i ++;
        } while (i <= len/2);
        return true;
    }
    public int GetDigit(int x, int d){
        // returns the value on digit d of x, with the ones digit being 0
        while (d != 0){
            x /=10;
            d--;
        }
        return x%10;
    }
    public int GetMagnitude(int x){
        // returns the maximum digit location of x (e.g, 100 should return 2)
        int d = 0;
        while (x >= 10){
            d ++;
            x /= 10;
        }
        return d;
    }
}