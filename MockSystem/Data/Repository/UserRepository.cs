using MockSystem.Data.Interface;
using MockSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSystem.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext )
        {
            _dataContext = dataContext;
        }

        public IEnumerable<User> GetUsers => _dataContext.User.ToList();

        public User GetUser(int id) => _dataContext.User.FirstOrDefault(c=>c.Id == id);

        public void AddUser(User user)
        {
            var usr = _dataContext.User.FirstOrDefault(c => c.Id == user.Id);
            if (user == null)
            {
                _dataContext.Add(user);
            }
            _dataContext.SaveChanges();
           
        }

        public void EditUser(int Id,User user)
        {
            var usr = _dataContext.User.Find(Id);
            if (usr != null)
            {
                usr.FirstName = user.FirstName;
                usr.FirstName = user.LastName;
                usr.Email = user.Email;
                usr.Occupation = user.Occupation;
            }
            _dataContext.SaveChanges();
        }

        public void RemoveUser(int id)
        {
            var user = _dataContext.User.Find(id);
            if (user != null)
            {
                _dataContext.User.Remove(user);               
            }
            _dataContext.SaveChanges();

        }
    }
}
