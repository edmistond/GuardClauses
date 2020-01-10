using System;
using Ardalis.GuardClauses;
using FluentAssertions;
using FsCheck;
using FsCheck.Xunit;
using GuardClauses.UnitTests.Helpers;

namespace GuardClauses.UnitTests
{
  [Properties(Arbitrary = new []{typeof(CoreArbitrary)})]
  public class GuardAgainstOutOfRangeForDateTimeFuzzy
  {

    // [Fact]
    // public void OutOfRangeForDateTimeFuzzyThrowsNoExceptionsWhenInRange() =>
    //   Prop.ForAll(DateTimeGenerators.GenerateDateTimeRanges(), dtr =>
    //   {
    //     Action action = () => Guard.Against.OutOfRange(dtr.Actual, nameof(dtr.Actual), dtr.RangeFrom, dtr.RangeTo);
    //     action.Should().NotThrow();
    //   }).QuickCheckThrowOnFailure();

    [Property(Verbose = true)]
    public void OutOfRangeForDateTimeFuzzyTestThrowsNoExceptionWhenInRange(DateTimeRange range)
    {
      Action action = () => Guard.Against.OutOfRange(range.Actual, nameof(range.Actual), range.RangeFrom, range.RangeTo);

      action.Should().NotThrow();
    }
  }
}