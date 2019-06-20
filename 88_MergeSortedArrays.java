class Solution {
    public void merge(int[] nums1, int m, int[] nums2, int n) {
        int indexM = 0;
        int indexN = 0;
        while (indexM < nums1.length && indexN < n){
            if (nums1[indexM] > nums2[indexN]){
                // insert from nums2 into nums1
                // first shift everything down by 1
                for(int i = nums1.length-2; i >= indexM; i--){
                   nums1[i+1] = nums1[i]; 
                }
                nums1[indexM] = nums2[indexN];
                indexN++;
            }
            indexM++;
        }
        while (indexN < n){
            nums1[m + indexN] = nums2[indexN];
            indexN++;
        }
    }
}