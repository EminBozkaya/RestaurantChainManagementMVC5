using System;

namespace RCM.Model.Complex.DashBoard.SystemManagement.User
{
    public class UpdateUserVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime ModifiedTime { get; set; }
        public bool State { get; set; }
    }
}
