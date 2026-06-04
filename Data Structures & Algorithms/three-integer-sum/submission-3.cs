public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);
        var res = new List<List<int>>(); 
        for(int i = 0;i<n;i++){
            if(i>0 && nums[i]==nums[i-1]) continue;
            int l = i + 1;
            int r = n - 1;
            while(l<r){
                int sum = (nums[i] + nums[l] + nums[r]);
                if(sum==0){
                    res.Add(new List<int>{nums[i],nums[l],nums[r]});
                    l++;
                    r--;
                    while(l<r && nums[l]==nums[l-1]) l++;
                    while(l<r && nums[r]==nums[r+1]) r--;
                }else if(sum<0){
                    l++;
                }else{
                    r--;
                }
            }
        }
        return res;
    }
}
