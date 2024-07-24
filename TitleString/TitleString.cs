using static System.Char;

namespace TitleString
{
    public static class TitleString
    {
        [Fact]
        public static void CheckTitleTrue()
        {
            Assert.True(CheckTitle("A Mind Boggling Achievement"));
            Assert.True(CheckTitle("A Simple C++ Program!"));
        }

        [Fact]
        public static void CheckTitleFalse()
        {
            Assert.False(CheckTitle("Water is transparent"));
        }

        private static bool CheckTitle(string title)
        {
            return title.Split(' ').Count(word => IsUpper(word[0])) == title.Split(' ').Length;
        }
    }
}