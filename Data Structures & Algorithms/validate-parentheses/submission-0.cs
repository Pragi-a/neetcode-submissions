public class Solution {
    public bool IsValid(string s) {
        Dictionary<char,char> symbols = new Dictionary<char, char> ();

        symbols.Add('}','{');
        symbols.Add(']','[');
        symbols.Add(')','(');

        Stack<char> stack = new Stack<char>();

        foreach(var x in s){
            if(stack.Count > 0){
                char top = stack.Peek();
                if (symbols.ContainsKey(x)){
                     if(top == symbols[x])
                        stack.Pop();
                    else
                        stack.Push(x);
                }else{
                    stack.Push(x);
                }
               
                
            }else{
                stack.Push(x);
            }
        }

        return stack.Count == 0;
    }
    
}
