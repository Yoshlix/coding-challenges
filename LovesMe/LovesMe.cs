namespace LovesMe;

public static class LovesMeChallenge
{
    [Fact]
    public static void LovesMeTests()
    {
        Assert.Equivalent("Loves me, Loves me not, LOVES ME", LovesMe(3));
        Assert.Equivalent("Loves me, Loves me not, Loves me, Loves me not, Loves me, LOVES ME NOT", LovesMe(6));
        Assert.Equivalent("LOVES ME", LovesMe(1));
    }

    private static string LovesMe(int number)
    {
        var text = "";
        
        for (int i = 1; i <= number; i++)
        {
            if (i == 1 && i != number)
            {
                text += "Loves me, ";
            }

            else if (i % 2 == 0) 
            {
                if (i == number)
                {
                    text += "LOVES ME NOT";
                }
                else
                {
                    text += "Loves me not, ";
                }
            }
            
            else
            {
                if (i == number)
                {
                    text += "LOVES ME";
                }
                else
                {
                    text += "Loves me, ";
                }
            }
        }
        
        return text;
    }
}