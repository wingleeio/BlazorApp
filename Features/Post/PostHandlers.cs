namespace Features.Post
{
    using System.Threading;
    using System.Threading.Tasks;
    using BlazorState;
    using MediatR;

    public partial class PostState
    {
        public class GetPostHandler : ActionHandler<GetPostsAction>
        {
            public GetPostHandler(IStore aStore) : base(aStore) { }

            PostState PostState => Store.GetState<PostState>();

            public override Task<Unit> Handle(GetPostsAction aGetPostsAction, CancellationToken aCancellationToken)
            {
                PostState.Posts = aGetPostsAction.Posts;
                return Unit.Task;
            }
        }
    }
}