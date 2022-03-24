using System;
using Xunit;
using Labtest;

namespace TestChallenges
{
    public class UnitTest1
    {
        [Theory]
       
        [InlineData(788)]
       
        public void Challenge5( int expected)
        {
            int actual = Program.Challenge5();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Challenge2()
        {
            Assert.Equal(70, Program.Challenge2());
        }
        [Theory]
      
        [InlineData( 66)]
        public void Challenge4( int expected)
        {
            int actual = Program.Challenge4();
            Assert.Equal(expected, actual);
        }
    }
}
