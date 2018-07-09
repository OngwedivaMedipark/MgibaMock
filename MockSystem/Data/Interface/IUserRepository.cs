using MockSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSystem.Data.Interface
{
   public interface IUserRepository
    {
      IEnumerable<User> GetUsers { get; }
      void AddUser(User user);
      void EditUser(int Id,User user);
      void RemoveUser(int id);  


    }
}
