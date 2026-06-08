public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length) return false;
        int k = s1.Length;
        int[] f1 = new int[26];
        int[] f2 = new int[26];

        for(int i = 0;i<s1.Length;i++){
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

    // public bool IsSubstring(string sb1,string sb2){
    //     if(sb1.Length!=sb2.Length) return false;

    //     int[] charCounts = new int[26];

    //     for(int j = 0;j<sb1.Length;j++){
    //         charCounts[sb1[j]]++;
    //         charCounts[sb2[j]]--;
    //     }

    //     foreach(int n in charCounts){
    //         if(n!=0) return false;
    //     }

    //     return true;
    // }
}
