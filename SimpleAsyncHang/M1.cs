namespace SimpleAsyncHang
{
    // Multiplies the number of tests up to 256.
    // With this many tests the test run hangs with just 4 tests
    // in progress on a machine with 4 hardware threads, but if
    // we reduce the number to 64, it seems to run just fine!
    public class M1
    {
        public class D1 : WaitInInit { }
        public class D2 : WaitInInit { }
        public class D3 : WaitInInit { }
        public class D4 : WaitInInit { }
        public class D5 : WaitInInit { }
        public class D6 : WaitInInit { }
        public class D7 : WaitInInit { }
        public class D8 : WaitInInit { }
    }
}
