public class Solution {
    public int MajorityElement(int[] nums) {
        
        int count = 0;
        int majority = nums[0];

        for (int i=1; i< nums.Length ; i++){

            if (nums[i] == majority) count++;

            else count --;

            if (count <0) majority = nums[i];
        }

        return majority;
    }
}