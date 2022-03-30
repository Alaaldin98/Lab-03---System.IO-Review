using System;
using Xunit;
using Labtest;


namespace TestChallenges
{
    public class UnitTest1
    {
        [Fact]
        public void Challenge1()
        {
            String[] arr = { "1", "2", "3" };
            String[] arr1 = { "1", "2", "3", "4", "5" };
            String[] arr2 = { "1", "2" };
            String[] arr3 = { "-1", "-2", "-3" };
            Assert.Equal(6, Program.Challenge1(arr));
            Assert.Equal(6, Program.Challenge1(arr1));
            Assert.Equal(0, Program.Challenge1(arr2));
            Assert.Equal(-6, Program.Challenge1(arr3));
        }


        [Fact]
        public void Challenge2()
        {
            double[] arr = { 0, 0, 0, 0, 0 };
            double[] arr2 = { 1, 2, 3, 4, 5 };
            double[] arr3 = { 1, 2, 3 };
            Assert.Equal(0, Program.Challenge2(arr));
            Assert.Equal(3, Program.Challenge2(arr2));
            Assert.Equal(2, Program.Challenge2(arr3));
        }
        [Fact]
        public void Challenge4()
        {
            int[] arr = { 0, 0, 0, 0, 0 };
            int[] arr2 = { 1, 1, 2, 2, 3, 3, 3 };
            int[] arr3 = { 1, 2, 3, 4, 5 };
            int[] arr4 = { 1, 1, 3, 4, 5, 1 };
            Assert.Equal(0, Program.Challenge4(arr));
            Assert.Equal(3, Program.Challenge4(arr2));
            Assert.Equal(1, Program.Challenge4(arr3));
            Assert.Equal(1, Program.Challenge4(arr4));
        }
        [Fact]
        public void Challenge5()
        {
            int[] arr = { 1, 1, 1, 1, 1 };
            int[] arr2 = { -1, -2, -3, 4, 5 };
            Assert.Equal(1, Program.Challenge5(arr));
            Assert.Equal(5, Program.Challenge5(arr2));
        }
    }
}
