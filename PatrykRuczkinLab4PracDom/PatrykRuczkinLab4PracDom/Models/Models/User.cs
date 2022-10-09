using System.Security.Principal;

namespace PatrykRuczkinLab4PracDom.Models.Models
{
    public class User
    {
        public User(int id, string firstname, string lastname, string username, string password)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
        }

        public int Id { get; set; }
        public string  Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string  Password { get; set; }
    }
}