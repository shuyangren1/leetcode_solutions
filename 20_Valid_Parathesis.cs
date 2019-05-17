public class Solution {
    public bool IsValid(string s) {
        if (s.Length%2 ==1){return false;}
        Stack stk = new Stack();
        for (int i=0; i<s.Length; i++){
            char current = s[i];
            if (current == '(' || current == '{' || current == '['){
                stk.Push(current);
            } else {
                if (stk.Count == 0) {return false;}
                switch (current){
                    case ')':
                        if ((char)stk.Peek() != '(') {return false;}
                        break;
                    case '}':
                        if ((char)stk.Peek() != '{') {return false;}
                        break;
                    case ']':
                        if ((char)stk.Peek() != '[') {return false;}
                        break;
                }
                stk.Pop();
            }
        }
        if (stk.Count == 0){return true;}
        return false;
    }
}