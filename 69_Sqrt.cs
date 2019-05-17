public class Solution {
    public int MySqrt(int x) {
        //return (int) Math.Sqrt(x);
        long r = x;
        while (r*r > x)
            r = (r + x/r) / 2;
        return (int) r;
    }
}