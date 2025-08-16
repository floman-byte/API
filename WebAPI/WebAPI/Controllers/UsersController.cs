using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserRepository _userService;

        public UsersController(ILogger<UsersController> logger, IUserRepository userService)
        {
            _logger = logger;
            _userService = userService;
        }
        // GET: api/users
        [HttpGet(Name = "GetUser")]
        public UserViewModel Get()
        {
            UserViewModel user = new UserViewModel(_userService.GetUserById(2));
            return user;
        }
    }
}
