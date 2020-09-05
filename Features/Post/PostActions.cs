namespace Features.Post
{
    using BlazorState;
    using System.Collections.Generic;

    public partial class PostState
    {
        public class GetPostsAction : IAction
        {
            public IEnumerable<PostDTO> Posts { get; set; }
        }
    }
}