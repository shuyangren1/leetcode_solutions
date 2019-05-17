public class Solution {
    public string AddBinary(string a, string b) 
    {
        int carry = 0;
        string s = "";
        int index = 0;
        while (index < a.Length || index < b.Length || carry > 0)
        {
            int ax = index < a.Length && a[a.Length - index - 1] == '1' ? 1 : 0;
            int bx = index < b.Length && b[b.Length - index - 1] == '1' ? 1 : 0;
            int digit = ax + bx + carry;
            carry = digit > 1 ? 1 : 0;
            digit = digit % 2;
            s = digit + s;
            index++;
        }
        return s;
    }
}