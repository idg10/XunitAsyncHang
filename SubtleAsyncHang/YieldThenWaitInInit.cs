using Common;
using System.Threading.Tasks;
using Xunit;

namespace SubtleAsyncHang
{
    public abstract class YieldThenWaitInInit : ManyTests, IAsyncLifetime
    {
        public async Task InitializeAsync()
        {
            Task t = WorkWithOnContextContinuationAfterShortDelay();
            await Task.Yield();
            t.Wait();
        }

        public Task DisposeAsync() => Task.FromResult(0);

        private async Task WorkWithOnContextContinuationAfterShortDelay()
        {
            await Task.Delay(10);
        }
    }
}
