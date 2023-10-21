public class GroupAnagramsSolution
{
    static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        var lib = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            lib[s[i] - 'a']++;
            lib[t[i] - 'a']--;
        }
        return lib.All(x => x == 0);
    }

    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> _list = new List<IList<string>>();
        while (strs.Length != 0)
        {
            List<string> subList = new()
            {
                strs[0]
            };

            strs = strs.Skip(1).ToArray();

            var j = 0;
            while (j < strs.Length)
            {
                if (IsAnagram(subList[0], strs[j]))
                {
                    subList.Add(strs[j]);
                    int index = j;
                    for (int i = index; i < strs.Length - 1; i++)
                    {
                        strs[i] = strs[i + 1];
                    }
                    Array.Resize(ref strs, strs.Length - 1);
                }
                else { j++; }
            }
            _list.Add(subList);
        }
        return _list;
    }

    public static void Main(string[] args)
    {

        var list = GroupAnagrams(new string[] { "r", "r", "r", "a", "a", "a" });
        foreach (var item in list)
        {
            foreach (var word in item)
            {
                Console.Write(word);
                Console.Write(", ");
            }
            Console.WriteLine("");
        }
    }
}