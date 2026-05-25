public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var grps = new Dictionary<string,List<string>>();

        foreach(string str in strs){
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string s = new string(chars);
            if(!grps.ContainsKey(s)){
                grps[s] = new List<string>();
            }
            grps[s].Add(str);
        }

        return grps.Values.Cast<List<string>>().ToList();
    }
}
