using System;

namespace time_service
{
    public class TimeService
    {
        public (DateTime CurrentTime, string TimeZone) GetCurrentTime()
        {
            return (DateTime.UtcNow, "UTC");
        }
    }
}
