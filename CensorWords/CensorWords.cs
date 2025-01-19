using System.Text.RegularExpressions;

namespace CensorWords;

public class CensorWordsProblem
{
    [Fact]
    public void CensorWordsTests()
    {
        Assert.Equivalent(CensorWords("The code is fourty"), "The code is ******");
        Assert.Equivalent(CensorWords("Two plus three is five"), "Two plus ***** is five");
        Assert.Equivalent(CensorWords("aaaa aaaaa 1234 12345"), "aaaa ***** 1234 *****");
    }

    private static string CensorWords(string words)
    {
        var wordsToCensor = words.Split(" ").Select((word, index) => new {word, index}).Where(w => w.word.Length > 4).ToList();
        var censored = "";
        foreach (var word in wordsToCensor)
        {
            var censoredWord = word.word.Aggregate("", (current, character) => current + "*");

            censored = censored != "" ? censored.Replace(word.word, censoredWord) : words.Replace(word.word, censoredWord);
        }
        
        return censored;
    }
}