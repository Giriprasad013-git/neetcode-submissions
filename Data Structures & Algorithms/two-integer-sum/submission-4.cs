public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new();
        for(int i = 0;i<nums.Length;i++){
            int x = target - nums[i];
            if(map.ContainsKey(x)){
                return new int[]{map[x],i};
            }
            map[nums[i]] = i;
        }
        return new int[]{};
    }
}
