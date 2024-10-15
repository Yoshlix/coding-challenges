using System.Collections;
using System.Diagnostics;

namespace PingPong;

public class PingPongProblem
{
    [Fact]
    public void PingPongTests()
    {
        Assert.Equivalent(PingPong(["Ping!"], true), new ArrayList {"Ping!", "Pong!"});
        Assert.Equivalent(PingPong(["Ping!", "Ping!"], false), new ArrayList { "Ping!", "Pong!", "Ping!"});
        Assert.Equivalent(PingPong(["Ping!", "Ping!", "Ping!"], true), new ArrayList {"Ping!", "Pong!", "Ping!", "Pong!", "Ping!", "Pong!"});
    }

    private static ArrayList PingPong(ArrayList input, Boolean win)
    {
        var length = input.Count;
        for (var i = 1; i < length;)
        {
            input.Insert(i, "Pong!");
            i += 2;
        }

        switch (win)
        {
            case true when input[^1] is not "Pong!":
                input.Add("Pong!");
                break;
            case false when input[^1] is "Pong!":
                input[^1] = "Ping!";
                break;
        }
        
        return input;
    }
}