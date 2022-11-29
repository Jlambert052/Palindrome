public class Solution {
    public bool IsPalindrome(int x) {
        string num = x.ToString();
        string rev = "";
        int a;
        a = num.Length -1;
        while(a >=0) {
            rev +=num[a];
            a--;
        }
        if(rev == num) {
            return true;
        } else 
            return false;
    }
}