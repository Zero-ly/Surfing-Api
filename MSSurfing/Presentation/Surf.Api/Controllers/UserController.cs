using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Surf.Core.Entities.Users;
using Surf.Http.Framework.Controllers;
using Surf.Services.Users;

namespace Surf.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        #region Fields
        private readonly IUserService _userService;
        #endregion

        #region Ctor
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        [HttpGet, Route("list")]
        public string List()
        {
            var list = _userService.Search();
            return Ok2(Data: list);
        }

        [HttpGet, Route("adduser")]
        public ActionResult Add()
        {
            var user = new User()
            {
                Username = "Ab",
                Name = "fdf",
                Password = "fdf",
                PasswordSalt = "fdfe",
                Active = true,
                Deleted = false,
            };
            _userService.Insert(user);
            return Ok();
        }
    }
}