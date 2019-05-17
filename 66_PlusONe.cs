public class Solution {
    public int[] PlusOne(int[] digits){
        if (digits[digits.Length-1] == 9){
            if (digits.Length == 1){
                return new int[] {1, 0};
            }
            Array.Resize(ref digits, digits.Length-1);
            digits = PlusOne(digits);
            Array.Resize(ref digits, digits.Length+1);
            digits[digits.Length-1] = 0;
            return digits;
        }
        digits[digits.Length-1]++;
        return digits;
    }
}