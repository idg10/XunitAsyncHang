using Common;
using System.Threading.Tasks;
using Xunit;

namespace SimpleAsyncHang
{
    public abstract class WaitInInit : ManyTests, IAsyncLifetime
    {
        public Task InitializeAsync()
        {
            WorkWithContextBoundContinuationAfterShortDelay().Wait();
            return Task.FromResult(0);
        }

        public Task DisposeAsync() => Task.FromResult(0);

        private async Task WorkWithContextBoundContinuationAfterShortDelay()
        {
            await Task.Delay(10);
        }
    }
}