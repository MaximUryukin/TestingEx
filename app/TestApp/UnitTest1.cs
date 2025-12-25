    public class UnitTest1
    {
        [Fact]
        public void Test_Sum_Of_Two_Numbers()
        {
            int actual = app.Program.Sum(3, 5);
            Assert.Equal(8, actual);
        }
    }
