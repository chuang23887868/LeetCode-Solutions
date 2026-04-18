public class Solution {
    public IList<string> GenerateParenthesis(int n) {

        List<string> res = new List<string>();

        AA(res, n, 0, 0, "");

        return res;
        
    }

    public void AA(List<string> list, int n, int left, int right , string current){

        if(current.Length == n * 2){

            list.Add(current);

            return;
        }

        if(left < n){

            AA(list, n, left + 1, right, current + "(");
        }
        
        if(left > right){

            AA(list, n, left, right + 1, current + ")");
        }
    }
}