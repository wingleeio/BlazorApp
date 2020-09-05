namespace Features.User
{
    using System.Threading;
    using System.Threading.Tasks;
    using BlazorState;
    using MediatR;

    public partial class UserState
    {
        public class GetUserHandler : ActionHandler<GetUsersAction>
        {
            public GetUserHandler(IStore aStore) : base(aStore) { }

            UserState UserState => Store.GetState<UserState>();

            public override Task<Unit> Handle(GetUsersAction aGetUsersAction, CancellationToken aCancellationToken)
            {
                UserState.Users = aGetUsersAction.Users;
                return Unit.Task;
            }
        }
    }
}