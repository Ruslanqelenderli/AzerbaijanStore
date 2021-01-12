using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerbaijanStore.Models
{
    public class Database
    {

        private static List<User> _users;

        public bool IfUserExist(string workid, string password)
        {
            
            bool result = false;
            foreach(User user in _users)
            {
                if (user.WorkID.ToLower() == workid.ToLower() && user.Password == password)
                {
                    result = true;
                }
            }
            return result;

        } 

        public Database()
        {
            if (_users == null)
                _users = new List<User>();
        }
        public  void AddUser(User user)
        {
            _users.Add(user);
        }
        public static void RemoveUser(User user)
        {
            _users.Remove(user);
        }

    } 
}
