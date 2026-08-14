public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        var set =  new HashSet<int>();

        for (int i=0 ;i <nums.Length;i++){

            if( set.TryGetValue(nums[i],out int temp)) {
                return true;
            }
                set.Add(nums[i]);
            

        }

        return false;
    }
}