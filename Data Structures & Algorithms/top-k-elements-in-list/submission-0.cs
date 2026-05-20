public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
foreach (var num in nums)
{
    if (!frequencyMap.ContainsKey(num))
    {
        frequencyMap[num] = 0;
    }
    frequencyMap[num]++;
}
int[] result = new int[k];
var pq = new PriorityQueue<int, int>();
foreach (var kvp in frequencyMap)
{
    pq.Enqueue(kvp.Key, -kvp.Value);
}


for (int i = 0; i < k; i++)
{
    result[i] = pq.Dequeue();
}
return result;
    }
}
