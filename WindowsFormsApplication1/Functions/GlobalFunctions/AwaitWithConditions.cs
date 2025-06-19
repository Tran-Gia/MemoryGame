using System;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Functions.GlobalFunctions
{
    public static class AwaitWithConditions
    {
        const int MAX_TIMEOUT = 600000; //10 mins
        public static async Task UntilFulfilled(Func<bool> condition, int timeout = MAX_TIMEOUT)
        {
            var time = 0;
            while (!condition())
            {
                if (time > timeout)
                {
                    throw new TimeoutException("Condition was not met within the specified timeout.");
                }
                await Task.Delay(100);
                time += 100;
            }
        }

        public static async Task AdditionalTimeoutWhileTrue(Func<bool> condition, int awaitTime, bool allowInfiniteTimeout = false)
        {
            var time = 0;
            var accumulativeTime = 0;
            while (time < awaitTime)
            {
                await Task.Delay(100);
                if(!condition())
                {
                    time += 100;
                }

                accumulativeTime += 100;
                if (accumulativeTime >= MAX_TIMEOUT && !allowInfiniteTimeout)
                {
                    throw new TimeoutException("Condition has been true for a very long time.");
                }
            }
        }
    }
}
