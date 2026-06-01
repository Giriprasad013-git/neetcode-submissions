public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> freq = new Dictionary<int,int>();

        foreach(int n in nums){
            if(freq.ContainsKey(n))
                freq[n]++;
            else
                freq.Add(n,1);
            if(freq[n]>nums.Length/2)
                return n;
        }
        return 0;
    }
}