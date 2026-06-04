public class Solution {
    public int MaxArea(int[] heights) {
        Dictionary<int,int> sol = new Dictionary<int,int>();
        int n = heights.Length;
        int left = 0;
        int right = n - 1;
        int res = 0;
        for(int i = 0; i<n;i++){
            for(int j = 0;j<n;j++){
                int amount = Math.Min(heights[i],heights[j]) * (j - i);

                res = Math.Max(res,amount);
            }
        }
        return res;
    }
}
