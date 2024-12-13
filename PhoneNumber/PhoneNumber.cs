using System.Text.RegularExpressions;

namespace PhoneNumber;

public class PhoneNumberProblem
{
    [Fact]
    public void PhoneNumberTests()
    {
        Assert.Equivalent(IsFormattedPhoneNumber("(123) 456-7890"), true);
        Assert.Equivalent(IsFormattedPhoneNumber("1111)555 2345"), false);
        Assert.Equivalent(IsFormattedPhoneNumber("098) 123 4567"), false);
    }

    private static bool IsFormattedPhoneNumber(string phoneNumber)
    {
        return Regex.IsMatch(phoneNumber, "\\([0-9]+\\)\\s[0-9]+-[0-9]+");
    }
}