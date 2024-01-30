namespace PermutationInString;

public class Class1
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        int[] freqS1 = new int[26];
        int[] freqS2 = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            freqS1[s1[i] - 'a']++;
            freqS2[s2[i] - 'a']++;
        }

        for (int i = s1.Length; i < s2.Length; i++)
        {
            if (AreEqual(freqS1, freqS2))
            {
                return true;
            }

            freqS2[s2[i] - 'a']++;
            freqS2[s2[i - s1.Length] - 'a']--;
        }

        return AreEqual(freqS1, freqS2);

    }

    public bool AreEqual(int[] freq1, int[] freq2)
    {
        for (int i = 0; i < freq1.Length; i++)
        {
            if (freq1[i] != freq2[i])
            {
                return false;
            }
        }
        return true;
    }
}
