namespace SpaDay6.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public DateTime Date;
        public User()
        {
            Date = DateTime.UtcNow;
        }
    }
}
