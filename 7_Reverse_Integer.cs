public class Solution {
    public int Reverse(int x) {
        try{
            string y = Math.Abs(x).ToString();
            string reversed = "";
            int i = y.Length -1;
            while (i >= 0){
                reversed += y[i];
                i--;
            }
            if (x< 0){
                return -Int32.Parse(reversed);
            }
            return Int32.Parse(reversed);
        }catch (OverflowException){
            return 0;
        }
    }
}