namespace Features.User
{
    using BlazorState;
    using System.Collections.Generic;

    public partial class UserState
    {
        public class GetUsersAction : IAction
        {
            public IEnumerable<UserDTO> Users { get; set; }
        }
    }
}