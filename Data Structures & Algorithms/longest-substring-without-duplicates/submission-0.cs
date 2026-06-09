public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var seen = new Dictionary<char,int>();
        int left = 0;
        int maxLen = 0;

        for(int right = 0;right<s.Length;right++){
            seen[s[right]] = seen.GetValueOrDefault(s[right],0) +1;

            while(seen[s[right]]>1){
                seen[s[left]]--;
                if(seen[s[left]] == 0) seen.Remove(s[left]);
                left++;
            }

            maxLen = Math.Max(maxLen,right-left+1);
        }

        return maxLen;
    }
}
