public class Solution {
    public List<int> FindDisappearedNumbers(int[] nums) {
        List<int> maindata = Enumerable.Range(1,nums.Length).ToList();
        return maindata.Except(nums).ToList();
    }
}