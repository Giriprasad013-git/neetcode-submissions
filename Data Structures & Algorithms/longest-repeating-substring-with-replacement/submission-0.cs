public class Solution {
    public int CharacterReplacement(string s, int k) {
        var seen = new Dictionary<char,int>();
        int left = 0;
        int max_freq = 0;
        int max_len = 0;
        for(int right = 0; right < s.Length; right ++){
            seen[s[right]] = seen.GetValueOrDefault(s[right],0) + 1;

            max_freq = Math.Max(max_freq, seen[s[right]]);

            if((right-left+1)-max_freq>k){
                seen[s[left]]-=1;
                left+=1;
            }

            max_len = Math.Max(max_len, right - left + 1);
        }
        return max_len;
    }
}
