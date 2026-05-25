public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int,int>();

        for(int i = 0;i<nums.Length;i++){
            var complement = target - nums[i];

            if(map.ContainsKey(complement)){
                return new int[]{map[complement],i};
            }

            if(!map.ContainsKey(nums[i])){
                map.Add(nums[i],i);
            }
        }
        return new int[0];
    }
}
