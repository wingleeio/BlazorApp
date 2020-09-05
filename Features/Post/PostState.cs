namespace Features.Post
{
    using BlazorState;
    using System.Collections.Generic;

    public partial class PostState : State<PostState>
    {
        public IEnumerable<PostDTO> Posts { get; private set; }

        public override void Initialize() {
            Posts = new List<PostDTO> {};
        }
    }
}