public class TopKFrequentSolution
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        IDictionary<int, int> results = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (results.ContainsKey(nums[i]))
            {
                results[nums[i]]++;
            }
            else
            {
                results.Add(nums[i], 1);
            }
        }

        var re = results.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value).Keys.ToArray();

        Array.Resize(ref re, k);

        return re;
    }

    public static void Main(string[] args)
    {
        var res = TopKFrequent(new int[] { 4, 1, -1, 2, -1, 2, 3 }, 2); //expect -1, 2
        foreach (var item in res)
        {
            Console.WriteLine(item);
        }
    }
}