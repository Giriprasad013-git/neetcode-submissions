public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0;i<nums.Length;i++){
            int first = nums[i];
            for(int j = 0;j<nums.Length;j++){
                if(first+nums[j]== target){
                    if(i!=j){
                    return new int[]{i,j};
                    }
                }
            }
        }
        return null;
    }
}
