using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Order_Core2.Interfaces;
using Order_Core2.DBModels;
using Order_Core2.Models.CreateDB;
namespace Order_Core2.Controllers
{
    public class User_LoginController : Controller
    {
        private IUser_LoginRepository _LoginRepository;
        public User_LoginController(IUser_LoginRepository loginRepository)
        {
            _LoginRepository = loginRepository;
        }
        /// <summary>
        /// 输出所有数据视图
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var UserLogin = await _LoginRepository.ListAsync();
            return View(UserLogin);
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(User_LoginModel user_Login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _LoginRepository.AddAsync(new User_Login
            {
                User_Login_EmailAddress=user_Login.User_Login_EmailAddress,
                User_Login_Name=user_Login.User_Login_Name,
                User_Login_PassWord=user_Login.User_Login_PassWord,
                User_Login_Right=user_Login.User_Login_Right,
                User_Login_Sex=user_Login.User_Login_Sex,
                User_Login_State=user_Login.User_Login_State
            });
            return RedirectToAction("Index");
        }
    }
}