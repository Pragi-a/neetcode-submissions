public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> map =  new Dictionary<int,int>();
        int[] result = new int[2];

        for (int i=0; i<nums.Length ; i++){
            int temp = target - nums[i];

            if (map.ContainsKey(temp)){
                result[0] = map[temp];
                result[1] = i;

            }

            if (!map.ContainsKey(temp)){
                map.Add(nums[i],i);
            }
        }

        return result;
    }
}
