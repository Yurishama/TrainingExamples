using FluentAssertions;
using Xunit;

namespace CourtesyImplementation._3_TellDontAsk
{
  public class Lol
  {
    [Fact]
    public void Whatever_Anything()
    {
      //GIVEN
      var elephantCounter = new ElephantCounter();
      var box = new Box(
        new Box(
          new Elephant()
        ), 
        new Box(
          new Box(
            new Elephant(),
            new Elephant(),
            new Melon(),
            new Elephant()
          ), 
          new Elephant()
        )
      );

      //WHEN
      box.AddTo(elephantCounter);
      var count = elephantCounter.Value();

      //THEN
      count.Should().Be(5);
    }
  }
}