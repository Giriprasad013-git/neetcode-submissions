public class Solution {
    public int MajorityElement(int[] nums) {
        int maxElement = 0;
        int maxFrequency = 0;
        foreach(int n in nums){
            int count = nums.Count(k=>k == n);
            if(count > maxFrequency){
                maxFrequency = count;
                maxElement = n;
            }
        }
        return maxElement;
    }
}