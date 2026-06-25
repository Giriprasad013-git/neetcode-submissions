public class Solution {
    public string MinWindow(string s, string t) {
    if (s.Length < t.Length) return "";

    var need = new Dictionary<char, int>();
    foreach (var c in t)
        need[c] = need.GetValueOrDefault(c, 0) + 1;

    var window = new Dictionary<char, int>();
    int required = need.Count;
    int formed = 0;
    int left = 0, minLen = int.MaxValue, resultStart = 0;

    for (int right = 0; right < s.Length; right++) {
        char c = s[right];
        window[c] = window.GetValueOrDefault(c, 0) + 1;

        if (need.ContainsKey(c) && window[c] == need[c])
            formed++;

        while (formed == required) {
            if (right - left + 1 < minLen) {
                minLen = right - left + 1;
                resultStart = left;
            }
            char l = s[left];
            window[l]--;
            if (need.ContainsKey(l) && window[l] < need[l])
                formed--;
            left++;
        }
    }

    return minLen == int.MaxValue ? "" : s.Substring(resultStart, minLen);
}
}
