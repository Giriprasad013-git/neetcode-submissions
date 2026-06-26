public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        
        // Push to minStack if it's empty OR the value is smaller than or equal to current minimum
        if (minStack.Count == 0 || val <= minStack.Peek()) {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        // If the item we are removing is the current minimum, remove it from minStack too
        if (stack.Peek() == minStack.Peek()) {
            minStack.Pop();
        }
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
