using Xunit;

namespace Common
{
    /// <summary>
    /// Supplies enough tests to force visibility of problems that only
    /// occur once the number of tests exceeds the number of CPU cores.
    /// </summary>
    /// <remarks>
    /// In some cases, we pair this with 'multiplier' derived types that
    /// scale things up further, for cases where the number of tests has
    /// to be many times greater than the number of cores to demonstrate
    /// problems.
    /// </remarks>
    public abstract class ManyTests
    {
        [Fact]
        public void Test1() { }
        [Fact]
        public void Test2() { }
        [Fact]
        public void Test3() { }
        [Fact]
        public void Test4() { }
        [Fact]
        public void Test5() { }
        [Fact]
        public void Test6() { }
        [Fact]
        public void Test7() { }
        [Fact]
        public void Test8() { }
        [Fact]
        public void Test9() { }
        [Fact]
        public void Test10() { }
        [Fact]
        public void Test11() { }
        [Fact]
        public void Test12() { }
        [Fact]
        public void Test13() { }
        [Fact]
        public void Test14() { }
        [Fact]
        public void Test15() { }
        [Fact]
        public void Test16() { }
        [Fact]
        public void Test17() { }
        [Fact]
        public void Test18() { }
        [Fact]
        public void Test19() { }
        [Fact]
        public void Test20() { }
        [Fact]
        public void Test21() { }
        [Fact]
        public void Test22() { }
        [Fact]
        public void Test23() { }
        [Fact]
        public void Test24() { }
        [Fact]
        public void Test25() { }
        [Fact]
        public void Test26() { }
        [Fact]
        public void Test27() { }
        [Fact]
        public void Test28() { }
        [Fact]
        public void Test29() { }
        [Fact]
        public void Test30() { }
        [Fact]
        public void Test31() { }
        [Fact]
        public void Test32() { }
    }
}
