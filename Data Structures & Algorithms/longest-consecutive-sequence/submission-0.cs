public class Solution {
    public int LongestConsecutive(int[] nums) {
        // Array.Sort(nums);
        var set = new HashSet<int>(nums);
        int longestStreak = 0;
        foreach(int num in set){
            if(!set.Contains(num-1)){
                int currentVal = num;
                int streak = 1;

                while(set.Contains(currentVal+1)){
                    currentVal++;
                    streak++;
                }

                if(streak>longestStreak){
                    longestStreak = streak;
                }
            }
        }
        return longestStreak;
    }
}
