using System.Text.RegularExpressions;

namespace SortByTheLetters;

public class SortByTheLettersChallenge
{
    [Fact]
    public void Sort()
    {
        Assert.Equivalent(SortByLetters(["932c", "832u32", "2344b"]), new List<string> {"2344b", "932c", "832u32"});
        Assert.Equivalent(SortByLetters(["99a", "78b", "c2345", "11d"]), new List<string> {"99a", "78b", "c2345", "11d"});
        Assert.Equivalent(SortByLetters(["572z", "5y5", "304q2"]), new List<string> {"304q2", "5y5", "572z"});
    }

    private static List<string> SortByLetters(List<string> input)
    {
        return input.OrderBy(x => new Regex(@"[^a-zA-Z]").Replace(x.ToString(), string.Empty)).ToList();
    }
}