using System.Collections;

namespace HowMuchIsTrue;

public class HowMuchIsTrue
{
    [Fact]
    public void HowMuchIsTrueTests()
    {
        Assert.Equivalent(CountTrue([true, false, false, true, false]), 2);
        Assert.Equivalent(CountTrue([false, false, false, false]), 0);
        Assert.Equivalent(CountTrue([]), 0);
    }

    private static int CountTrue(ArrayList input)
    {
        return input.ToArray().Count(item => item is true);
    }
}