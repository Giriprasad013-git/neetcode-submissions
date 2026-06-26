public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        List<int> result = new List<int>();
        for(int left = 0; left < n; left++){
            int right = left+1;

            while(right<=n-1 && temperatures[left]>=temperatures[right]){
                right++;
            }

            if(right>=n){
                result.Add(0);
            }else{
                result.Add(right-left);
            }
        }
        return result.ToArray();
    }
}
