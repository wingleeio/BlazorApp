namespace Features.Counter
{
  using System.Threading;
  using System.Threading.Tasks;
  using BlazorState;
  using MediatR;

  public partial class CounterState
  {
    public class IncrementCountHandler : ActionHandler<IncrementCountAction>
    {
      public IncrementCountHandler(IStore aStore) : base(aStore) { }

      CounterState CounterState => Store.GetState<CounterState>();

      public override Task<Unit> Handle(IncrementCountAction aIncrementCountAction, CancellationToken aCancellationToken)
      {
        CounterState.Count = CounterState.Count + aIncrementCountAction.Amount;
        return Unit.Task;
      }
    }

    public class ReduceCountHandler : ActionHandler<ReduceCountAction>
    {
      public ReduceCountHandler(IStore aStore) : base(aStore) { }

      CounterState CounterState => Store.GetState<CounterState>();

      public override Task<Unit> Handle(ReduceCountAction aReduceCountAction, CancellationToken aCancellationToken)
      {
        CounterState.Count = CounterState.Count - aReduceCountAction.Amount;
        return Unit.Task;
      }
    }
  }
}