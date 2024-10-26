namespace VideoLengthToSeconds;

public class VideoLengthToSecondsChallenge
{
    [Fact]
    public void VideoLengthToSecondsTests()
    {
        Assert.Equivalent(MinutesToSeconds("01:00"), 60);
        Assert.Equivalent(MinutesToSeconds("13:56"), 836);
        Assert.Equivalent(MinutesToSeconds("10:60"), -1);
        Assert.Equivalent(MinutesToSeconds("121:49"), 7309);
    }

    private static int MinutesToSeconds(string videoLength)
    {
        var minutes = int.Parse(videoLength.Split(':')[0]);
        var seconds = int.Parse(videoLength.Split(':')[1]);

        if (seconds >= 60) return -1;

        return minutes * 60 + seconds;
    }
}