/*
You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".

 

Example 1:

Input: jewels = "aA", stones = "aAAbbbb"
Output: 3
Example 2:

Input: jewels = "z", stones = "ZZ"
Output: 0
 

Constraints:

1 <= jewels.length, stones.length <= 50
jewels and stones consist of only English letters.
All the characters of jewels are unique.
*/

public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int countJewels = 0;
        // Put Jewels into a Dictionary
        Dictionary<char, int> jewelDictionary = new Dictionary<char, int>();
        for (int i = 0; i < jewels.Length; i++)
        {
            jewelDictionary.Add(jewels[i], i);
        }
        // Check stones against dictionary
        for (int j = 0; j < stones.Length; j++)
        {
            if (jewelDictionary.ContainsKey(stones[j]))
            {
                countJewels++;
            }
        }
        return countJewels;
    }
}