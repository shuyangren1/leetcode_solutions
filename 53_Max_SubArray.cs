public class Solution {
    public int MaxSubArray(int[] nums) {
        int MaxAll=nums[0], MaxEnd=nums[0];
        for (int i=1;i<nums.Length;++i){
    	    MaxEnd= Math.Max(MaxEnd+nums[i],nums[i]);
    	    MaxAll=Math.Max(MaxAll, MaxEnd);	
        }
        return MaxAll;
    }
}