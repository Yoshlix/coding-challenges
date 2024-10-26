namespace SimonSays;

public class SimonSaysProblem
{
    [Fact]
    public void SimonSaysTests()
    {
        Assert.Equivalent(SimonSays([
            "Simon says add 4",
            "Simon says add 6",
            "Then add 5"
        ]), 10);
        Assert.Equivalent(
            SimonSays([
                "Susan says add 10",
                "Simon says add 3",
                "Simon says multiply by 8"
            ]), 24);
        Assert.Equivalent(SimonSays([
            "Firstly, add 4",
            "Simeon says subtract 100"
        ]), 0);
    }

    private static int SimonSays(List<string> instructions)
    {
        var result = 0;
        foreach (var instruction in instructions)
            if (instruction.StartsWith("Simon"))
            {
                var keyword = new string(instruction.Split("says")[1].Where(char.IsLetter).ToArray());
                var number = new string(instruction.Split("says")[1].Where(char.IsDigit).ToArray());

                switch (keyword)
                {
                    case "add":
                        result += int.Parse(number);
                        break;
                    case "subtract":
                        result -= int.Parse(number);
                        break;
                    case "multiplyby":
                        result *= int.Parse(number);
                        break;
                }
            }

        return result;
    }
}