public class Solution {
    public int MaxArea(int[] heights) {
        Dictionary<int,int> sol = new Dictionary<int,int>();
        int n = heights.Length;
        int l = 0;
        int r = n - 1;
        int res = 0;
        while(l<r){
            int amount = Math.Min(heights[l],heights[r]) * (r - l);
            res = Math.Max(res,amount);
            if(heights[l]<heights[r]){
                l++;
            }else{
                r--;
            }
        }
        return res;
    }
}
