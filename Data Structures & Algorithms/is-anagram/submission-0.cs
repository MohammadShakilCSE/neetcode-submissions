public class Solution {
    public bool IsAnagram(string s, string t) {
  if(s.Length != t.Length)
  {
      return false;
  }

 return  s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
    }
}
