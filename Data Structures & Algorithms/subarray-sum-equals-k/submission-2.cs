public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0;
        for(int i = 0;i<nums.Length;i++){
            int currentSum = 0;
            for(int j = i; j < nums.Length;j++){
                currentSum += nums[j];
                if(currentSum == k){
                    result++;
                }
            }
        }
        return result;
    }
}