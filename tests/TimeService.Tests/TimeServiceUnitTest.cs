using System;
using Xunit;
using time_service;

public class TimeServiceTests
{
    [Fact]
    public void GetCurrentTime_ReturnsCurrentUtcTime()
    {
        // Arrange
        var service = new TimeService();

        // Act
        var (currentTime, timeZone) = service.GetCurrentTime();

        // Assert
        var now = DateTime.UtcNow;
        Assert.Equal("UTC", timeZone);
        Assert.True((now - currentTime).TotalSeconds < 2, $"Expected time within 2 seconds of now, but got {currentTime}");
    }

    [Fact]
    public void GetCurrentTime_TimeZoneIsAlwaysUtc()
    {
        var service = new TimeService();
        var (_, timeZone) = service.GetCurrentTime();
        Assert.Equal("UTC", timeZone);
    }

    [Fact]
    public void GetCurrentTime_ReturnedTimeIsNotInFuture()
    {
        var service = new TimeService();
        var (currentTime, _) = service.GetCurrentTime();
        Assert.True(currentTime <= DateTime.UtcNow, $"Returned time {currentTime} should not be in the future");
    }

    [Fact]
    public void GetCurrentTime_MultipleCallsTimeIncreasesOrSame()
    {
        var service = new TimeService();
        var (firstTime, _) = service.GetCurrentTime();
        System.Threading.Thread.Sleep(10); // 10 ms
        var (secondTime, _) = service.GetCurrentTime();
        Assert.True(secondTime >= firstTime, $"Second call time {secondTime} should be >= first call time {firstTime}");
    }
}
