using Domain.Entities;

namespace WebAPI.ViewModel
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }

        public UserViewModel(Users user)
        {
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Email = user.Email;
            this.Username = user.Username;
            this.DateOfBirth = user.DateOfBirth;
            this.CreatedAt = user.CreatedAt;
        }
    }
}
