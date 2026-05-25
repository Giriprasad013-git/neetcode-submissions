public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        var s1 = s.ToLower().ToCharArray();
        var t1 = t.ToLower().ToCharArray();

        Array.Sort(s1);
        Array.Sort(t1);

        return new string(s1) == new string(t1);
    }
}
