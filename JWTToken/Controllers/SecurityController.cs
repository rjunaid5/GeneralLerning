using Microsoft.AspNetCore.Mvc;

namespace JWTToken.Controllers
{
    /*
     - JWT is a JSON web token which is granted to user
     - process is user enters Username and password for first time and after server authenticates User it will send user token
     - user will use that token in the calls instead of using user name and password
     - Following things will be checked while authenticating
    1- username and password
    2- roles and claims of the user based on username
    3- Secret Key(Based on Roles and other credentials)
    4- Token Expiration Time
    5- Token creator/issuer of token
     
     */
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
