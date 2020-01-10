using System;
using FsCheck;
using GuardClauses.UnitTests.Helpers;

namespace GuardClauses.UnitTests
{
  public static class DateTimeGenerators
  {
    public static Gen<DateTime> DateTimes() =>
      from dt in Arb.Default.DateTime().Generator
      select dt;

    public static Gen<DateTimeRange> GenerateDateTimeRanges() =>
      from rangeFrom in DateTimes()
      from rangeTo in DateTimes()
      where rangeTo > rangeFrom
      select new DateTimeRange {RangeFrom = rangeFrom, RangeTo = rangeTo};

    public static Gen<DateTime> GenerateDateTimeInRange(DateTime rangeFrom, DateTime rangeTo) =>
      from dt in DateTimes()
      where dt >= rangeFrom && dt <= rangeTo
      select dt;
  }
}