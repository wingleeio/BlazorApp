namespace Features.Counter
{
  using BlazorState;

  public partial class CounterState
  {
    public class IncrementCountAction : IAction
    {
      public int Amount { get; set; }
    }

    public class ReduceCountAction : IAction
    {
      public int Amount { get; set; }
    }
  }
}