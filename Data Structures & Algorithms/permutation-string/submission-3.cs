public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int k = s1.Length;
        if(k>s2.Length) return false;
        int[] f1 = new int[26];
        int[] f2 = new int[26];

        for(int i = 0;i<k;i++){
            f1[s1[i] - 'a']++;
            f2[s2[i] - 'a']++;
        }

        if(f1.SequenceEqual(f2)) return true;

        for (int i = k;i<s2.Length;i++){
            f2[s2[i] - 'a'] ++;
            f2[s2[i - k] - 'a'] --;
            if(f1.SequenceEqual(f2)) return true;
        }
        return false;
    }
}
