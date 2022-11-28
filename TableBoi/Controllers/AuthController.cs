using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TableBoi.Models;
using TableBoi.Repositories;

namespace TableBoi.Controllers
{

    public class AuthController : Controller
    {
        private readonly UserRepository _userRepository;

        public AuthController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user, string command)
        {
            if (user == null)
                return BadRequest();

            if (string.IsNullOrEmpty(user.Login) || string.IsNullOrEmpty(user.Password) || String.IsNullOrEmpty(command))
            {
                user.ErrorMessage = "Логин или пароль не могут быть пустыми.";
                return View("Index", user);
            }

            if (command.Equals("Войти"))
            {
                UserModel existingUser = _userRepository.GetUserByLogin(user.Login);
                if (existingUser == null)
                {
                    user.ErrorMessage = "Проверьте правильность введенных данных!";
                    return View("Index", user);
                }

                HttpContext.Session.SetString("UserID", existingUser.Id.ToString());
                return RedirectToAction("Index", "Home", existingUser.Id);
            }
            else
            if (command.Equals("Зарегистрироваться"))
            {
                UserModel existUser = _userRepository.GetUserByLogin(user.Login);
                if (existUser != null)
                {
                    user.ErrorMessage = "Заданный логин уже занят!";
                    return View("Index", user);
                }

                _userRepository.AddUser(user);

                return RedirectToAction("Index", "Auth");
            }
            else
                return BadRequest();
        }
    }
}
