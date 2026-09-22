public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();

        foreach(int num in nums) {
            // this one checkout if seen numbers are inside of num
            // if it does, then true
            if (seen.Contains(num))
            {
                return true;
            }

            seen.Add(num);
        }
        // if it does not contain, then false
        return false;
    }
}