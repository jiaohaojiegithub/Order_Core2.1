using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order_Core2.Models;
using Order_Core2.Models.CreateDB;
using Order_Core2.Interfaces;
using Order_Core2.ServiceLogic;

namespace Order_Core2.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiUser_LoginController : ControllerBase
    {
        #region API One
        /*
        private readonly DBMYBLOGAPIContext _context;
        public ApiUser_LoginController(DBMYBLOGAPIContext context)
        {
            _context = context;
            if (_context.User_Login.Count() == 0)
            {
                _context.User_Login.Add(new User_Login { User_Login_ID = 2, User_Login_Name = "Administrator2", User_Login_EmailAddress = "2351592225@qq.com", User_Login_PassWord = "Administrator", User_Login_Right = 0, User_Login_Sex = "男", User_Login_State = false, User_Login_Guid = Guid.NewGuid(), User_Login_CreatDT = DateTime.Now });
                _context.SaveChanges();
            }
        }
        // GET: api/ApiUser_Login
        [HttpGet]
        public ActionResult<List<User_Login>> Get()
        {
            return _context.User_Login.ToList();
        }

        // GET: api/ApiUser_Login/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<User_Login> Get(int id)
        {
            var itme = _context.User_Login.Find(id);
            if (itme == null)
            {
                return NotFound();
            }
            return itme;
        }

        // POST: api/ApiUser_Login
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ApiUser_Login/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
        #endregion
        #region API Two
        private IUser_LoginRepository _LoginRepository;
        public ApiUser_LoginController(IUser_LoginRepository loginRepository)
        {
            _LoginRepository = loginRepository;
        }
        //Get api/ApiUser_Login
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var userLogin =await _LoginRepository.ListAsync();
            return Ok(userLogin);
        }
        #endregion
    }
}
