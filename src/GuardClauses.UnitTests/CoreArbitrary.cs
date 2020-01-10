using FsCheck;
using GuardClauses.UnitTests.Helpers;

namespace GuardClauses.UnitTests
{
  public class CoreArbitrary
  {
    public static Arbitrary<DateTimeRange> DateTimeRange() => Arb.From(DateTimeGenerators.GenerateDateTimeRanges());
  }
}