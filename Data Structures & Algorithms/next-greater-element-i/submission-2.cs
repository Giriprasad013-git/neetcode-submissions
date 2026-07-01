public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var map = new Dictionary<int,int>();
        var stack = new Stack<int>();

        foreach(int num in nums2){
            while(stack.Count() > 0 && stack.Peek() < num){
                map[stack.Pop()]=num;
            }
            stack.Push(num);
        }

        while(stack.Count()>0){
            map[stack.Pop()] = -1;
        }

        return nums1.Select(n => map[n]).ToArray();
    }
}