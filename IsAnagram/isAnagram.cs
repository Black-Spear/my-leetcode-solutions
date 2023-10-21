public class IsAnagramSolution
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> firstWord = new();
        Dictionary<char, int> secondWord = new();

        //this is the first word hashset
        for (var i = 0; i < s.Length; i++)
        {
            if (firstWord.ContainsKey(s[i]))
            {

                firstWord[s[i]]++;
            }
            else
            {
                firstWord.Add(s[i], 1);
            }
        }

        HashSet<char> x1 = s.ToHashSet();

        // This is second word hash set 
        for (var i = 0; i < t.Length; i++)
        {
            if (secondWord.ContainsKey(t[i]))
            {

                secondWord[t[i]]++;
            }
            else
            {
                secondWord.Add(t[i], 1);
            }
        }

        HashSet<char> x2 = t.ToHashSet();

        // !check hashsets to match

        List<char> arr = x1.ToList<char>();

        for (var i = 0; i < arr.Count; i++)
        {
            if (!secondWord.ContainsKey(arr[i])) { return false; }
            if (firstWord[arr[i]] != secondWord[arr[i]])
            {
                return false;
            }
        }

        return true;
    }
    public static void Main(string[] args)
    {


    }
}