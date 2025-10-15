public class Anagram
{
    private string _baseWord;

    public Anagram(string baseWord) => _baseWord = baseWord;

    public string[] FindAnagrams(string[] potentialMatches) =>
        potentialMatches.Where(IsAnagram).ToArray();

    private bool IsAnagram(string candidate) =>
        SortedLowerCaseString(candidate) == SortedLowerCaseString(_baseWord) &&
            IsNotEqualToBaseWord(candidate);

    private bool IsNotEqualToBaseWord(string candidate) =>
        !string.Equals(candidate, _baseWord, StringComparison.OrdinalIgnoreCase);

    private static string SortedLowerCaseString(string s) => new(s.ToLower().OrderBy(c => c).ToArray());
}
