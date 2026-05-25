public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int,int>();
        foreach(int n in nums){
            if(!map.ContainsKey(n)){
                map.Add(n,0);
            }
            map[n]++;
        }

        var sortedMap = map.OrderByDescending(k => k.Value);
        var result = sortedMap.Take(k).Select(n => n.Key).ToArray();
        return result;
    }
}
