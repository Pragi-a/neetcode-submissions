public class Solution {
    public bool IsAnagram(string s, string t) {

        int[] arr = new int[26];

        foreach(var x in s){
            arr[x - 'a']++;
        }

        foreach(var y in t){
            arr[y-'a']--;
        }

        int sum = 0;
        foreach(var temp in arr){
            if (temp != 0) return false;
        }
        return true;

    }
}
