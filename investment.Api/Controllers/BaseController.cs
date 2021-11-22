using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Investment.Api.Controllers
{
    public class BaseController:Controller
    {
        public string FirebaseId => User.Claims.First(x => x.Type.Equals("user_id")).Value;
    }
}
