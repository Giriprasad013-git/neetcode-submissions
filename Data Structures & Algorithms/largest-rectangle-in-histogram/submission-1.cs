public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea = 0;
        int n = heights.Length;
        for(int i = 0;i<n;i++){
            // go left
            int left = i - 1;
            int right = i + 1;
            while(left>=0 && heights[left] >= heights[i]){
                left--;
            }

            while(right<n && heights[right] >= heights[i]){
                right++;
            }

            int res = right - left - 1;
            maxArea = Math.Max(maxArea,res * heights[i]);
        }
        return maxArea;
    }
}
