public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int maxlen = 0;
        int left = 0;
        int zeroCount=0;
        for(int right = 0;right<nums.Length;right++){
            if(nums[right] == 0){
                zeroCount++;
            }

            while(zeroCount>k){
                if(nums[left]==0) zeroCount--;
                left++;
            }
            maxlen = Math.Max(maxlen,right-left+1);
        } 
        return maxlen;
    }
}