public class Solution {
    public bool IsValid(string s) {
        var bracket = new Dictionary<char,char>(){
            {'}','{'},
            {']','['},
            {')','('}
        };
        var stack = new Stack<char>();
        foreach(char c in s){
            if(bracket.ContainsKey(c)){
                if(stack.Count == 0){
                    return false;
                }

                char element = stack.Pop();
                if(bracket[c]!=element){
                    return false;
                }
            }else{
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}
