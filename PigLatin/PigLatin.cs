namespace PigLatin;

public class PigLatinChallenge
{
    [Fact]
    public void PigLatinTests()
    {
        Assert.Equivalent("isthay isway igpay atinlay", ToPigLatin("this is pig latin"));
        Assert.Equivalent("allway eetstray ournaljay", ToPigLatin("wall street journal"));
    }

    private static string ToPigLatin(string input)
    {
        var output = "";
        var words = input.Split(" ");

        foreach (var word in words)
        {
            if (word[0] is 'a' or 'e' or 'i' or 'o' or 'u')
            {
                output += word + "way ";
            }
            else
            {
                var firstVowel = 0;
                foreach (var letter in word.ToCharArray())
                {
                    if (letter is not ('a' or 'e' or 'i' or 'o' or 'u')) continue;
                    firstVowel = word.IndexOf(letter);
                    break;
                }

                var beforeVowel = word.Remove(firstVowel);
                var afterVowel = word.Substring(firstVowel);
                output += afterVowel + beforeVowel + "ay ";
            }
        }

        return output.Trim();
    }
}