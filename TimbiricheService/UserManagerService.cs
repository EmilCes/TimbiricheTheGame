using DataAccessTimbiriche;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TimbiricheService
{
    public class UserManagerService : IUserManager
    {
        public int AddUser(Account account, Player player)
        {

            Accounts newAccount = new Accounts();
            newAccount.name = account.Name;
            newAccount.lastName = account.LastName;
            newAccount.surname = account.Surname;
            newAccount.birthdate = account.Birthdate;

            Players newPlayer = new Players();
            newPlayer.username = player.Username;
            newPlayer.email = player.Email;
            newPlayer.password = player.Password;

            DataAccessTimbiriche.UserManagement DAO = new DataAccessTimbiriche.UserManagement();
            DAO.AddUser(newAccount, newPlayer);

            return 0;
        }
    }
}
