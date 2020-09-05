namespace Features.User
{
    using BlazorState;
    using System.Collections.Generic;

    public partial class UserState : State<UserState>
    {
        public IEnumerable<UserDTO> Users { get; private set; }

        public override void Initialize() {
            Users = new List<UserDTO> {};
        }
    }
}