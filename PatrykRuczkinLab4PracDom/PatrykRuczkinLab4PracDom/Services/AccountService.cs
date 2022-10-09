using System.Collections.Generic;
using System.Linq;
using PatrykRuczkinLab4PracDom.Models;
using PatrykRuczkinLab4PracDom.Models.Models;

namespace PatrykRuczkinLab4PracDom.Services
{
    public interface IAccountService
    {
        void Register(RegisterUserDto dto);
        string Login(LoginUserDto dto);

    }

    public class AccountService : IAccountService
    {
        private List<User> _users;

        public AccountService()
        {
            //user list from code - easy to change it with db
            _users = new List<User>()
            {
                new User(1, "Patryk", "Ruczkin", "Ruczu", "123"),
                new User(2, "Jan", "Kowalski", "JK", "123")
            };
        }
        /// <summary>
        /// Adding user to user list
        /// </summary>
        /// <param name="dto"></param>
        public void Register(RegisterUserDto dto)
        {
            var id = _users.Count + 1;
            var user = new User(id, dto.Firstname, dto.Lastname, dto.Username, dto.Password);
            _users.Add(user);
        }

        /// <summary>
        /// finding user by username and password, returning username if found
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public string Login(LoginUserDto dto)
        {
            var user = _users.FirstOrDefault(u => u.Username == dto.Username && u.Password == dto.Password);
            if (user is null) return "";
            return user.Username;
        }
    }
}