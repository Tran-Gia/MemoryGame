using System;
using System.Threading.Tasks;
using WindowsFormsApplication1.Constants;

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
                await Task.Delay(DefaultValues.TimerInterval);
                time += DefaultValues.TimerInterval;
            }
        }

        public static async Task AdditionalTimeoutWhileTrue(Func<bool> condition, int awaitTime, bool allowInfiniteTimeout = false)
        {
            var time = 0;
            var accumulativeTime = 0;
            while (time < awaitTime)
            {
                await Task.Delay(DefaultValues.TimerInterval);
                if(!condition())
                {
                    time += DefaultValues.TimerInterval;
                }

                accumulativeTime += DefaultValues.TimerInterval;
                if (accumulativeTime >= MAX_TIMEOUT && !allowInfiniteTimeout)
                {
                    throw new TimeoutException("Condition has been true for a very long time.");
                }
            }
        }
    }
}
