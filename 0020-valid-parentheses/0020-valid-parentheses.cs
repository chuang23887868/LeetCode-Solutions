public class Solution {
    public bool IsValid(string s) {

        Stack<char> stack = new Stack<char>(); 

        for(int i = 0; i < s.Length; i++){

            if(s[i] == '(' || s[i] == '[' || s[i] == '{'){

                stack.Push(s[i]);//把字元放進stack
            }
            else{

                if(stack.Count == 0){ //判斷有沒有佐括號

                    return false;
                }

                char top = stack.Pop(); //取出stack的最上層

                if(top != '(' && s[i] == ')'){

                    return false;
                }

                if(top != '[' && s[i] == ']'){

                    return false;
                }

                if(top != '{' && s[i] == '}'){

                    return false;
                }
            }
        }

        if(stack.Count != 0){//確認所有括號都有另一半

            return false;
        }

        return true;
    }
}