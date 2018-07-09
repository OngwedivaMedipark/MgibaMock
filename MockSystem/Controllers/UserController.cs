using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockSystem.Data;
using MockSystem.Data.Interface;
using MockSystem.Data.Model;
using MockSystem.Data.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MockSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IUserRepository _userRepository;
        UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            _userRepository.AddUser(user);
            return View(user);
        }

    }
}
