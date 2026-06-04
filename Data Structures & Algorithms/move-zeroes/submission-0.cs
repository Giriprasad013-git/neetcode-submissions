public class Solution {
    public void MoveZeroes(int[] nums) {
        int s = 0;
        for(int f = 0;f<nums.Length;f++){
            if(nums[f]!=0){
                int temp = nums[s];
                nums[s]=nums[f];
                nums[f]= temp;

                s++;
            }
        }
    }
}