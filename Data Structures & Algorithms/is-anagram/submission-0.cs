public class Solution {
    public bool IsAnagram(string s, string t) {
        // if both string's length not equal 
        // then not anagram
        if (s.Length != t.Length)
        {
            return false;
        }

        // if both strings sequence are equal
        // then it's anagram

        return s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
    }
}
